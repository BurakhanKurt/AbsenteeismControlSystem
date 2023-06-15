using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Seeds
{
    public class CourseDetailSeed : IEntityTypeConfiguration<CourseDetail>
    {
        public void Configure(EntityTypeBuilder<CourseDetail> builder)
        {
            builder.HasData(
                new CourseDetail { 
                    CourseId = 1,
                    AbsenceLimit = 4, 
                    CurrentAbsence = 0, 
                    Description = "My favorite course 1", 
                    ExamTime = DateTime.Now.AddDays(7),
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                }, 
                new CourseDetail { 
                    CourseId = 2, 
                    AbsenceLimit = 4, 
                    CurrentAbsence= 1, 
                    Description = "My favorite course 2",
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    isDeleted = false
                }
               );
        }
    }
}
