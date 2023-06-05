using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Entities.Layer.Models
{
    public class CourseDetail
    {
        [Key,ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public byte AbsenceLimit { get; set; }
        public byte CurrentAbsence { get; set; }
        public String? Description { get; set; }
        public DateTime? ExamTime { get; set; }
        public Course Course { get; set; }

    }
}
