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
             _context.Users.Add(user);

            try
            {
                await _context.SaveChangesAsync();
                 
            }
            catch (Exception)
            {

                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Some thing wrong, try again ..."

                };
            }
            await AddRoleToUser(user, Utils.Role.Staff);

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

        public async Task<UserReponseManager> UpdateUser(UserViewModel model, string roleName)
        {
           

            
                // Get the user from the database
                var user = await _context.Users.SingleOrDefaultAsync(u =>u.Email==model.Email);

                if (user == null)
                {
                    return new UserReponseManager
                    {
                        IsSuccess = false,
                        Message = "User not found."
                    };
                }

                // Update the user properties
                user.Address = model.Address;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.PhoneNumber = model.PhoneNumber;

                // Update the user role
                var roles = await _userManager.GetRolesAsync(user);
                var result = await _userManager.RemoveFromRolesAsync(user, roles);
                if (!result.Succeeded)
                {
                    return new UserReponseManager
                    {
                        IsSuccess = false,
                        Message = "Failed to remove user from roles."
                    };
                }

                result = await _userManager.AddToRoleAsync(user, roleName);
                if (!result.Succeeded)
                {
                    return new UserReponseManager
                    {
                        IsSuccess = false,
                        Message = "Failed to add user to role."
                    };
                }

                // Save changes to the database
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return new UserReponseManager
                    {
                        IsSuccess = false,
                        Message = "Failed to update user."
                    };
                }

                return new UserReponseManager
                {
                    IsSuccess = true,
                    Message = "User updated successfully."
                };
            

        }

    }
}
