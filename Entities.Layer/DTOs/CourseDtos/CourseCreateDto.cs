
using Entities.DTOs.CourseDetailDtos;

namespace Entities.DTOs.CourseDtos
{
    public record CourseCreateDto : CourseDto
    {
        public CourseDetailDto courseDetail { get; init; }
    }
}
