using Entities.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Layer.Seeds
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
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                },
                new CourseCalendar
                {
                    CourseId = 2,
                    DayId = 2,
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                }, 
                new CourseCalendar
                {
                    CourseId = 2,
                    DayId = 3,
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                }
               );
        }
    }
}
