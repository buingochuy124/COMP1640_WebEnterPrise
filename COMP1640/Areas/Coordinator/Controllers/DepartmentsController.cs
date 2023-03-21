using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP1640.Data;
using COMP1640.Models;
using COMP1640.ViewModels;
using System.Linq.Expressions;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace COMP1640.Areas.Coordinator.Controllers
{
    [Area("Coordinator")]
    [Authorize("RequireCoordinator")]
    public class DepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Coordinator/Departments
        public async Task<IActionResult> Index()
        {
            var userIdLoggedIn = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var users = await _context.Users.Include(u => u.Department).ToListAsync();
            var result = new List<CoordinatorDepartmentViewModel>();
            foreach (var user in users)
            {
                var postContribute = _context.Posts
                    .Include(p => p.User)
                    .Where(u => u.User.DepartmentId == user.DepartmentId)
                    .Where(p => p.IsApproved == true)
                    .Where(p => p.UserId == user.Id)
                    .Count();

                var departmentName = _context.Departments.SingleOrDefault(d => d.Id == user.DepartmentId).Name;
                result.Add(new CoordinatorDepartmentViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber, 
                    DepartmentName = departmentName,
                    DepartmentId = user.DepartmentId,
                    PostContribute = postContribute,
                });
            }
            


            return View(result);

        }

        // GET: Coordinator/Departments/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUserModel = await _context.Users
                .Include(a => a.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUserModel == null)
            {
                return NotFound();
            }

            return View(appUserModel);
        }

        // GET: Coordinator/Departments/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Id");
            return View();
        }

        // POST: Coordinator/Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Address,FirstName,LastName,DepartmentId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUserModel appUserModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appUserModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Id", appUserModel.DepartmentId);
            return View(appUserModel);
        }

        // GET: Coordinator/Departments/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUserModel = await _context.Users.FindAsync(id);
            if (appUserModel == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Id", appUserModel.DepartmentId);
            return View(appUserModel);
        }

        // POST: Coordinator/Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Address,FirstName,LastName,DepartmentId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUserModel appUserModel)
        {
            if (id != appUserModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appUserModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppUserModelExists(appUserModel.Id))
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Id", appUserModel.DepartmentId);
            return View(appUserModel);
        }

        // GET: Coordinator/Departments/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUserModel = await _context.Users
                .Include(a => a.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUserModel == null)
            {
                return NotFound();
            }

            return View(appUserModel);
        }

        // POST: Coordinator/Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var appUserModel = await _context.Users.FindAsync(id);
            _context.Users.Remove(appUserModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserModelExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
