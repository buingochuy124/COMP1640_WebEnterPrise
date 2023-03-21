using COMP1640.Models;
using COMP1640.ViewModels;
using COMP1640.ViewModels.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace COMP1640.Repository.IRepository
{
    public interface ICategoriesRepository
    {
        public Task<List<CategoryModel>> GetCategories();
        public Task<CategoryModel> GetCategory(string id);
        
        public Task<UserReponseManager> CreateCategory(CategoriesViewModel model);
        public Task<UserReponseManager> UpdateCategory(CategoriesViewModel model);
        public Task<UserReponseManager> DisableCategory(string id);
        public Task<UserReponseManager> DeleteCategory(string id);

    }
}
