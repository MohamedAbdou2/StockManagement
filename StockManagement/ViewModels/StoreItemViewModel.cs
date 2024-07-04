using Microsoft.AspNetCore.Mvc.Rendering;

namespace StockManagement.ViewModels
{
    public class StoreItemViewModel
    {
        public List<SelectListItem>? Stores { get; set; }
        public List<SelectListItem>? Items { get; set; }
        public int Quantity { get; set; }

        public string SelectedStoreId { get; set; }
        public string SelectedItemId { get; set; }
    }
}
