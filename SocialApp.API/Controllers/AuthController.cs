using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialApp.API.Data;

namespace SocialApp.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Register()
        {
            await _repo.Register("User","Password");
            return Ok();
        }
    }
}