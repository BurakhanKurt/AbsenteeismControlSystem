
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Seeds
{
    public class CourseSeed : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                new Course
                {
                    Id = 1,
                    CourseName = "Matematik",
                    UserId = 1,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false,
                    
                }, 
                new Course
                {
                    Id = 2,
                    CourseName = "Turkce",
                    UserId = 1,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false,
                }
                );
        }
    }
}
