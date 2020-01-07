using System.Threading.Tasks;
using MaHY.API.Models;

namespace MaHY.API.Data
{
    public interface IAuthRepository
    {
        Task<bool> SaveAll();    
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
        Task<User> GetUserById(int id);



    }
}