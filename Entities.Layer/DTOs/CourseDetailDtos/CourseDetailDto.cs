
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
        public DateTime? ExamTime { get; set; }
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public DateTime? UpdateDate { get; set; }
        [JsonIgnore]
        public DateTime? DeletedDate { get; set; }
        [JsonIgnore]
        public DateTime? HardDeletedDate { get; set; }
        [JsonIgnore]
        public bool isActive { get; set; }
        [JsonIgnore]
        public bool isDeleted { get; set; }
    }
}
