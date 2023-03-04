using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP1640.Data;
using COMP1640.Models;
using COMP1640.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using COMP1640.ViewModels;

namespace COMP1640.Areas.User.Controllers
{
    [Area("User")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        // GET: User/Categorys
        public async Task<IActionResult> Index()
        {
            return View(await _categoriesRepository.GetCategories());
        }

        // GET: User/Categorys/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModel = await _categoriesRepository.GetCategory(id);
            if (categoryModel == null)
            {
                return NotFound();
            }

            return View(categoryModel);
        }

        // GET: User/Categorys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Categorys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FinalClosureDate")] CategoriesViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                await _categoriesRepository.CreateCategory(categoryViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(categoryViewModel);
        }

        // GET: User/Categorys/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoryModel = await _categoriesRepository.GetCategory(id);
            if (categoryModel == null)
            {
                return NotFound();
            }
            return View(new CategoriesViewModel
            {
                Id = categoryModel.Id,
                Name = categoryModel.Name,
                IsActive = categoryModel.IsActive,
                FinalClosureDate = categoryModel.FinalClosureDate,
            });
        }

        // POST: User/Categorys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,FinalClosureDate")] CategoriesViewModel categoryViewModel)
        {
            if (id != categoryViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                await  _categoriesRepository.UpdateCategory(categoryViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(categoryViewModel);
        }

        // GET: User/Categorys/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryModel = await _categoriesRepository.GetCategory(id);
            if (categoryModel == null)
            {
                return NotFound();
            }

            return View(categoryModel);
        }

        // POST: User/Categorys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _categoriesRepository.DeleteCategory(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
