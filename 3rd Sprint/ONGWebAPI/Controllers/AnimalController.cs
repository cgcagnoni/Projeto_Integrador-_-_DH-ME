﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ONGWebAPI.Entities;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Repository.EntityRepository;
using ONGWebAPI.Services;
using System.Security.Claims;

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
        /// Listar todos os animais
        /// </summary>
        /// <returns>
        /// Lista de todos os animais cadastrados
        /// </returns>
        /// <response code="404">Não há nenhum animal cadastrado</response>
        /// <response code="200">Lista obtida com sucesso</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar obter a lista</response>
        [HttpGet]
        [Authorize(Roles = "Administrador")]
        public ActionResult<List<Animal>> ListarTodos()
        {
            return animalRepository.ListarTodos();
        }


        /// <summary>
        /// Listar animais pela espécie
        /// </summary>                      
        /// <returns>
        /// Lista de todos os animais de acordo com a espécie
        /// </returns>
        /// <remarks>
        /// Colocar aqui um exemplo de como fornecer os valores necessários
        /// </remarks>
        /// <response code="200">Lista obtida com sucesso</response>
        /// <response code="404">Nenhum animal encontrado</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar obter a lista</response>
        [HttpGet("PorEspecie")]
        public ActionResult<List<Animal>> SolicitarPelaEspecie([FromQuery] Especie especie)
        {          
            return animalRepository.SolicitarPelaEspecie(especie);
        }

        [HttpGet("PorLocalizacao")]
        public ActionResult<List<Animal>> SolicitarPelaLocalizacao([FromQuery] Localizacao localizacao)
        {
            return animalRepository.SolicitarPelaLocalizacao(localizacao);
        }

        [HttpGet("PorPorte")]
        public ActionResult<List<Animal>> SolicitarPeloPorte([FromQuery] Porte porte)
        {
            return animalRepository.SolicitarPeloPorte(porte);
        }

        [HttpGet("PorSexo")]
        public ActionResult<List<Animal>> SolicitarPeloSexo([FromQuery] Sexo sexo)
        {
            return animalRepository.SolicitarPeloSexo(sexo);
        }



        /// <summary>
        /// Buscar animal pela Id
        /// </summary>
        /// <returns>Retorna o animal de acordo com o ID fornecido</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     GET / ID
        ///     {
        ///        "Id": 12345678
        ///     }
        /// 
        /// **OBS> máximo de 8 caracteres**
        /// </remarks>
        /// <param name="Id"> ID do animal</param>
        /// <response code="404">Nenhum animal encontrado com este ID</response>
        /// <response code="200">Animal encontrado com sucesso</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar encontrar o animal</response>
        [HttpGet("{Id}")]        
        public ActionResult<Animal> ExibirPelaID(int Id)
        {
            if (animalRepository.VerificarAnimal(Id))
            {
                return Ok(animalRepository.ExibirPelaID(Id));
            }
            else
            {
                //obs: nao esta mostrando a mensagem correta de response code
                return NotFound();
            }
        }


        /// <summary>
        /// Adicionar novo animal 
        /// </summary>
        /// <returns>Adiciona um novo animal à database</returns>
        /// <remarks>
        /// Exemplo de cadastro:
        /// 
        ///     POST / ANIMAL  
        ///     {  
        ///         "id": 1234,  
        ///         "nome": "Lulu",  
        ///         "especie": "Gato",  
        ///         "sexo": "Fêmea",  
        ///         "idade": "1",  
        ///         "porte": "Médio",  
        ///         "vacinas": "antirrabica, triplice, vermifugo ",  
        ///         "foto": "fotoFilhote.png",  
        ///         "localizacao": "São Paulo",  
        ///         "microchip": true,  
        ///         "castrado": true,  
        ///         "deficiencia": false,  
        ///         "disponibilidade": true,  
        ///         "dataCadastro": "2022-07-30T20:32:07.183Z",  
        ///         "usuario":   
        ///         {  
        ///             "id": 123,  
        ///             "nome": "Maria",  
        ///             "sobrenome": "da Silva",  
        ///             "localizacao": "São Paulo",  
        ///             "telefone": "965561231"  
        ///         }  
        ///     }
        /// </remarks>
        /// <response code="201">Animal cadastrado com sucesso</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar cadastrar um animal</response>
        [HttpPost]
        [Authorize]
        public ActionResult<Animal> AdicionaNovoAnimal(Animal Animal)
        {
            Animal.Usuario = new Usuario() { Id = int.Parse(User.FindFirst(ClaimTypes.Sid).Value) };
            animalRepository.AdicionaNovoAnimal(Animal);
            return CreatedAtAction("AdicionaNovoAnimal", new { id = Animal.Id }, Animal);
        }

        ///<summary>
        /// Deletar animal pela Id
        ///</summary>
        ///<returns>Deleta um animal da database pelo Id fornecido</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     DELETE / ID
        ///     {
        ///        "Id": 12345678
        ///     }
        /// 
        /// **OBS> máximo de 8 caracteres** 
        /// </remarks>
        /// <response code="200">Animal deletado da database com sucesso</response>
        /// <response code="404">Animal não encontrado</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar deletar animal da database</response>
        [HttpDelete("{Id}")]
        [Authorize(Roles = "Administrador")]
        public ActionResult ApagarAnimalPelaId(Animal animal, int id)
        {
            if (animalRepository.VerificarAnimal(id))
            {
                animalRepository.ApagarAnimalPelaId(id);
                return Ok();
            }
            return NotFound(); 
        }


        /// <summary>
        /// Atualizar dados do animal pela Id
        /// </summary>
        /// <returns>Atualiza as informações do animal na database de acordo com a Id fornecida</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     GET / ID
        ///     {
        ///        "Id": 12345678
        ///     }
        /// 
        /// **OBS> máximo de 8 caracteres**        
        /// 
        /// 
        ///      PUT / ANIMAL  
        ///         {  
        ///             "id": 1234,  
        ///             "nome": "Luluzinha",    
        ///             "especie": "Gato",  
        ///             "sexo": "Fêmea",  
        ///             "idade": "1",  
        ///             "porte": "Médio",  
        ///             "vacinas": "antirrabica, triplice, vermifugo ",  
        ///             "foto": "fotoFilhote.png",  
        ///             "localizacao": "São Paulo",  
        ///             "microchip": true,  
        ///             "castrado": true,  
        ///             "deficiencia": false,  
        ///             "disponibilidade": true,  
        ///             "dataCadastro": "2022-07-30T20:32:07.183Z",  
        ///             "usuario":   
        ///             {  
        ///                 "id": 123,  
        ///                 "nome": "Maria",  
        ///                 "sobrenome": "da Silva",  
        ///                 "localizacao": "São Paulo",  
        ///                 "telefone": "965561231"  
        ///             }  
        ///         }
        /// </remarks>
        /// <response code="200">Atualizações feitas na database com sucesso</response>
        /// <response code="401">Animal não pertence ao usuário logado</response>
        /// <response code="404">Animal não encontrado</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar atualizar a database</response>
        [HttpPut("{Id}")]
        [Authorize]
        public ActionResult AtualizarInformacoesPelaId(int Id, Animal Animal)
        {
            var animalBanco = animalRepository.ExibirPelaID(Id);
            if (animalBanco.UsuarioId != int.Parse(User.FindFirst(ClaimTypes.Sid).Value))
            {
                return Unauthorized("Animal não pertence ao usuário logado");
            }

            if (animalRepository.VerificarAnimal(Id))
            {
                animalRepository.AtualizarInformacoesPelaId(Id, Animal);
                return Ok();
            }
            else
            {
                return NotFound("Animal nao encontrado");
            };

        }


        /// <summary>
        /// Listar animais de usuário específico pela Id
        /// </summary>
        /// <returns>Lista todos os animais registrados pelo mesmo usuário através da Id fornecida</returns>
        /// <remarks>
        /// Exemplo de requisição:
        ///
        ///     GET / ID
        ///     {
        ///        "Id": 12345678
        ///     }
        /// 
        /// **OBS> máximo de 8 caracteres**         
        /// </remarks> 
        /// <param name="Id"> Id do usuário</param>
        /// <response code="200">Lista obtida com sucesso</response>
        /// <response code="404">Nenhum animal encontrado</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar obter a lista</response>
        [HttpGet("PorUsuario/{Id}")]
        [Authorize]
        public ActionResult<List<Animal>> ListarAnimaisUsuario(int Id,Animal animal)
        {
            animal.Usuario = new Usuario() { Id = int.Parse(User.FindFirst(ClaimTypes.Sid).Value) };
            return animalRepository.ListarAnimaisUsuario(Id);
        }


        /// <summary>
        /// Tabela fato de ADOÇÃO
        /// </summary>
        /// <return>
        /// Lista todos os animais registrados na tabela fato de adoções
        /// </return>
        /// <response code="200">Lista obtida com sucesso</response>
        /// <response code="404">Nenhum animal encontrado</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar obter a lista</response>
        [HttpGet("ListarAnimaisDisponiveis")]
        public ActionResult<List<Animal>> ListarAnimaisDisponiveis()
        {
            //return adocao;
            return animalRepository.ListarAnimaisDisponiveis();
        }


        /// <summary>
        /// Tabela fato de DOAÇÃO
        /// </summary>
        /// <return>
        /// Lista todos os animais registrados na tabela fato de doações
        /// </return>
        /// <response code="200">Lista obtida com sucesso</response>
        /// <response code="404">Nenhum animal encontrado</response>
        /// 
        [HttpGet("ListarAnimaisAdotados")]
        [Authorize(Roles = "Administrador")]
        public ActionResult<List<Animal>> ListarAnimaisAdotados()
        {
            return animalRepository.ListarAnimaisAdotados();
        }


        //Método HTTP que chama função SendMail do objeto MailService 
        //Precisa importar o System.Net.Mail para usar o MailService
        [HttpPost("{Id}")]
        public ActionResult EnviarEmail(int Id)
        {
            MailService mailService = new MailService();
            Animal animal = animalRepository.ExibirPelaID(Id);
            mailService.SendMail(animal.Usuario.Email, animal.Usuario.Nome);

            return Ok();
        }







    }
}
