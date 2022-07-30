using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Threading;


namespace ONGWebAPI.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Sexo { get; set; }
        public string? Idade { get; set; }
        public string? Porte { get; set; }
        public string? Vacinas { get; set; }
        public string? Foto { get; set; }
        public string? Localizacao { get; set; }
        public bool? Microchip { get; set; }
        public bool? Castrado { get; set; }
        public bool? Deficiencia { get; set; }
        public bool Disponibilidade { get; set; }
        public DateTime DataCadastro { get; set; } 
        public Usuario? Usuario { get; set; }
    }
}
