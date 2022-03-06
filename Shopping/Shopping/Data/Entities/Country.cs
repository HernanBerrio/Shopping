using System.ComponentModel.DataAnnotations;

namespace Shopping.Date.Entities
{
    public class Country
    {
        public int Id { get; set; } //Simpre una propiedad tiepo int Clave primaria 

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }


    }
}

