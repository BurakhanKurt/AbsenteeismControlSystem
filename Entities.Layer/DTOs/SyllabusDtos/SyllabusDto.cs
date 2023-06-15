
using Entities.DTOs.CourseCalendarDtos;

namespace Entities.DTOs.SyllabusDtos
{
    public record SyllabusDto
    {
        public byte Id { get; set; }
        public String DayName { get; set; }

        public ICollection<CourseCalendarForSyllabusDto> CourseCalendars { get; set; }
    }
}
