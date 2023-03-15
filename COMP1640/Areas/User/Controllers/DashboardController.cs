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
            int totalDepartmentCount = _context.Departments
            .Select(d => d.Name)
            .Distinct()
             .Count();
            int totalUserWithoutDepartmentCount = _context.Users
              .Where(u => u.Department == null)
             .Count();
            int totalIdeasWithoutCommentCount = _context.Posts
              .Select(d => d.Content)
            .Distinct()
            .Count();
            int totalAnonymousIdeaCount = _context.Posts
             .Where(p => p.IsAnonymous)
             .Count();

            int totalAnonymousCommentCount = _context.PostComments
               .Where(p => p.IsAnonymous)
               .Count();
            int totalCategoryCount = _context.Categories
          .Select(d => d.Name)
          .Distinct()
           .Count();
            int totalUserCount = _context.Users
            .Select(d => d.FirstName)
          .Distinct()
           .Count();

            ViewBag.TotalUserWithoutDepartmentCount = totalUserWithoutDepartmentCount;
            ViewBag.TotalPostCount = totalPostCount;
            ViewBag.TotalDepartmentCount = totalDepartmentCount;
            ViewBag.TotalAnonymousIdeaCount = totalAnonymousIdeaCount;
            ViewBag.TotalIdeasWithoutCommentCount = totalIdeasWithoutCommentCount;
            ViewBag.TotalAnonymousCommentCount = totalAnonymousCommentCount;
            ViewBag.TotalCategoryCount = totalCategoryCount;
            ViewBag.TotalUserCount = totalUserCount;
            return View(postCounts);

        }




    }
}
