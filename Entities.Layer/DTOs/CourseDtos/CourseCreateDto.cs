
using Entities.Layer.Models;

namespace Entities.Layer.DTOs.CourseDtos
{
    public record CourseCreateDto : CourseDto
    {
        public CourseDetail CourseDetail { get; set; }
    }
}
