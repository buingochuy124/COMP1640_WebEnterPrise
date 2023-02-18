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
                    message = "Some thing wrong, try again ..."
                };
            }
            return new UserReponseManager
            {
                IsSuccess = true,
                message = "Created ..."
            };
        }

        public async Task<UserReponseManager> DisableCategory(string id)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
            category.Is
            _context.Entry(category).State = EntityState.Modified;



        }

        public async Task<List<CategoryModel>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public Task<UserReponseManager> UpdateCategory(CategoriesViewModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
