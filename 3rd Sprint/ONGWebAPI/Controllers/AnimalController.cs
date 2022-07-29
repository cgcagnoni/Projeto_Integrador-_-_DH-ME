using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Repository.EntityRepository;

namespace ONGWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        IAnimalRepository animalRepository;

        public AnimalController(IAnimalRepository animalRepository)
        {
            this.animalRepository = animalRepository;
        }

        /// <summary>
        /// Lista todos os animais cadastrados
        /// </summary>
       
        [HttpGet]
        public ActionResult<List<Animal>> ListarTodos()
        {
            return animalRepository.ListarTodos();
        }

        /// <summary>
        /// Lista animais de acordo com a espécie
        /// </summary>
        /// <remarks>
        /// Colocar aqui um exemplo de como fornecer os valores necessários
        /// </remarks>

        [HttpGet("PorEspecie/{Especie}")]
        public ActionResult<List<Animal>> SolicitarPelaEspecie(string Especie)
        {
            var especie = animalRepository.SolicitarPelaEspecie(Especie);
            if (especie?.Count > 0)
            {
                return Ok(especie);
            }
            else
            {
                return NotFound("Nenhum animal cadastrado");
            }
        }

        /// <summary>
        /// Busca animal pela ID
        /// </summary>
        /// <remarks>
        /// Colocar aqui um exemplo de como fornecer os valores necessários
        /// </remarks>

        [HttpGet("{Id}")]
        public ActionResult<Animal> ExibirPelaID(int Id)
        {
            if (animalRepository.VerificarAnimal(Id))
            {
                return Ok(animalRepository.ExibirPelaID(Id));
            }
            else
            {
                return NotFound("Animal nao encontrado");
            }
        }

        /// <summary>
        /// Adiciona um novo animal 
        /// </summary>
        /// <remarks>
        /// Colocar aqui um exemplo de como fornecer os valores necessários
        /// </remarks>
        [HttpPost]
        public ActionResult<Animal> AdicionaNovoAnimal(Animal Animal)
        {            
            animalRepository.AdicionaNovoAnimal(Animal);
            return CreatedAtAction("AdicionaNovoAnimal", new { id = Animal.Id }, Animal);
        }

        ///<summary>
        /// Deleta um animal de acordo com o Id
        ///</summary>
        /// <remarks>
        /// Colocar aqui um exemplo de como fornecer os valores necessários
        /// </remarks>
        [HttpDelete("{Id}")]
        public ActionResult ApagarAnimalPelaId(int Id)
        {
            if (animalRepository.VerificarAnimal(Id))
            {
                animalRepository.ApagarAnimalPelaId(Id);
                return Ok();
            }
            return NotFound("Usuario nao encontrado");
        }

        /// <summary>
        /// Atualiza informações do animal de acordo com a Id
        /// </summary>
        /// <remarks>
        /// Colocar aqui um exemplo de como fornecer os valores necessários
        /// </remarks>

        [HttpPut("{Id}")]
        public ActionResult AtualizarInformacoesPelaId(int Id, Animal Animal)
        {
            if (animalRepository.VerificarAnimal(Id))
            {
                animalRepository.AtualizarInformacoesPelaId(Id, Animal);
                return Ok();
            }
            else
            {
                return NotFound("Usuario nao encontrado");
            };

        }

        /// <summary>
        /// Lista os animais de um usuário específico, de acordo com a Id
        /// </summary>
        /// <remarks>
        /// Colocar aqui um exemplo de como fornecer os valores necessários
        /// </remarks>
        [HttpGet("PorUsuario/{Id}")]
        public ActionResult<List<Animal>> ListarAnimaisUsuario(int Id)
        {
            return animalRepository.ListarAnimaisUsuario(Id);
        }

        /// <summary>
        /// Tabela fato das adoções de animais da ONG 
        /// </summary>
        /// <returns>
        /// Lista de animais adotados e disponíveis para adoção 
        /// </returns>

        [HttpGet("ListarAnimaisAdocao")]
        public ActionResult<List<Animal>> ListarAnimaisAdocao([FromQuery] bool adocao)
        {
            //return adocao;
            return animalRepository.ListarAnimaisAdocao(adocao);           
        }

        /// <summary>
        /// Tabela fato de animais que foram doados para a ONG
        /// </summary>
        /// <returns>
        /// Lista de animais que foram doados 
        /// </returns>
        [HttpGet("ListarAnimaisDoacao")]
        public ActionResult<List<Animal>> ListarAnimaisDoacao()
        {
            return animalRepository.ListarAnimaisDoacao();
        }







        //private ONGContext DbONG;// = new ONGContext();

        ////Listar todos animais
        //[HttpGet]
        //public ActionResult<List<Animal>> ListarTodos()
        //{
        //    var Animais = DbONG.Animais?.ToList();

        //    if (Animais == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(Animais);
        //    }
        //}

        ////Listar animais pela espécie
        //[HttpGet("{Espécie}")]
        //public ActionResult<List<Animal>> SolicitarPelaEspecie(string Especie)
        //{
        //    var Animal = DbONG.Animais?.Find(Especie);

        //    if (Especie == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(Animal);
        //    }
        //}

        ////Exibe animal pela ID
        //[HttpGet("{Id}")]
        //public ActionResult<Animal> ExibirPelaID(int Id)
        //{
        //    var Animal = DbONG.Animais?.Find(Id);

        //    if (Id == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(Animal);
        //    }
        //}

        ////adicionar novo animal
        //[HttpPost]
        //public ActionResult<Animal> AdicionaNovoAnimal(Animal Animal)
        //{

        //    DbONG.Animais?.Add(Animal);
        //    DbONG.SaveChanges();

        //    return CreatedAtAction("AdicionaNovoAnimal", new { id = Animal.Id }, Animal);
        //}

        ////apaga pela id
        //[HttpDelete("{Id}")]
        //public ActionResult ApagarAnimalPelaId(int Id)
        //{
        //    var Animal = DbONG.Animais?.Find(Id);

        //    if (Animal== null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        DbONG.Animais?.Remove(Animal);
        //        DbONG.SaveChanges();

        //        return NoContent();
        //    }
        //}

        //[HttpPut("{Id}")]
        //public ActionResult AtualizarInformacoesPelaId(int Id, Animal Animal)
        //{

        //    if (Id != Animal.Id)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        DbONG.Entry(Animal).State = EntityState.Modified;
        //        DbONG.SaveChanges();
        //        return Ok();
        //    }
        //}

    }
}
