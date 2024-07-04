using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockManagement.Interfaces;
using StockManagement.ViewModels;

namespace StockManagement.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IStoreItemRepository _storeItemRepository;

        public PurchaseController(IStoreRepository storeRepository, IItemRepository itemRepository, IStoreItemRepository storeItemRepository)
        {
            _storeRepository = storeRepository;
            _itemRepository = itemRepository;
            _storeItemRepository = storeItemRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new StoreItemViewModel
            {
                Stores = _storeRepository.GetAll().Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name }).ToList(),
                Items = _itemRepository.GetAll().Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name }).ToList()
            };
            return View("Purchase", viewModel);
        }

        [HttpGet]
        public JsonResult GetQuantity(int storeId, int itemId)
        {
            var storeItem = _storeItemRepository.GetAll().SingleOrDefault(si => si.StoreId == storeId && si.ItemId == itemId);
            if (storeItem != null)
            {
                return Json(new { success = true, quantity = storeItem.Quantity });
            }
            return Json(new { success = false, message = "Item not found" });
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int storeId, int itemId, int quantity)
        {
            var storeItem = _storeItemRepository.GetAll().SingleOrDefault(si => si.StoreId == storeId && si.ItemId == itemId);
            if (storeItem != null)
            {
                storeItem.Quantity += quantity;
                _storeItemRepository.Update(storeItem);
                return Json(new { success = true, newQuantity = storeItem.Quantity });
            }
            return Json(new { success = false, message = "Item not found" });
        }
    }
}
