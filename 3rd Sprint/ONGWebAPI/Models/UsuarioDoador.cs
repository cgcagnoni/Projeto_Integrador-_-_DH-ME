namespace ONGWebAPI.Models
{
    public class UsuarioDoador : Usuario
    {
        public string Telefone { get; set; }
        public List<Animal>? Animais { get; set; }
    }
}
