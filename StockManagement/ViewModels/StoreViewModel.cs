using System.ComponentModel.DataAnnotations;

namespace StockManagement.ViewModels
{
    public class StoreViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

    }
}
