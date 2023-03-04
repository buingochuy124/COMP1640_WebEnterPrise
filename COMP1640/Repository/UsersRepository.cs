using COMP1640.Data;
using COMP1640.Models;
using COMP1640.Repository.IRepository;
using COMP1640.ViewModels;
using COMP1640.ViewModels.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Threading.Tasks;

namespace COMP1640.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUserModel> _userManager;
        public UsersRepository(ApplicationDbContext context, UserManager<AppUserModel> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

       
        public async Task<UserReponseManager> CreateUser(UserViewModel userViewModel)
        {
            PasswordHasher<AppUserModel> hasher = new PasswordHasher<AppUserModel>();
            var user = new AppUserModel()
            {
                UserName = userViewModel.UserName,
                NormalizedUserName = userViewModel.UserName.ToUpper(),
                Email = userViewModel.Email,
                NormalizedEmail = userViewModel.Email.ToUpper(),
                PasswordHash = hasher.HashPassword(null, userViewModel.Password),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                EmailConfirmed = true,
            };
            var a = await _userManager.CreateAsync(user, userViewModel.Password);

            try
            {

                var newUser = await _context.Users.SingleOrDefaultAsync(u => u.Email == user.Email);
                var b = AddRoleToUser(newUser,userViewModel.RolesName);
            }
            catch (Exception)
            {

                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Some thing wrong, try again ..."

                };
            }
            return new UserReponseManager
            {
                IsSuccess = true,
                Message = "Created ..."

            };
        }
        public async Task<IdentityResult> AddRoleToUser(AppUserModel user,string roleName)
        {
            var result  = await  _userManager.AddToRoleAsync(user, roleName);
            return result;
        }
        public async Task<AppUserModel> GetUser(string id)
        {
            
            var appUserModel = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            return appUserModel;
        }

        public async Task<List<AppUserModel>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserReponseManager> UpdateUser(AppUserModel model)
        {
            _context.Update(model);

            try
            {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Some thing wrong, try again ..."
                };
            }
            return new UserReponseManager
            {
                IsSuccess = true,
                Message = "Updated ..."
            };
        }
    }
}
