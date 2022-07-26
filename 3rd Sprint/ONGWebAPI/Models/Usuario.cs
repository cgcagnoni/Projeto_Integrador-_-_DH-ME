namespace ONGWebAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string? Localizacao { get; set; }
        public string? Telefone { get; set; }
        public List<Animal>? Animais { get; set; }
    }
}
