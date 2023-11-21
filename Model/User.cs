using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Password { get; set; }

    }
}
