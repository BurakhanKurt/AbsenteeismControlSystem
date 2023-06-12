
using Entities.Layer.DTOs.CourseDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Layer.DTOs.CourseDtos
{
    public record CourseCreateDto : CourseDto
    {
        public CourseDetailDto courseDetail { get; set; }
    }
}
