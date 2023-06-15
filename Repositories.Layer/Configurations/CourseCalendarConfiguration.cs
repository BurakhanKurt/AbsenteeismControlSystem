using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations
{
    public class CourseCalendarConfiguration : IEntityTypeConfiguration<CourseCalendar>
    {
        public void Configure(EntityTypeBuilder<CourseCalendar> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.isDeleted).IsRequired();
            builder.Property(x => x.isActive).IsRequired();

            builder.HasKey(x => new { x.DayId, x.CourseId });
            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();

            builder.HasOne(x => x.Course)
                .WithMany(x => x.CourseCalendars)
                .HasForeignKey(x => x.CourseId);

            builder.HasOne(x => x.Day)
                .WithMany(x => x.CourseCalendars)
                .HasForeignKey(x => x.DayId);
        }
    }
}
