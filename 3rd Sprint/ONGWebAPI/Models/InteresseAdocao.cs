using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace ONGWebAPI.Models
{
    public class InteresseAdocao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        [ValidateNever] 
        public virtual Animal Animal { get; set; }

        private int _AnimalId;
        [JsonIgnore]
        public int AnimalId
        {
            get => this.Animal?.Id ?? _AnimalId; 
        //    if (this.Animal?.Id == null)
        //        {
        //    return _AnimalId;
        //}
        //        return this.Animal?.Id;
        set {
                if (this.Animal == null)
                {
                    _AnimalId = value;
                }
            }
        }
    }
}

