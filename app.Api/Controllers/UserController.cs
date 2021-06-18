using System.Linq;
using System.Threading.Tasks;
using app.Api.Data;
using app.Api.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using app.Api.Service;

namespace app.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public UserController()
        {
            _tokenService = new TokenService();
        }

        [HttpGet("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromServices] DataContext context, [FromBody] User user)
        {
            var userDb = await context.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefaultAsync();
            if (userDb == null)
                return NotFound(new { Message = "Usuário ou senha inválidos" });

            var token = _tokenService.GenerateToken(user);
            return Ok(new
            {
                user = user,
                token = token
            });
        }
    }
}