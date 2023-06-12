

using Entities.Layer.DTOs.CourseCalendarDtos;
using Entities.Layer.Models;

namespace Entities.Layer.DTOs.SyllabusDtos
{
    public record SyllabusDto
    {
        public byte Id { get; set; }
        public String DayName { get; set; }

        public ICollection<CourseCalendarForSyllabusDto> CourseCalendars { get; set; }
    }
}
