using System;
using System.Net;
using System.Net.Mail;

namespace ONGWebAPI.Service
{
    public class MailService
    {
        public MailAddress fromAddress = new MailAddress("assocdaspatinhas@gmail.com", "Associação das Patinhas");
        public const string subject = "Interesse em adoção";
        public const string body = "Texto que será enviado para o usuário que cadastrou o animal";
        public const string fromPassword = "passwGoogleAcounts";
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
