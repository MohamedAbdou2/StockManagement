using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagement.Models
{
    public class StoreItem
    {
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }

        public int Quantity { get; set; }
    }
}
