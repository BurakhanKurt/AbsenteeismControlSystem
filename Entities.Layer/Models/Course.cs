
namespace Entities.Models
{
    public class Course : BaseEntity
    {
        public int Id { get; set; }
        public String CourseName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public CourseDetail CourseDetail { get; set; }
        public ICollection<CourseCalendar> CourseCalendars { get; set; }
    }
}
