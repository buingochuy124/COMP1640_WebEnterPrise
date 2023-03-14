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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.IO.Compression;
using COMP1640.Repository.IRepository;
using static System.Net.WebRequestMethods;
using Microsoft.AspNetCore.Identity.UI.Services;
using COMP1640.Repository;

using COMP1640.Repository;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using Org.BouncyCastle.Asn1.X509;
using Microsoft.Extensions.Hosting;

namespace COMP1640.Areas.User.Controllers
{
    [Area("User")]
    [Authorize("RequireStaff")]

    public class PostsController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        private readonly ApplicationDbContext _context;
        private readonly IPostRepository _postRepository;
        private readonly IEmailSender _emailSender;
        private readonly ISendEmail _sendEmail;
        
        public PostsController(ApplicationDbContext context, IPostRepository postRepository, IUsersRepository usersRepository, IEmailSender emailSender,
            ISendEmail sendEmail)
        {
            _usersRepository = usersRepository;
            _context = context;
            _postRepository = postRepository; 
            _emailSender = emailSender;
            _sendEmail = sendEmail;
            _usersRepository = usersRepository;

        }

        // GET: User/Posts
        public async Task<IActionResult> Index(int currentPage)
        {

            var posts = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                // .Include(p => p.PostComments)
                // .Include(p => p.PostInteracts)
                // .Include(p => p.PostInteracts)
                .ToListAsync();



            ViewBag.NotApprovedPosts = posts.Where(p => p.IsApproved == false).ToList();
            posts = posts.Where(p => p.IsApproved == true).ToList();
            ViewBag.Anonymous = "Anonymous";
            ViewBag.ListCategoryName = _context.Categories.Select(c => c.Name).ToList();
            var role = User.FindFirstValue(ClaimTypes.Role);
            var result = new List<PostModel>();
            
            result = posts.OrderByDescending(p => p.Date).ToList();

            foreach (var item in result)
            {
                var comments = await _context.PostComments.Where(p => p.PostId == item.Id).ToListAsync();
                if (comments.Count != 0)
                {
                    item.PostComments = new List<PostCommentModel>();
                    foreach (var comment in comments)
                    {
                        item.PostComments.Add(comment);
                    }
                }
            }
            if (currentPage.ToString() == null || currentPage <= 0)
            {
                currentPage = 1;
            }

            ViewBag.CurrentPage = currentPage;
            ViewBag.PostsQuantity = result.Count;
            ViewBag.PostsPerPage = 5;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var postInteract =  _context.PostInteracts.Where(p => p.UserId == userId).ToList();

            ViewBag.PostInteract = postInteract;
            //var postInteract = await _context.PostInteracts.FirstOrDefaultAsync(pi => pi.PostId == post.Id && pi.UserId == userId);

            result = result.Skip((currentPage - 1) * 5).Take(5).ToList();
            return View(result);
          
        }

        public async Task<IActionResult> SortByComment()
        {
            var posts = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                .Include(p => p.PostComments)
                .Include(p => p.PostInteracts)
                .ToListAsync();
            posts = posts.Where(p => p.IsApproved == true).ToList();
            ViewBag.Anonymous = "Anonymous";
            ViewBag.ListCategoryName = _context.Categories.Select(c => c.Name).ToList();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var postInteract = _context.PostInteracts.Where(p => p.UserId == userId).ToList();

            ViewBag.PostInteract = postInteract;

            var result = await _context.Posts.Include(p => p.PostComments).OrderByDescending(p => p.PostComments.Max(c => c.Date)).ToListAsync();
            return View(result);
        }


        public async Task<IActionResult> ApprovePosts()
        {
            var posts = await _context.Posts
               .Include(p => p.Category)
               .Include(p => p.User)
               .Where(p => p.IsApproved == false)
               // .Include(p => p.PostComments)
               // .Include(p => p.PostInteracts)
               .ToListAsync();

            var result = posts.OrderByDescending(p => p.Date).ToList();
            return View(result);

        }

        public async Task<IActionResult> ApprovedPost(string id)
        {
            var post = await _context.Posts.SingleOrDefaultAsync(p => p.Id == id);
            post.IsApproved = true;
            _context.Entry(post).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToAction("ApprovePosts", "Posts", new { area = "User" });
        }

