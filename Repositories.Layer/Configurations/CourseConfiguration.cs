
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.CourseName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CreatedDate).IsRequired();
       
            builder.HasOne(x => x.User)
                   .WithMany(x => x.Courses)
                   .HasForeignKey(x => x.UserId);

            builder.ToTable("Courses");
        }
    }
}
