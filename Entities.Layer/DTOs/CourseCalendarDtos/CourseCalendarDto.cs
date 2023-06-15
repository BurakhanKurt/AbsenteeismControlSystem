

namespace Entities.DTOs.CourseCalendarDtos
{
    public record CourseCalendarDto
    {
        public int CourseId { get; init; }
        public byte DayId { get; init; }
        public TimeSpan StartTime { get; init; }
        public TimeSpan EndTime { get; init ; }
    }
}