        public async Task<IActionResult> RemovePost(string id)
        {

            var post = await _context.Posts.SingleOrDefaultAsync(p => p.Id == id);
            post.IsApproved = true;
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return RedirectToAction("ApprovePosts", "Posts", new { area = "User" });
        }
        public IActionResult UploadCsvFile(IFormFile file, [FromServices] IWebHostEnvironment webHostEnvironment, string categoryName)
        {

            var UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (file == null)
            {
                return RedirectToAction(nameof(Index));
            }



            var fileName = $"{webHostEnvironment.WebRootPath}\\Documents\\{categoryName}_{UserId}.csv";
            using (FileStream filestream = System.IO.File.Create(fileName))
            {
                file.CopyTo(filestream);
                filestream.Flush();
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DownloadFilesInZip([FromServices] IWebHostEnvironment webHostEnvironment, string categoryId)
        {
            string rootFolder = $"{webHostEnvironment.WebRootPath}\\Documents";
            var categoryName = _context.Categories.SingleOrDefault(c => c.Id == categoryId).Name;
            var files = Directory.GetFiles(rootFolder).Where(f => Path.GetFileName(f).Contains(categoryName));
            var memoryStream = new MemoryStream();


            var categoryData = _postRepository.GetCategoryData(categoryId);
            string categoryDataFileName = "CategoryData.csv";

            using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
            {
                foreach (var file in files)
                {
                    var fileName = Path.GetFileName(file);
                    var zipEntry = archive.CreateEntry(fileName, CompressionLevel.Fastest);

                    using (var fileStream = new FileStream(file, FileMode.Open))
                    using (var zipStream = zipEntry.Open())
                    {
                        fileStream.CopyTo(zipStream);
                    }
                }
                ZipArchiveEntry entry = archive.CreateEntry(categoryDataFileName);

                using (Stream stream = entry.Open())
                {
                    // Write the byte array to the stream
                    stream.Write(categoryData, 0, categoryData.Length);
                }
            }

            var contentType = "application/zip";
            var zipFileName = $"{categoryName}Document.zip";
            Response.Headers.Add("Content-Disposition", $"attachment; filename=\"{zipFileName}\"");
            return File(memoryStream.ToArray(), contentType, zipFileName);
        }


        public async Task<IActionResult> CreatePost([Bind("Content,Date,IsAnonymous,CategoryName")] PostModel postModel)
        {
            postModel.Date = DateTime.Now;
            postModel.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            postModel.CategoryId = _context.Categories.FirstOrDefault(c => c.Name == postModel.CategoryName).Id;
            postModel.CategoryClosureDate = _context.Categories.FirstOrDefault(c => c.Id == postModel.CategoryId).ClosureDate;
            List<AppUserModel> result = await _usersRepository.GetUsers();
           
            var category = _context.Categories.SingleOrDefault(c => c.Name == postModel.CategoryName);
            if (category.ClosureDate < DateTime.Now)
            {
                return Json(new UserReponseManager { Message = "This category has expired" });
            }

                if (ModelState.IsValid)
                {
                    _context.Add(postModel);
                foreach (var user in result)
                {
                    if (user.Id == "202")
                    {
                        var subject = "New post submitted";
                        var message = $"Dear {user.UserName},\n\nA new post has been submitted. Please check it out.\n\nThank you.";
                        _sendEmail.SendEMail(user.Email, subject, message);
                       
                    }
                    else if (user.Id == "203")
                    {
                        var subject = "New post submitted";
                        var message = $"Dear {user.UserName},\n\nA new post has been submitted. Please check it out.\n\nThank you.";
                        _sendEmail.SendEMail(user.Email, subject, message);
                        
                    }
                }
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
            List<AppUserModel> result = await _usersRepository.GetUsers();
            var postUser = result.FirstOrDefault(u => u.Id == post.UserId);
          
            
            var category = _context.Categories.SingleOrDefault(c => c.Name == post.CategoryName);
            if (category.FinalClosureDate < DateTime.Now)
            {
                return Json(new UserReponseManager { Message = "This post has expired" });
            }

                if (ModelState.IsValid)
                {
                    _context.Add(postCommentModel);
                    var subject = "New comment on your post";
                    var message = $"Dear {postUser.UserName},\n\nA new comment has been added to your post. Please check it out.\n\nThank you.";
                     _sendEmail.SendEMail(postUser.Email, subject, message);
                    await _context.SaveChangesAsync();
                   
                return Json(new UserReponseManager { Message = "Commented" });
                }

            var existingComment = await _context.PostComments.FirstOrDefaultAsync(c => c.PostId == postCommentModel.PostId && c.UserId == postCommentModel.UserId);

            if (existingComment != null)
            {
                return Json(new UserReponseManager { Message = "You have already commented on this post" });
            }
            if (ModelState.IsValid)
            {
                _context.Add(postCommentModel);
                await _context.SaveChangesAsync();
                return Json(new UserReponseManager { Message = "Commented" });
            }


            return Json(new UserReponseManager { Message = "Some thing wrong ..." });

        }

        public async Task<IActionResult> SortByRate()
        {
            var posts = await _context.Posts
                .Include(p => p.Category)
                .Include(p => p.User)
                .Include(p => p.PostComments)
                .Include(p => p.PostInteracts)
                .ToListAsync();
            posts = posts.Where(p => p.IsApproved == true).ToList();
            ViewBag.Anonymous = "Anonymous";
            ViewBag.ListCategoryName = _context.Categories.Select(c => c.Name).ToList();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var postInteract = _context.PostInteracts.Where(p => p.UserId == userId).ToList();

            ViewBag.PostInteract = postInteract;
            ViewBag.PostInteract = postInteract;

            var result = await _context.Posts.Include(p => p.PostInteracts).OrderByDescending(p => p.PostInteracts.Count).ToListAsync();
            return View(result);
        }

        public async Task<IActionResult> Like(string postId)
        {
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
            {
                return NotFound();
            }

            // Update the post interact model
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var postInteract = await _context.PostInteracts
                .FirstOrDefaultAsync(pi => pi.PostId == post.Id && pi.UserId == userId);

            if (postInteract == null)
            {
                postInteract = new PostInteractModel
                {
                    PostId = post.Id,
                    IsAnonymous = false,
                    IsInteracted = true,
                    UserId = userId,
                    IsLike = true,

                };

                _context.PostInteracts.Add(postInteract);
            }
            else if (postInteract.IsLike == false && postInteract.IsInteracted == false) // user already disliked the post
            {
                postInteract.IsLike = true;
                postInteract.IsInteracted = true;
                _context.PostInteracts.Update(postInteract);
              
            }
            else // user already liked or interacted with the post
            {
                return Json(new UserReponseManager { Message = "You have already interacted..." });
            }
            ViewBag.PostInteract = postInteract;
            await _context.SaveChangesAsync();
            return Json(new UserReponseManager { Message = "Liked" });
            return Ok(new { postId });
        }


        public async Task<IActionResult> disLike(string postId)
        {
            var post = await _context.Posts.FindAsync(postId);

            if (post == null)
            {
                return NotFound();
            }

            // Update the post interact model
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var postInteract = await _context.PostInteracts
                .FirstOrDefaultAsync(pi => pi.PostId == post.Id && pi.UserId == userId);

            if (postInteract == null)
            {
                postInteract = new PostInteractModel
                {
                    PostId = post.Id,
                    IsAnonymous = false,
                    IsInteracted = true,
                    UserId = userId,
                    IsLike = false
                };

                _context.PostInteracts.Add(postInteract);
            }
            else if (postInteract.IsLike == true && postInteract.IsInteracted == false) // user already liked the post
            {
                postInteract.IsLike = false;
                postInteract.IsInteracted = true;
                _context.PostInteracts.Update(postInteract);
               
            }
            else // user already disliked or interacted with the post
            {
                return Json(new UserReponseManager { Message = "You have already interacted..." });
            }

            await _context.SaveChangesAsync();
            return Json(new UserReponseManager { Message = "DisLiked" });
            return Ok(new { postId });
        }
    }

    }
