using Entities.Layer.Models;
using Entities.Layer.DTOs;

namespace Entities.Layer.DTOs.CourseDtos
{
    public class CourseCreateDto 
    {

        public String CourseName { get; set; }
        public CourseDetail CourseDetail { get; set; }

    }
}
