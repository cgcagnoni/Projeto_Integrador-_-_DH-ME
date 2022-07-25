using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;

namespace ONGWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private ONGContext DbONG = new ONGContext();

        //Listar todos animais
        [HttpGet]
        public ActionResult<List<Animal>> ListarTodos()
        {
            var Animais = DbONG.Animais?.ToList();

            if (Animais == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Animais);
            }
        }

        //Listar animais pela espécie
        [HttpGet("{Espécie}")]
        public ActionResult<List<Animal>> SolicitarPelaEspecie(string Especie)
        {
            var Animal = DbONG.Animais?.Find(Especie);

            if (Especie == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Animal);
            }
        }

        //Exibe animal pela ID
        [HttpGet("{Id}")]
        public ActionResult<Animal> ExibirPelaID(int Id)
        {
            var Animal = DbONG.Animais?.Find(Id);

            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Animal);
            }
        }

        //adicionar novo animal
        [HttpPost]
        public ActionResult<Animal> AdicionaNovoAnimal(Animal Animal)
        {
            
            DbONG.Animais?.Add(Animal);
            DbONG.SaveChanges();

            return CreatedAtAction("AdicionaNovoAnimal", new { id = Animal.Id }, Animal);
        }

        //apaga pela id
        [HttpDelete("{Id}")]
        public ActionResult ApagarAnimalPelaId(int Id)
        {
            var Animal = DbONG.Animais?.Find(Id);

            if (Animal== null)
            {
                return NotFound();
            }
            else
            {
                DbONG.Animais?.Remove(Animal);
                DbONG.SaveChanges();

                return NoContent();
            }
        }

        [HttpPut("{Id}")]
        public ActionResult AtualizarInformacoesPelaId(int Id, Animal Animal)
        {
            
            if (Id != Animal.Id)
            {
                return BadRequest();
            }
            else
            {
                DbONG.Entry(Animal).State = EntityState.Modified;
                DbONG.SaveChanges();
                return Ok();
            }
        }

    }
}
