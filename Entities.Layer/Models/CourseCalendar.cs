using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Layer.Models
{
    public class CourseCalendar
    {
        // Todo Fluent Api ile ilişki oluşturulacak
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }

        [ForeignKey(nameof(Day))]
        public byte DayId { get; set; }

        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public Course Course { get; set; }
        public Day Day { get; set; }
        
    }
}
