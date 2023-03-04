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
        public  async Task<IActionResult> Index()
         {
            var posts = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
             // .Include(p => p.PostComments)
             // .Include(p => p.PostInteracts)
                .ToListAsync();
            ViewBag.Anonymous = "Anonymous";

            ViewBag.ListCategoryName =  _context.Categories.Select(c => c.Name).ToList();
            var role = User.FindFirstValue(ClaimTypes.Role);
            var result = posts.OrderByDescending(p => p.Date).ToList();

            foreach (var item in result)
            {
                var comments = await _context.PostComments.Where(p => p.PostId == item.Id).ToListAsync();
                if(comments.Count != 0 )
                {
                    item.PostComments = new List<PostCommentModel>();
                    foreach (var comment in comments)
                    {
                        item.PostComments.Add(comment);
                    }
                }
            }

            return View(result);
        }

        public async Task<IActionResult> CreatePost([Bind("Content,Date,IsAnonymous,CategoryName")] PostModel postModel)
        {
            postModel.Date =  DateTime.Now;
            postModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            postModel.CategoryId = _context.Categories.FirstOrDefault(c => c.Name == postModel.CategoryName).Id;
            postModel.CategoryClosureDate = _context.Categories.FirstOrDefault(c => c.Id == postModel.CategoryId).ClosureDate;
            var category = _context.Categories.SingleOrDefault(c => c.Name == postModel.CategoryName);
            if (category.ClosureDate < DateTime.Now)
            {
                return Json(new UserReponseManager { Message = "This category has expired" });
            }
                if (ModelState.IsValid)
                {
                    _context.Add(postModel);
                    await _context.SaveChangesAsync();
                    return Json(new UserReponseManager { Message = "Posted" });
            }

            return Json(new UserReponseManager { Message = "Some thing wrong ..." });
        }
        public async Task<IActionResult> CreatePostComment([Bind("Content,Date,IsAnonymous,PostId")] PostCommentModel postCommentModel)
        {
            postCommentModel.Date = DateTime.Now;
            postCommentModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var post = _context.Posts.SingleOrDefault(p => p.Id == postCommentModel.PostId);
            var category = _context.Categories.SingleOrDefault(c => c.Name == post.CategoryName);
            if (category.FinalClosureDate < DateTime.Now)
            {
                return Json(new UserReponseManager { Message = "This post has expired" });
            }
                if (ModelState.IsValid)
                {
                    _context.Add(postCommentModel);
                    await _context.SaveChangesAsync();
                    return Json(new UserReponseManager { Message = "Commented" });
                }

            return Json(new UserReponseManager { Message = "Some thing wrong ..." });

        }

        private bool PostModelExists(string id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
    }
}
