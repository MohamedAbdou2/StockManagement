using Microsoft.AspNetCore.Mvc;
using StockManagement.Interfaces;
using StockManagement.Models;
using StockManagement.ViewModels;

namespace StockManagement.Controllers
{
    public class StoreController : Controller
    {
        private readonly IGenericRepository<Store> _storeRepository;

        public StoreController(IGenericRepository<Store> storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public IActionResult Index()
        {
            var stores = _storeRepository.GetAll();
            return View(stores);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StoreViewModel storeViewModel)
        {
            if (ModelState.IsValid)
            {
                var store = new Store
                {
                    Name = storeViewModel.Name,
                    Address = storeViewModel.Address,
                };

                _storeRepository.Add(store);
                return RedirectToAction("Index");

            }

            return View(storeViewModel);

        }

        public IActionResult Edit(int id)
        {
            var store = _storeRepository.GetById(id);
            if (store == null)
            {
                return NotFound();
            }

            var viewModel = new StoreViewModel
            {
                Id = store.Id,
                Name = store.Name,
                Address = store.Address,
            };

            return View(viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, StoreViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var store = _storeRepository.GetById(id);
                if (store == null)
                {
                    return NotFound();
                }

                store.Name = viewModel.Name;
                store.Address = viewModel.Address;
                _storeRepository.Update(store);
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            var store = _storeRepository.GetById(id);
            if (store == null) { return NotFound(); }
            _storeRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
