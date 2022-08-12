using Microsoft.AspNetCore.Mvc;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Services;

namespace ONGWebAPI.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> AuthenticareAsync([FromBody] User model)
        {
            var user = UserRepository.GET(model.Username, model.Password);

            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }
            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user= user,
                token=token,
            };
        }

    }


}
