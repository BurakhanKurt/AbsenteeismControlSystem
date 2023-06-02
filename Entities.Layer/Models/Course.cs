

namespace Entities.Layer.Models
{
    public class Course : BaseEntity
    {
        public String CourseName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public ICollection<CourseCalendar> CourseCalendars { get; set; }
    }
}
