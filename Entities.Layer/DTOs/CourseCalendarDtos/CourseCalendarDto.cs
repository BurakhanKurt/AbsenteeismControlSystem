

using System.Text.Json.Serialization;

namespace Entities.Layer.DTOs.CourseCalendarDtos
{
    public record CourseCalendarDto
    {

        public int CourseId { get; set; }
        public byte DayId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set ; }
    }
}
