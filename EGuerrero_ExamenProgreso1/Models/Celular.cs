using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EGuerrero_ExamenProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [NotNull]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Required]
        [Range(20, 24, ErrorMessage = "El celular debe estar entre el año 2020 al 2024")]
        public int Año { get; set; }
        public double Precio { get; set; }
    }
}
