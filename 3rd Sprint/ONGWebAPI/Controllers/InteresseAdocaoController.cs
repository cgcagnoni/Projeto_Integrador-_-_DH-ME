﻿using Microsoft.AspNetCore.Authorization;
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
        private MailService mailService;
        public InteresseAdocaoController(IInteresseAdocao interesseRepository, IAnimalRepository animalRepository, IWhatsapp whatsappService, MailService mailService)
        {
            this.interesseRepository = interesseRepository;
            this.whatsappService = whatsappService;
            this.animalRepository = animalRepository;
            this.mailService = mailService;
        }

        [HttpGet]
        [Authorize]//Roles = "Administrador")]
        public ActionResult<List<InteresseAdocao>> ListarTodos()
        {
            return interesseRepository.ListarInteressados();
        }
        [HttpGet("InteressadosPorUsuario")]
        [Authorize]
        public ActionResult<List<InteresseAdocao>> ListarInteressadosPorUsuario()
        {
            int Id = int.Parse(User.FindFirst(ClaimTypes.Sid).Value);
            return interesseRepository.ListarInteressadosPorUsuario(Id);
        }

        [HttpPost]
        public ActionResult InteresseAdocao(InteresseAdocao interesseAdocao)
        {
            interesseAdocao.Data = DateTime.Now;

            interesseRepository.PostInteresseAdocao(interesseAdocao);

            var animal = this.animalRepository.ExibirPelaID(interesseAdocao.AnimalId);
            if (animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.WhatsApp || animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.EmailEWhatsApp)
            {
                try
                {
                    whatsappService.EnviarMenssagem(interesseAdocao);
                }
                catch (Exception)
                {
                }
            }
            if (animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.Email || animal?.Usuario?.AutorizacaoNotificacao == Entities.AutorizacaoNotificacao.EmailEWhatsApp)
            {                
                try
                {
                    mailService.SendEmail(interesseAdocao);
                }
                catch (Exception)
                {
                }
            }
            return CreatedAtAction("InteresseAdocao", new { id = interesseAdocao.Id }, interesseAdocao);
        }

    }
}
