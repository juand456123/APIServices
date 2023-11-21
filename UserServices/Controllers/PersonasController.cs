using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using UserServices.Context;
using UserServices.Models;

namespace UserServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly DataContext _context;
        public PersonasController(DataContext dataContext)
        {
            _context = dataContext;
        }


        [HttpGet(Name ="Listar")]
        public async Task<ActionResult<IEnumerable<Personas>>> GetList()
        {
            return await _context.Personas.FromSqlRaw<Personas>("exec GetListPersonas").ToListAsync();
        }

        [HttpPost(Name = "InsertarPersonas")]
        public async Task<ActionResult<bool>> InsertPersonas(InsertPersonas personas)
        {
            try
            {
                var usuarios = await _context.AddAsync(new Personas
                {
                    Nombres = personas.Nombres + personas.Apellidos,
                    NumeroIdentificacion = personas.TipoIdentificacion + personas.NumeroIdentificacion,
                    Email = personas.Email,
                    FechaCreacion = DateTime.Now
                }
            );
                _context.SaveChanges();
                return true;
            }
            catch ( Exception ex ) 
            {
                return false;
            }
           
        }


    }
}
