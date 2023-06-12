

using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace Entities.Layer.DTOs.CourseCalendarDtos
{
    public record CourseCalendarDto
    {
        public int CourseId { get; set; }
        public byte DayId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
