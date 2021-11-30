using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Role_Playing_Game.Data;
using Role_Playing_Game.Dtos.User;
using Role_Playing_Game.Models;

namespace Role_Playing_Game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;

        }

    [HttpPost("Register")]
    public async Task<IActionResult> Register(UserRegisterDto request)
    {
        ServiceResponse<int> response = await _authRepo.Register(
            new User{ UserName = request.Username }, request.Password
        );
        if (!response.Success)
        {
            return BadRequest(response);
        }
        return Ok(response);    
    }
    }
}