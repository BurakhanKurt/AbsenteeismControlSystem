
using Entities.Layer.DTOs.CourseDetailDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Layer.DTOs.CourseDtos
{
    public class CourseCreateDto : CourseDto
    {
        CourseDetailDto courseDetail { get; set; }
    }
}
