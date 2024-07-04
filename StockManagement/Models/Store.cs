using System.ComponentModel.DataAnnotations;

namespace StockManagement.Models
{
    public class Store
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        public virtual ICollection<StoreItem> StoreItems { get; set; } = new HashSet<StoreItem>();

    }
}
