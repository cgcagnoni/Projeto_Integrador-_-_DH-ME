namespace ONGWebAPI.Models
{
    public class UsuarioAdotante : Usuario
    {
        public string Telefone { get; set; }
        public List<Animal>? Animais { get; set; }
    }
}
