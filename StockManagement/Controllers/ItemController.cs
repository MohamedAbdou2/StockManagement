using Microsoft.AspNetCore.Mvc;
using StockManagement.Interfaces;
using StockManagement.Models;
using StockManagement.ViewModels;

namespace StockManagement.Controllers
{
    public class ItemController : Controller
    {
        private readonly IGenericRepository<Item> _itemRepository;

        public ItemController(IGenericRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public IActionResult Index()
        {
            var stores = _itemRepository.GetAll();
            return View(stores);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemViewModel itemViewModel)
        {
            if (ModelState.IsValid)
            {
                var store = new Item
                {
                    Name = itemViewModel.Name,
                    Price = itemViewModel.Price,
                    Description = itemViewModel.Description,

                };

                _itemRepository.Add(store);
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
