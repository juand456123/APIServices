using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserServices.Models
{
    public class Personas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public string? Nombres { get; set; } = null;   
        public string? NumeroIdentificacion { get; set; } = null;

        public string? Email { get; set; } = null;

        public DateTime? FechaCreacion { get; set; }

    }
}
