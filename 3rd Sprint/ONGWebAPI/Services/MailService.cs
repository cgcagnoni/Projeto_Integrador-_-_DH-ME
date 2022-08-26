using ONGWebAPI.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace ONGWebAPI.Services
{
    public class MailService
    {       
        public MailAddress fromAddress = new MailAddress("assocdaspatinhas@gmail.com", "Associação das Patinhas");
        public const string subject = "Interesse em adoção";
        public SmtpClient smtp;

        public MailService(string fromPassword)
        {
            smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

        }

        //public void SendMail(string mailUserPet, string nameUserPet)
        //{
        //    var toAddress = new MailAddress(mailUserPet, nameUserPet);
        //    var message = new MailMessage(fromAddress, toAddress);
        //    message.Subject = subject;
        //    //message.Body = body;
        //    smtp.Send(message);
        //}

        public void SendEmail(InteresseAdocao interesseAdocao)
        {
            var toAddress = new MailAddress(interesseAdocao.Animal.Usuario.Email, interesseAdocao.Animal.Usuario.Nome);
            var message = new MailMessage(fromAddress, toAddress);
            message.Subject = subject;
            message.Subject = subject;
            message.IsBodyHtml = false;
            message.Body = $"Olá, {interesseAdocao.Animal.Usuario.Nome}! Você cadastrou {interesseAdocao.Animal.Nome} na nossa plataforma e um de nossos usuários indicou interesse na adoção. Estamos enviando alguns dados do possível adotante para que você analise. Caso atenda às suas expectativas ou tenha alguma dúvida sobre o adotante, entre em contato por e-mail ou whatsapp. \\\\nSegue abaixo as informações de contato:\\\\nNome Completo: {interesseAdocao.Nome} \\\\nTelefone: {interesseAdocao.Telefone} \\\\nE-mail: {interesseAdocao.Email}\\\\n";
            smtp.Send(message);
        }
    }
}
