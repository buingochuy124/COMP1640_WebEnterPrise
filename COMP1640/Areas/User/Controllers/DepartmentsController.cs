using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP1640.Data;
using COMP1640.Models;
using Microsoft.AspNetCore.Authorization;
using COMP1640.ViewModels;

namespace COMP1640.Areas.User.Controllers
{
    [Area("User")]
    [Authorize("RequireCoordinator")]
    public class DepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User/Departments
        public async Task<IActionResult> Index()
        {
            var result = new List<DepartmentViewModel>();

            var departments = _context.Departments.ToList();

            foreach (var department in departments)
            {
                var cordinatorName = "";
              
                 var cordinator = await _context.Users.SingleOrDefaultAsync(c => c.Id == department.CordinatorId);
                    if(cordinator == null)
                    {
                        cordinator = new AppUserModel { FirstName = "N/A" };

                    }
                    cordinatorName = cordinator.FirstName; 

            
                
                result.Add(new DepartmentViewModel
                {
                    Id = department.Id,
                    Name = department.Name,
                    CordinatorId = department.CordinatorId,
                    CordinatorName = cordinatorName
                });
            }


            return View(result);
        }
        public async Task<IActionResult> Assign(string id)
        {
            var department = await _context.Departments.SingleOrDefaultAsync(d => d.Id == id);

            ViewBag.Users = _context.Users.ToList();   
            return View(department);
        }
        [HttpPost]
        public async Task<IActionResult> Assign([Bind("Id,Name,CordinatorId")] DepartmentModel departmentModel)
        {
            _context.Entry(departmentModel).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
         

           
            return RedirectToAction(nameof(Index));
        }
        // GET: User/Departments/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentModel = await _context.Departments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departmentModel == null)
            {
                return NotFound();
            }

            return View(departmentModel);
        }

        // GET: User/Departments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CordinatorId")] DepartmentModel departmentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departmentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departmentModel);
        }

        // GET: User/Departments/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentModel = await _context.Departments.FindAsync(id);
            if (departmentModel == null)
            {
                return NotFound();
            }
            return View(departmentModel);
        }

        // POST: User/Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,CordinatorId")] DepartmentModel departmentModel)
        {
            if (id != departmentModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departmentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentModelExists(departmentModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(departmentModel);
        }

        // GET: User/Departments/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentModel = await _context.Departments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departmentModel == null)
            {
                return NotFound();
            }

            return View(departmentModel);
        }

        // POST: User/Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var departmentModel = await _context.Departments.FindAsync(id);
            _context.Departments.Remove(departmentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentModelExists(string id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
