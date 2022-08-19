using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Repository.EntityRepository;
using ONGWebAPI.Services;

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
            var token = TokenService.GenerateToken(usuario);
            this._usuarioRepository.AdicionaNovoUsuario(usuario);
            return CreatedAtAction("AdicionaNovoUsuario", new {
                user = usuario.Username,
                token = token,
                id = usuario.Id }, usuario);

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
        public ActionResult AtualizarInformacoesPelaId(int Id, Usuario Usuario)
        {
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
        public ActionResult<Usuario> ExibirPelaID(int Id)
        {
            if (_usuarioRepository.VerificarUsuario(Id))
            {
                return Ok(_usuarioRepository.ExibirPelaID(Id));
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
        public ActionResult<List<Usuario>> ListarTodos()
        {
            return _usuarioRepository.ListarTodos();
        }







        //private ONGContext DbONG = new ONGContext();

        ////Listar todos os usuários
        //[HttpGet]
        //public ActionResult<List<Usuario>> ListarTodos()
        //{
        //    var User = DbONG.Usuarios?.ToList();

        //    if (User == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(User);
        //    }
        //}

        ////Exibe usuário pela ID
        //[HttpGet("{Id}")]
        //public ActionResult<Usuario> ExibirPelaID(int Id)
        //{
        //    var User = DbONG.Usuarios?.Find(Id);

        //    if (Id == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(User);
        //    }
        //}

        ////adicionar novo usuario
        //[HttpPost]
        //public ActionResult<Usuario> AdicionaNovoUsuario(Usuario Usuario)
        //{

        //    DbONG.Usuarios?.Add(Usuario);
        //    DbONG.SaveChanges();

        //    return CreatedAtAction("AdicionaNovoUsuario", new { id = Usuario.Id }, Usuario);
        //}

        ////apaga pela id
        //[HttpDelete("{Id}")]
        //public ActionResult ApagarUsuarioPelaId(int Id)
        //{
        //    var User = DbONG.Usuarios?.Find(Id);

        //    if (User == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        DbONG.Usuarios?.Remove(User);
        //        DbONG.SaveChanges();

        //        return NoContent();
        //    }
        //}

        ////atualizar usuário pela id
        //[HttpPut("{Id}")]
        //public ActionResult AtualizarInformacoesPelaId(int Id, Usuario Usuario)
        //{

        //    if (Id != Usuario.Id)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        DbONG.Entry(Usuario).State = EntityState.Modified;
        //        DbONG.SaveChanges();
        //        return Ok();
        //    }
        //}
    }
}
