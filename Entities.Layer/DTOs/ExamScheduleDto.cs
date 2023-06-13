using Entities.Layer.DTOs.CourseDtos;


namespace Entities.Layer.DTOs
{
    public record ExamScheduleDto 
    {
        public CourseDto Course { get; set; }
        public DateTime ExamTime { get; set; }
    }
}
