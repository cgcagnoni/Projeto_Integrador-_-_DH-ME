using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Repository.EntityRepository;
using ONGWebAPI.Services;

namespace ONGWebAPI.Controllers
{
    [ApiController]
    [Route("v1/account")]
    public class LoginController : ControllerBase
    {
        private ONGContext DbONG;

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> AuthenticareAsync([FromBody] User model)
        {
            var user = UserRepository.GET(model.Username, model.Password);

            if (user == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }

            DbONG.User?.Add(model);
            DbONG.SaveChanges();
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
