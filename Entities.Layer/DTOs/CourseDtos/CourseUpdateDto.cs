using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Layer.DTOs.CourseDtos
{
    public record CourseUpdateDto : BaseDto
    {
        public string CourseName { get; set; }
    }
}
