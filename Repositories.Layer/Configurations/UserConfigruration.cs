
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Repositories.Configurations
{
    public class UserConfigruration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.isDeleted).IsRequired();
            builder.Property(x => x.isActive).IsRequired();

            builder.ToTable("Users");
        }
    }
}
