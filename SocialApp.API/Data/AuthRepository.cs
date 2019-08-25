using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;

        }
        public Task<User> Login(string UserName, string Password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<User> Register(string UserName, string Password)
        {
            byte[] passwordHash,passwordSalt;
            using(var hmac=new System.Security.Cryptography.HMACSHA512()){
                passwordSalt=hmac.Key;
                passwordHash=hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));
            }
            User objUser=new User(){
                UserName=UserName,
                PasswordSalt=passwordSalt,
                PasswordHash=passwordHash
            };
            await _context.Users.AddAsync(objUser);
            await _context.SaveChangesAsync();
            
            return await _context.Users.FirstOrDefaultAsync(x=>x.UserName==objUser.UserName); 
        }

        public Task<bool> UserExists(string UserName)
        {
            throw new System.NotImplementedException();
        }
    }
}