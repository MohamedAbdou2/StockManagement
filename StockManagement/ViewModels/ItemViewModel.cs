using System.ComponentModel.DataAnnotations;

namespace StockManagement.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }


    }
}
