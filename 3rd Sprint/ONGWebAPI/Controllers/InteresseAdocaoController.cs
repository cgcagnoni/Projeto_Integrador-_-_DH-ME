using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ONGWebAPI.Models;
using ONGWebAPI.Repository;
using ONGWebAPI.Services;
using System.Security.Claims;
using System.Security.Permissions;

namespace ONGWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteresseAdocaoController : ControllerBase
    {
        private IInteresseAdocao interesseRepository;
        private IWhatsapp whatsappService;
        private IAnimalRepository animalRepository;
        public InteresseAdocaoController(IInteresseAdocao interesseRepository,IAnimalRepository animalRepository, IWhatsapp whatsappService)
        {
            this.interesseRepository = interesseRepository;
            this.whatsappService = whatsappService;
            this.animalRepository = animalRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Administrador")]
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

        [HttpPost("InteresseAdocao")]
        public ActionResult InteresseAdocao(InteresseAdocao interesseAdocao)
        {

            interesseAdocao.Data = DateTime.Now;
            var animal = this.animalRepository.ExibirPelaID(interesseAdocao.AnimalId);
            if (animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.WhatsApp || animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.EmailEWhatsApp)
            {
                whatsappService.EnviarMenssagem(interesseAdocao);
            }
            if (animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.Email || animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.EmailEWhatsApp)
            {
                // envia por email
            }
            return Ok();
        }

  


    }
}
