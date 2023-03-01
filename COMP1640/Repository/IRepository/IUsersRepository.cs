using COMP1640.Models;
using COMP1640.ViewModels.Response;
using COMP1640.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace COMP1640.Repository.IRepository
{
    public interface IUsersRepository
    {
        public Task<List<AppUserModel>> GetUsers();
        public Task<AppUserModel> GetUser(string id);

        public Task<UserReponseManager> CreateUser(UserViewModel userViewModel);
        public Task<UserReponseManager> UpdateUser(AppUserModel model);
    }
}
