using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UserServices.Models
{
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string? Usuario { get; set; }
        public string? Password { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
