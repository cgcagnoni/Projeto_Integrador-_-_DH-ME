namespace ONGWebAPI.Models
{
    public class InteresseAdocao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }        
        public Animal Animal { get; set; }
    }
}

