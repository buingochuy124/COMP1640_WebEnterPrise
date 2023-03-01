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
            var password = userViewModel.Password;
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
            _context.Add(user);
            try
            {
               await  _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Some thing wrong, try again ..."

                };       
            }

            await  _userManager.AddToRoleAsync(user,userViewModel.RolesName);
            return new UserReponseManager
            {
                IsSuccess = true,
                Message = "Created ..."

            };
        }

        public async Task<AppUserModel> GetUser(string id)
        {
            
            var appUserModel = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            return appUserModel;
        }

        public async Task<List<AppUserModel>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;        
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
