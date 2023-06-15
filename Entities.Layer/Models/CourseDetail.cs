
namespace Entities.Models
{
    public class CourseDetail : BaseEntity
    {
        public int CourseId { get; set; }
        public byte AbsenceLimit { get; set; }
        public byte CurrentAbsence { get; set; }
        public String? Description { get; set; }
        public DateTime? ExamTime { get; set; }
        public Course Course { get; set; }
    }
}
