
using Entities.Layer.Models;

namespace Entities.Layer.DTOs.CourseDtos
{
    public record CourseCreateDto 
    {
        public String CourseName { get; set; }
        public CourseDetail CourseDetail { get; set; }


    }
}
