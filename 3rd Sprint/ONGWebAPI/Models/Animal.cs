using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ONGWebAPI.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Threading;


namespace ONGWebAPI.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Especie Especie { get; set; }
        public Sexo Sexo { get; set; }
        public Idade Idade { get; set; }
        public Porte? Porte { get; set; }
        public string? Vacinas { get; set; }
        public string? Foto { get; set; }
        public Localizacao? Localizacao { get; set; }
        public bool? Microchip { get; set; }
        public bool? Castrado { get; set; }
        public bool? Deficiencia { get; set; }
        public bool Disponibilidade { get; set; }
        public DateTime DataCadastro { get; set; }
        [ValidateNever]
        public virtual Usuario Usuario { get; set; }
        private int _UsuarioId;
        [JsonIgnore]
        public int UsuarioId
        {
            get => this.Usuario?.Id ?? _UsuarioId;

            set
            {
                if(this.Usuario == null)
                {
                    _UsuarioId = value;
                }
            }
        }
        

        
    }
}
