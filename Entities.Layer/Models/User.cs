using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class User :IdentityUser<int>
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
