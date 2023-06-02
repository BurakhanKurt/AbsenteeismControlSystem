

namespace Entities.Layer.Models
{
    public class Day
    {
        public byte Id { get; set; }
        public String DayName { get; set; }
        public ICollection<CourseDetail> Courses { get; set; }
    }
}
