
using Entities.Layer.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Layer.DTOs.CourseDetailDtos
{
    public record CourseDetailDto
    {
        [Required]
        public int CourseId { get; set; }
        public byte AbsenceLimit { get; set; }
        public byte CurrentAbsence { get; set; }
        public String? Description { get; set; }
    
    }
}
