using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ONGWebAPI.Entities;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Repository.EntityRepository;
using ONGWebAPI.Services;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ONGWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        /// <summary>
        /// Adicionar novo usuário
        /// </summary>
        /// <returns>
        /// Adiciona um novo usuário na database
        /// </returns>
        ///<remarks>
        ///Exemplo de cadastro:
        ///
        ///     POST / USUARIO
        ///     {
        ///         "id": 789,
        ///         "nome": "João",
        ///         "sobrenome": "da Silva",
        ///         "localizacao": "Minas Gerais",
        ///         "telefone": "981883415"
        ///     }
        /// </remarks>
        /// <response code="200">Usuário cadastrado com sucesso</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar cadastrar um usuário</response>
        [HttpPost]
        public ActionResult AdicionaNovoUsuario(Usuario usuario)
        {

            if (usuario.Password == null || usuario.Username == null)
            {
                return NotFound(new { message = "Usuário ou senha inválidos" });
            }
            usuario.Role = Entities.Roles.Usuario;
            usuario.Password = this.hashPassword(usuario.Password);
            this._usuarioRepository.AdicionaNovoUsuario(usuario);
            return CreatedAtAction("AdicionaNovoUsuario", new
            {
                user = usuario.Username,
                id = usuario.Id
            }, usuario);
        }

        [HttpGet("Login")]
        public ActionResult<String> Login(string username, string senha)
        {
            if (username == null || senha == null)
            {
                return Unauthorized("usuario ou senha incorretos");
            }

            var user = this._usuarioRepository.Login(username, hashPassword(senha));

            if (user == null)
            {
                return Unauthorized("usuario ou senha incorretos");
            }
            else
            {
                return Ok(TokenService.GenerateToken(user));
            }
        }

        private string hashPassword(string password)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                return Convert.ToBase64String(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }

        }


        /// <summary>
        /// Deletar usuário pela Id
        /// </summary>
        /// <returns>
        /// Deleta um usuário de acordo com a Id fornecida
        /// </returns>
        /// <param name="Id">Id do Usuário</param>
        ///<remarks>
        /// Exemplo de requisição:
        ///
        ///     DELETE / ID
        ///     {
        ///        "Id": 12345678
        ///     }
        /// 
        /// **OBS> máximo de 8 caracteres**        
        /// </remarks>
        /// <response code="200">Usuário deletado com sucesso</response>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar deletar um usuário</response>
        [HttpDelete("{Id}")]
        [Authorize(Roles = "Administrador")]
        public ActionResult ApagarUsuarioPelaId(int Id)
        {
            if (_usuarioRepository.VerificarUsuario(Id))
            {
                _usuarioRepository.ApagarUsuarioPelaId(Id);
                return Ok();
            }
            return NotFound("Usuário nao encontrado");
        }


        /// <summary>
        /// Atualizar dados de usuário pela Id
        /// </summary>
        /// <returns>Atualiza as informações do usuário na database de acordo com a Id fornecida</returns>
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
        ///      PUT / USUARIO 
        ///     {  
        ///         "id": 123,  
        ///         "nome": "Maria",  
        ///         "sobrenome": "da Silva",  
        ///         "localizacao": "São Paulo",  
        ///         "telefone": "965561231"  
        ///     }  
        /// </remarks>
        /// <param name="Id">Id do usuário</param>
        /// <response code="200">Atualizações feitas na database com sucesso</response>
        /// <response code="404">Usuário não encontrado</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar atualizar a database</response>
        [HttpPut("{Id}")]
        [Authorize]
        public ActionResult AtualizarInformacoesPelaId(int Id, Usuario Usuario)
        {
            if (!User.IsInRole(Roles.Administrador.ToString()))
            {
                Id = int.Parse(User.FindFirst(ClaimTypes.Sid).Value);
            }
            if (_usuarioRepository.VerificarUsuario(Id))
            {
                _usuarioRepository.AtualizarInformacoesPelaId(Id, Usuario);

                return Ok();
            }
            else
            {
                return NotFound("Usuario nao encontrado");
            }

        }



        /// <summary>
        /// Buscar usuário pela Id
        /// </summary>
        /// <returns>Mostra informações do usuário específico através da Id fornecida</returns>
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
        /// <response code="200">Usuário encontrado com sucesso</response>
        /// <response code="404">Nenhum usuário encontrado com este Id</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar encontrar o usuário</response>
        [HttpGet("{Id}")]
        [Authorize]
        public ActionResult<Usuario> ExibirPelaID(int Id)
        {
            Id = int.Parse(User.FindFirst(ClaimTypes.Sid).Value);
            var usuario = _usuarioRepository.ExibirPelaID(Id);
            if (usuario != null)
            {
                return Ok(usuario);
            }
            else
            {
                return NotFound("Usuario nao encontrado");
            }
        }


        /// <summary>
        /// Listar todos os usuários
        /// </summary>
        /// <returns>Lista todos os usuários registrados na database</returns>
        /// <response code="404">Não há nenhum usuário cadastrado</response>
        /// <response code="200">Lista obtida com sucesso</response>
        /// <response code="400">Erro desconhecido ocorrido ao tentar obter a lista</response>
        [HttpGet]
        [Authorize(Roles = "Administrador")]
        public ActionResult<List<Usuario>> ListarTodos()
        {
            return _usuarioRepository.ListarTodos();
        }
    }
}
