using Microsoft.AspNetCore.Mvc;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Services;

namespace ONGWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteresseAdocaoController : ControllerBase
    {
        private IInteresseAdocao interesseRepository;
        private IWhatsapp whatsappService;
        public InteresseAdocaoController(IInteresseAdocao interesseRepository, IWhatsapp whatsappService)
        {
            this.interesseRepository = interesseRepository;
            this.whatsappService = whatsappService;
        }

        [HttpGet]
        public ActionResult<List<InteresseAdocao>> ListarTodos()
        {
            return interesseRepository.ListarInteressados();
        }

        [HttpPost]
        public ActionResult<InteresseAdocao> PostInteresseAdocao(InteresseAdocao interesseAdocao)
        {
            interesseRepository.PostInteresseAdocao(interesseAdocao);
            return CreatedAtAction("PostInteresseAdocao", new { id = interesseAdocao.Id }, interesseAdocao);            
        }

        [HttpPost("InteresseAdo")]
        public ActionResult InteresseAdotar(InteresseAdocao interesseAdocao)
        {
            interesseAdocao.Data = DateTime.Now;
            whatsappService.EnviarMenssagem(interesseAdocao);
            return Ok();
        }


    }
}
