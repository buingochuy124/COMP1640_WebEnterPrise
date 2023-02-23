using COMP1640.ViewModels.Response;
using System.Threading.Tasks;

namespace COMP1640.Repository.IRepository
{
    public interface IPostRepository
    {
        public Task<UserReponseManager> CreatePost();
        
    }
}
