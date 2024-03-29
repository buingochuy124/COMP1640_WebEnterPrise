﻿using System;
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
    [Authorize("RequireAdmin")]
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
        public async Task<IActionResult> AssignToDepartment(string id)
        {
            var result = await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
            ViewBag.Departments = _context.Departments.ToList();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> AssignToDepartment([Bind("Id,DepartmentId")] UserViewModel userViewModel)
        {

            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == userViewModel.Id);
            user.DepartmentId = userViewModel.DepartmentId;
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

        // GET: Admin/Users/Create
        public  IActionResult Create()
        {
           

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
            var roles = _context.Roles.ToList();
            var rolesName = roles.Select(r => r.Name).ToList();
            ViewBag.RolesName = rolesName;
            
            return View(new UserViewModel
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
            });

        }

        // POST: Admin/Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Address,FirstName,LastName,UserName,Email,Password,PhoneNumber,RolesName")] UserViewModel userViewModel)
        {
            var result = await _usersRepository.UpdateUser(userViewModel, userViewModel.RolesName);
            return RedirectToAction(nameof(Index));
        }
    }
}
