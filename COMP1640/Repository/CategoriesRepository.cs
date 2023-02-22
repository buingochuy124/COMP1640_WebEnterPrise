using COMP1640.Data;
using COMP1640.Models;
using COMP1640.Repository.IRepository;
using COMP1640.ViewModels;
using COMP1640.ViewModels.Response;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace COMP1640.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoriesRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<UserReponseManager> CreateCategory(CategoriesViewModel model)
        {
            var newCategory = new CategoryModel
            {
                Id = model.Id,
                Name = model.Name
            };
            await _context.Categories.AddAsync(newCategory);
            try
            {
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                return new UserReponseManager
                {
                    IsSuccess= false,
                    Message = "Some thing wrong, try again ..."
                };
            }
            return new UserReponseManager
            {
                IsSuccess = true,
                Message = "Created ..."
            };
        }

        public async Task<UserReponseManager> DeleteCategory(string id)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);

            if(category == null)
            {
                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Category Not Found ..."
                };
            }
            _context.Remove(category);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Deleted Fail, Some thing wrong ..."
                };
            }
            return new UserReponseManager
            {
                IsSuccess = true,
                Message = "Deleted Category ..."
            };
        }

        public async Task<UserReponseManager> DisableCategory(string id)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
            category.IsActive﻿ = false;
            _context.Entry(category).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Disable Fail, Some thing wrong ..."
                };

            }
            return new UserReponseManager
            {
                IsSuccess = true,
                Message = "Disabled ..."
            };

        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public async Task<CategoryModel> GetCategory(string id)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<UserReponseManager> UpdateCategory(CategoriesViewModel model)
        {

            var newCategory = new CategoryModel
            {
                Id = model.Id,
                Name = model.Name,
                IsActive = model.IsActive,
            };
            _context.Entry(newCategory).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                return new UserReponseManager
                {
                    IsSuccess = false,
                    Message = "Disable Fail, Some thing wrong ..."
                };

            }
            return new UserReponseManager
            {
                IsSuccess = true,
                Message = "Disabled ..."
            };
        }
    }
}
