namespace ONGWebAPI.Models
{
    public class InteresseAdocao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
        public Animal Animal { get; set; }
    }
}
