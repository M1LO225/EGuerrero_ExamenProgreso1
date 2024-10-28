using System.ComponentModel.DataAnnotations;

namespace EGuerrero_ExamenProgreso1.Models
{
    public class GuerreroEmilio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        [MaxLength(30, ErrorMessage = "El nombre no puede ser de mas de 30 caracteres")]
        public string Nombre { get; set; }
        [Required]
        [StringLength(30)]
        [MaxLength(30, ErrorMessage = "El apellido no puede ser de mas de 30 caracteres")]
        public string Apellido { get; set; }
        [Display(Name = "Tiene experiencia en este trabajo?")]
        public bool TieneExperiencia { get; set; }
        
        public DateTime FechaNacimiento { get; set; }
        public double Salario { get; set; }

    }
}
