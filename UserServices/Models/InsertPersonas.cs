namespace UserServices.Models
{
    public class InsertPersonas
    {
        public string? Nombres { get; set; } = null;
        public string? Apellidos { get; set; } = null;
        public string? TipoIdentificacion {  get; set; } = null; 
        public string? NumeroIdentificacion { get; set; } = null;
        public string? Email { get; set; } = null;
        public DateTime? FechaCreacion { get; set; }
    }
}
