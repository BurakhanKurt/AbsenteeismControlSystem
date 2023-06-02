using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Layer.Models
{
    public class User :IdentityUser<int>
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<CourseProgram> CoursePrograms { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
