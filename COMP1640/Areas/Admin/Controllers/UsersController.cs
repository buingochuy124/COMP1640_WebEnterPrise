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
using COMP1640.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using COMP1640.ViewModels;

namespace COMP1640.Areas.Admin.Controllers
{
    [Area("Admin")]

     public class UsersController : Controller
    {
        private readonly IUsersRepository _usersRepository;
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context,IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
            _context= context;
        }

        // GET: Admin/Users
        public async Task<IActionResult> Index()
        {
            List<AppUserModel> result = await _usersRepository.GetUsers();
            return View(result);
        }

        // GET: Admin/Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            var result = await _usersRepository.GetUser(id);

            return View(result);
           
        }

        // GET: Admin/Users/Create
        public  IActionResult Create()
        {
            var roles = _context.Roles.ToList();
            var rolesName = roles.Select(r => r.Name).ToList();
            ViewBag.RolesName = rolesName;

            return View();
        }

        // POST: Admin/Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Address,FirstName,LastName,UserName,Email,Password,PhoneNumber,RolesName")] UserViewModel userViewModel)
        {
            var result = await _usersRepository.CreateUser(userViewModel);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: Admin/Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _usersRepository.GetUser(id);
            return View(user);

        }

        // POST: Admin/Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Address,FirstName,LastName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUserModel appUserModel)
        {
            var result = await _usersRepository.UpdateUser(appUserModel);   
            return View(appUserModel);
        }



      
    }
}
