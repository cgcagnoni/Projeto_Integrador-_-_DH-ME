using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;

namespace ONGWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private ONGContext DbONG = new ONGContext();

        //Listar todos os usuários
        [HttpGet]
        public ActionResult<List<Usuario>> ListarTodos()
        {
            var User = DbONG.Usuarios?.ToList();

            if (User == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(User);
            }
        }

        //Exibe usuário pela ID
        [HttpGet("{Id}")]
        public ActionResult<Usuario> ExibirPelaID(int Id)
        {
            var User = DbONG.Usuarios?.Find(Id);

            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(User);
            }
        }

        //adicionar novo usuario
        [HttpPost]
        public ActionResult<Usuario> AdicionaNovoAnimal(Usuario Usuario)
        {

            DbONG.Usuarios?.Add(Usuario);
            DbONG.SaveChanges();

            return CreatedAtAction("AdicionaNovoUsuario", new { id = Usuario.Id }, Usuario);
        }

        //apaga pela id
        [HttpDelete("{Id}")]
        public ActionResult ApagarUsuarioPelaId(int Id)
        {
            var User = DbONG.Usuarios?.Find(Id);

            if (User == null)
            {
                return NotFound();
            }
            else
            {
                DbONG.Usuarios?.Remove(User);
                DbONG.SaveChanges();

                return NoContent();
            }
        }

        //atualizar usuário pela id
        [HttpPut("{Id}")]
        public ActionResult AtualizarInformacoesPelaId(int Id, Usuario Usuario)
        {

            if (Id != Usuario.Id)
            {
                return BadRequest();
            }
            else
            {
                DbONG.Entry(Usuario).State = EntityState.Modified;
                DbONG.SaveChanges();
                return Ok();
            }
        }
    }
}
