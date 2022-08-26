using ONGWebAPI.Entities;
using System.Text.Json.Serialization;

namespace ONGWebAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Roles Role { get; set; }
        public string Password  { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string? Localizacao { get; set; }
        public string? Cidade { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public AutorizacaoNotificacao AutorizacaoNotificacao {  get; set; }
        [JsonIgnore]
        public List<Animal>? Animais { get; set; }
    }
}
