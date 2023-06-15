
namespace Entities.DTOs.CourseDetailDtos
{
    public record CourseDetailDto
    {
        public byte AbsenceLimit { get; init; }
        public byte CurrentAbsence { get; init; }
        public String? Description { get; init; }
        public DateTime? ExamTime { get; init; } 
    }
}
