using Entities.Layer.DTOs.CourseDtos;

namespace Entities.Layer.DTOs.CourseCalendarDtos
{
    public record CourseCalendarForSyllabusDto : CourseCalendarDto
    {
        public CourseDto Course { get; set; }
    }
}
