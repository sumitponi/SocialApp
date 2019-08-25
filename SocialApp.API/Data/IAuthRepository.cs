using System.Threading.Tasks;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(string UserName,string Password);

        Task<User> Login(string UserName,string Password);

        Task<bool> UserExists(string UserName);
    }
}