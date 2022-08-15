using ONGWebAPI.Models;
using RestSharp;

namespace ONGWebAPI.Services
{
    public class WhatsappService : IWhatsapp
    {
        public void EnviarMenssagem(InteresseAdocao interesseAdocao)
        {
            var client = new RestClient("https://graph.facebook.com/v13.0/107709008715545");
            //client.Timeout = -1;
            var request = new RestRequest("/messages", Method.Post);
            request.AddHeader("Authorization", "Bearer ");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +
            @"    ""messaging_product"": ""whatsapp""," + "\n" +
            @$"    ""to"": ""55{interesseAdocao.Animal.Usuario.Telefone}""," + "\n" +
            @"    ""type"": ""text""," + "\n" +
            @"    ""text"": {" + "\n" +
            @$"        ""preview_url"": ""{false}""," + "\n" +
            $@"        ""body"": ""Ola, {interesseAdocao.Animal.Usuario.Nome}, tem um interesse no {interesseAdocao.Animal.Nome}! \\nSegue abaixo as informações de contato:\\nNome Completo: {interesseAdocao.Usuario.Nome} {interesseAdocao.Usuario.Sobrenome} \\nTelefone: {interesseAdocao.Usuario.Telefone} \\n""" + "\n" +    
            @"    }" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
