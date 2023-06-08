
using System.ComponentModel.DataAnnotations;

namespace Entities.Layer.DTOs.CourseDetailDtos
{
    public record CourseDetailDto
    {
        [Required]
        public int CourseId { get; set; }
        public byte AbsenceLimit { get; set; }
        public byte CurrentAbsence { get; set; }
        public String? Description { get; set; }
        public DateTime? ExamTime { get; set; }
    }
}
