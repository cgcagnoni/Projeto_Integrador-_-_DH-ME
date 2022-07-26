﻿using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        public ActionResult<List<Animal>> ListarTodos()
        {
            return animalRepository.ListarTodos();
        }

        //Listar animais pela espécie
        [HttpGet("{Espécie}")]
        public ActionResult<List<Animal>> SolicitarPelaEspecie(string Especie)
        {
            if (animalRepository.SolicitarPelaEspecie(Especie) == null)
            {
                return NotFound("Nenhum animal cadastrado");
            }
            else
            {
                return Ok();
            }
        }

        //Exibe animal pela ID
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

        ////adicionar novo animal
        [HttpPost]
        public ActionResult<Animal> AdicionaNovoAnimal(Animal Animal)
        {
            animalRepository.AdicionaNovoAnimal(Animal);
            return CreatedAtAction("AdicionaNovoAnimal", new { id = Animal.Id }, Animal);
        }

        //apaga pela id
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
