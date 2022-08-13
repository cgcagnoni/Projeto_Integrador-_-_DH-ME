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
            request.AddHeader("Authorization", "Bearer EAAGEqBZBTu0IBAJUBRukXJLZBMoIIHMNmVceRAZABr432i3EOcGTdwrF2eDeNIQZCZA2fPmknrP3h29oZBEKQWEBD2LZCP4Yja0aeJtJmHceonBpKtZAYcIEw7i1fs0iE5ZB6KUA2UfHZC326BcZBPjZAMBAZBplyjXbcizjWZC8AgwZA8AjPOaB86ZBFKumjUjq2A6JgiHtUIyn0NJlr7CPXb4rMgPm0lorCRc3ZAwoZD");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +
            @"    ""messaging_product"": ""whatsapp""," + "\n" +
            @"    ""to"": ""5516981888223""," + "\n" +
            @"    ""type"": ""template""," + "\n" +
            @"    ""template"": {" + "\n" +
            @"        ""name"": ""hello_world""," + "\n" +
            @"        ""language"": {" + "\n" +
            @"            ""code"": ""en_US""" + "\n" +
            @"        }" + "\n" +
            @"    }" + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
