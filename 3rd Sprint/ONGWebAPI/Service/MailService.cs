using System;
using System.Net;
using System.Net.Mail;

namespace ONGWebAPI.Service
{
    public class MailService
    {
        public MailAddress fromAddress = new MailAddress("assocdaspatinhas@gmail.com", "Associação das Patinhas");
        //Adicionar nomeAnimal e nomeUsuario no corpo da mensagem
        public const string subject = "Temos um possível adotante para{nomeAnimal}!";
        public const string body = "Olá, {nomeUsuario}! Você cadastrou {nomeAnimal} na nossa plataforma e um de nossos usuários indicou interesse na adoção. Estamos enviando alguns dados do possível adotante para que você analise. Caso atenda às suas expectativas ou tenha alguma dúvida sobre o adotante, entre em contato por e-mail ou whatsapp.";
        public const string fromPassword = "bcxrycykshywlcqm";
        public SmtpClient smtp;
        public SmtpClient smtp;

        public MailService()
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

        public void SendMail(string mailUserPet, string nameUserPet)
        {
            var toAddress = new MailAddress(mailUserPet, nameUserPet);
            var message = new MailMessage(fromAddress, toAddress);
            message.Subject = subject;
            message.Body = body;
            smtp.Send(message);
        }
    }
}
