using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Seeds
{
    public class CourseCalendarSeed : IEntityTypeConfiguration<CourseCalendar>
    {
        public void Configure(EntityTypeBuilder<CourseCalendar> builder)
        {
            builder.HasData(
                new CourseCalendar
                {
                    CourseId = 1,
                    DayId = 1,
                    StartTime = new TimeSpan(8,0,0),
                    EndTime = new TimeSpan(12, 0, 0),
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                },
                new CourseCalendar
                {
                    CourseId = 2,
                    DayId = 2,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(11, 0, 0),
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                },
                new CourseCalendar
                {
                    CourseId = 2,
                    DayId = 3,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(12, 0, 0),
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                }
               );
        }
    }
}
