
using Entities.DTOs.CourseDtos;

namespace Entities.DTOs
{
    public record ExamScheduleDto 
    {
        public CourseDto Course { get; set; }
        public DateTime ExamTime { get; set; }
    }
}
