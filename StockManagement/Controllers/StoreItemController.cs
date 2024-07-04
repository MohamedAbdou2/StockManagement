using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockManagement.Interfaces;
using StockManagement.Models;
using StockManagement.ViewModels;

namespace StockManagement.Controllers
{
    public class StoreItemController : Controller
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IItemRepository _itemRepository;
        private readonly IStoreItemRepository _storeItemRepository;

        public StoreItemController(IStoreRepository storeRepository, IItemRepository itemRepository, IStoreItemRepository storeItemRepository)
        {
            _storeRepository = storeRepository;
            _itemRepository = itemRepository;
            _storeItemRepository = storeItemRepository;
        }

        // List action to display all store items
        public IActionResult Index()
        {
            var storeItems = _storeItemRepository.GetAll();
            return View(storeItems);
        }

        // Add action (HttpGet) to display the form for adding a new store item
        public IActionResult Add()
        {
            var viewModel = new StoreItemViewModel
            {
                Stores = _storeRepository.GetAll()
                                          .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name })
                                          .ToList(),
                Items = _itemRepository.GetAll()
                                       .Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name })
                                       .ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(StoreItemViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var storeId = int.Parse(viewModel.SelectedStoreId);
                var itemId = int.Parse(viewModel.SelectedItemId);

                var existingStoreItem = _storeItemRepository.GetAll()
                    .FirstOrDefault(si => si.StoreId == storeId && si.ItemId == itemId);

                if (existingStoreItem == null)
                {
                    var storeItem = new StoreItem
                    {
                        StoreId = storeId,
                        ItemId = itemId,
                        Quantity = viewModel.Quantity
                    };

                    _storeItemRepository.Add(storeItem);
                }
                else
                {

                    existingStoreItem.Quantity += viewModel.Quantity;
                    _storeItemRepository.Update(existingStoreItem);
                }

                return RedirectToAction(nameof(Index));
            }

            viewModel.Stores = _storeRepository.GetAll()
                                               .Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name })
                                               .ToList();
            viewModel.Items = _itemRepository.GetAll()
                                             .Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Name })
                                             .ToList();
            return View(viewModel);
        }
    }
}
