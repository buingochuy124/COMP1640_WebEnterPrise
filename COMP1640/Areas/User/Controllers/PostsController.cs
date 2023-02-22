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

namespace COMP1640.Areas.User.Controllers
{
    [Area("User")]
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User/Posts
        public async Task<IActionResult> Index()
         {
            var posts = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                .ToListAsync();
            ViewBag.Anonymous = "Anonymous";

            var role = User.FindFirstValue(ClaimTypes.Role);
           
            return View(posts);
        }

        // GET: User/Posts/Create
        public IActionResult Create()
        {
            ViewData["CategoryName"] = new SelectList(_context.Categories, "Name", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,Date,IsAnonymous,CategoryName")] PostModel postModel)
        {
            postModel.Date =  DateTime.Now;
            postModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            postModel.CategoryId = _context.Categories.FirstOrDefault(C => C.Name == postModel.CategoryName).Id;
            if (ModelState.IsValid)
            {
                _context.Add(postModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(postModel);
        }


        private bool PostModelExists(string id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
