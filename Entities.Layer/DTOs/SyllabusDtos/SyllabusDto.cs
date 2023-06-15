
using Entities.DTOs.CourseCalendarDtos;

namespace Entities.DTOs.SyllabusDtos
{
    public record SyllabusDto
    {
        public byte Id { get; init; }
        public String DayName { get; init; }

        public ICollection<CourseCalendarForSyllabusDto> CourseCalendars { get; init; }
    }
}