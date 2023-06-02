

namespace Entities.Layer.Models
{
    public class Course : BaseEntity
    {
        public String CourseName { get; set; }
        public int UserId { get; set; }
        public byte AbsenceLimit { get; set; }
        public byte CurrentAbsence { get; set; }
        public User User { get; set; }
        public ICollection<CourseDetail> Days { get; set; }
    }
}
