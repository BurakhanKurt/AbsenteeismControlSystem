
namespace Entities.DTOs.CourseDetailDtos
{
    public record CourseDetailDto
    {
        public byte AbsenceLimit { get; set; }
        public byte CurrentAbsence { get; set; }
        public String? Description { get; set; }
        public DateTime? ExamTime { get; set; } 
    }
}
