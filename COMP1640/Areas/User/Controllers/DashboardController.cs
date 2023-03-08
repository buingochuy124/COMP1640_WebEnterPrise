using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP1640.Data;
using COMP1640.Models;
using System.Xml.Linq;
using System.Security.Claims;
using System.Net.WebSockets;
using COMP1640.ViewModels.Response;
using Microsoft.AspNetCore.Authorization;

namespace COMP1640.Areas.User.Controllers
{
    [Area("User")]
    [Authorize("RequireAdmin")]

    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var postCounts = _context.Posts
        .Include(p => p.User)
        .ThenInclude(u => u.Department)
             .Where(p => p.User.Department != null)

        .GroupBy(p => p.User.Department.Name)
        .Select(g => new { Department = g.Key, Count = g.Count() })
        .ToDictionary(x => x.Department, x => x.Count);






            int totalPostCount = _context.Posts.Count();
            int totalDepartmentCount = _context.Department
            .Select(d => d.Name)
            .Distinct()
             .Count();
            ViewBag.TotalPostCount = totalPostCount;
            ViewBag.TotalDepartmentCount = totalDepartmentCount;
            return View(postCounts);
        }




    }
}
