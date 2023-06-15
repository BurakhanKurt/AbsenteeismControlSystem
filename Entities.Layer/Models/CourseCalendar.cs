
namespace Entities.Models
{
    public class CourseCalendar : BaseEntity
    {
        public int CourseId { get; set; }
        public byte DayId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Course Course { get; set; }
        public Day Day { get; set; }
    }
}
