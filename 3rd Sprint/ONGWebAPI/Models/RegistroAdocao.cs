namespace ONGWebAPI.Models
{
    public class RegistroAdocao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdUsuario { get; set; }
        public List<Animal>? Animais { get; set; }
    }
}
