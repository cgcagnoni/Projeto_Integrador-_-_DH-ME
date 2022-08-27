using ONGWebAPI.Models;
using ONGWebAPI.Models.WhatsApp;
using RestSharp;
using System.Text.Json;

namespace ONGWebAPI.Services
{
    public class WhatsappService : IWhatsapp
    {

        private string idWhatsappAccount;
        private string token;

        public WhatsappService(string idWhatsappAccount, string token)
        {
            this.token = token;
            this.idWhatsappAccount = idWhatsappAccount;
        }

        public void EnviarMenssagem(InteresseAdocao interesseAdocao)
        {
            var client = new RestClient($"https://graph.facebook.com/v14.0/{this.idWhatsappAccount}/");
            //client.Timeout = -1;
            var request = new RestRequest("/messages", Method.Post);
            request.AddHeader("Authorization", "Bearer " + this.token);
            request.AddHeader("Content-Type", "application/json");

            MessageTemplate message = new MessageTemplate();
            message.messaging_product = "whatsapp";
            message.to = "55" + interesseAdocao.Animal.Usuario.Telefone;
            message.template = new Template();
            message.template.name = "interesse_adocao";
            message.template.language = new Language() { code="pt_BR" };
            message.template.components = new List<Component>();

            Component component = new Component();
            component.type = "body";
            component.parameters = new List<Models.WhatsApp.Parameter>();

            component.parameters.Add(new Models.WhatsApp.Parameter() { type = "text", text = interesseAdocao.Animal.Usuario.Nome });
            component.parameters.Add(new Models.WhatsApp.Parameter() { type = "text", text = interesseAdocao.Animal.Nome });
            component.parameters.Add(new Models.WhatsApp.Parameter() { type = "text", text = interesseAdocao.Nome });
            component.parameters.Add(new Models.WhatsApp.Parameter() { type = "text", text = interesseAdocao.Telefone });
            component.parameters.Add(new Models.WhatsApp.Parameter() { type = "text", text = interesseAdocao.Email });

            message.template.components.Add(component);

            
            var body = JsonSerializer.Serialize(message);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
