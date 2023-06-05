
using System.ComponentModel.DataAnnotations;

namespace Entities.Layer.Models
{
    public class Day
    {
        public byte Id { get; set; }
        
        [MaxLength(15)]
        public String DayName { get; set; }

        public ICollection<CourseCalendar> CourseCalendars { get; set; }
    }
}
