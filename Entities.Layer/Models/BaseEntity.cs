
namespace Entities.Models
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? HardDeletedDate { get; set; }
        public bool isActive { get; set; } 
        public bool isDeleted { get; set; } 
    }
}
