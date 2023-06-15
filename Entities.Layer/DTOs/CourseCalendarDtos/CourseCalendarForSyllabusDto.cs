using Entities.DTOs.CourseDtos;

namespace Entities.DTOs.CourseCalendarDtos
{
    public record CourseCalendarForSyllabusDto : CourseCalendarDto
    {
        public CourseDto Course { get; init; }
    }
}
