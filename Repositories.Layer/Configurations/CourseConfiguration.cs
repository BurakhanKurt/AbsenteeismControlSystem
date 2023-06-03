using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Layer.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            
            builder.Property(x => x.CourseName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.isDeleted).IsRequired();
            builder.Property(x => x.isActive).IsRequired();
            
            builder.HasMany(x => x.CourseCalendars)
                   .WithOne(x => x.Course)
                   .IsRequired();

            builder.HasOne(x => x.CourseDetail)
                   .WithOne(x => x.Course)
                   .IsRequired();

            builder.HasOne(x => x.User)
                   .WithMany(x=> x.Courses)
                   .IsRequired();

            builder.ToTable("Courses");
        }
    }
}
