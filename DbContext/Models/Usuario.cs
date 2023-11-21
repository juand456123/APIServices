using System;
using System.Collections.Generic;

namespace DbContext.Models;

public partial class Usuario
{
    public Guid Id { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? NumeroIdentificacion { get; set; }

    public string? Email { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Password { get; set; }
}
