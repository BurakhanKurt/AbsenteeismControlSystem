
namespace Entities.Layer.Models
{
    public class CourseCalendar :BaseEntity
    {
        public int CourseId { get; set; }
        public byte DayId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Course Course { get; set; }
        public Day Day { get; set; }
    }
}
