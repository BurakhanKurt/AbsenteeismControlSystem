

namespace Entities.DTOs.CourseDtos
{
    public record CourseUpdateDto : BaseDto
    {
        public string CourseName { get; init; }
    }
}
