using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var user = new User
            {
                Id = 1,
                UserName = "admin1",
                NormalizedUserName = "ADMİN1",
                Email = "admin1@admin.com",
                NormalizedEmail = "admin1@GMAIL.COM",
                PhoneNumber = "+9053399999991",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                isActive = true,
                isDeleted = false
            };
            user.PasswordHash = CreatePasswordHash(user, "admin123");

            builder.HasData(user);
            
        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
