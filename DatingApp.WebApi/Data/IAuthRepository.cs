using System.Threading.Tasks;
using DatingApp.WebApi.Models;
namespace DatingApp.WebApi.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string Password);

        Task<User> Login(string Username, string Password);

        Task<bool> UserExists(string Username);
    }
}