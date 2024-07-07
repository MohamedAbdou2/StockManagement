using Microsoft.AspNetCore.Mvc;
using StockManagement.Interfaces;
using StockManagement.Models;
using StockManagement.ViewModels;

namespace StockManagement.Controllers
{
    public class ItemController : Controller
    {
        private readonly IGenericRepository<Item> _itemRepository;
        private readonly IGenericRepository<StoreItem> _storitemRepository;
        private readonly IGenericRepository<Store> _storeRepository;

        public ItemController(IGenericRepository<Item> itemRepository, IGenericRepository<StoreItem> storitemRepository, IGenericRepository<Store> storeRepository)
        {
            _itemRepository = itemRepository;
            _storitemRepository = storitemRepository;
            _storeRepository = storeRepository;
        }
        public IActionResult Index()
        {
            var items = _itemRepository.GetAll();
            return View(items);
        }
        public IActionResult Create()
        {
            var item = new ItemViewModel
            {
                Stores = _storeRepository.GetAll(),
            };
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemViewModel itemViewModel)
        {
            if (ModelState.IsValid)
            {
                var item = new Item
                {
                    Name = itemViewModel.Name,
                    Price = itemViewModel.Price,
                    Description = itemViewModel.Description,

                };
                _itemRepository.Add(item);

                var storeItem = new StoreItem
                {
                    ItemId = item.Id,
                    StoreId = itemViewModel.SelectedStoreId,
                    Quantity = itemViewModel.Quantity,
                };


                _storitemRepository.Add(storeItem);

                return RedirectToAction("Index");

            }

            return View(itemViewModel);

        }

        public IActionResult Edit(int id)
        {
            var item = _itemRepository.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            var viewModel = new ItemViewModel
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                Description = item.Description,

            };

            return View(viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ItemViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var item = _itemRepository.GetById(id);
                if (item == null)
                {
                    return NotFound();
                }

                item.Name = viewModel.Name;
                item.Price = viewModel.Price;
                item.Description = viewModel.Description;
                _itemRepository.Update(item);
                return RedirectToAction(nameof(Index));
            }
            viewModel.Stores = _storeRepository.GetAll();
            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            var item = _itemRepository.GetById(id);
            if (item == null) { return NotFound(); }
            _itemRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
