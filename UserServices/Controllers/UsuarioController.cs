using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserServices.Context;
using UserServices.Models;

namespace UserServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;
        public UsuarioController(DataContext dataContext)
        {
            _context = dataContext;
        }


        [HttpPost(Name = "InsertarUsuarios")]
        public async Task<ActionResult<bool>> InsertarUsuarios(InsertUsuarios usuario)
        {
            try
            {
                var usuarios = await _context.AddAsync(new Users
                {
                    Usuario = usuario.Usuario ,
                    Password = SecurityManager.Encrypt(usuario.Password),
                    FechaCreacion = DateTime.Now
                }
            );
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        [HttpGet(Name = "Login")]
        public async Task<ActionResult<bool>> Login(string usuario , string password)
        {
            try
            {
                var usuarioss = await _context.Users.Where(x => x.Usuario == usuario &&
                                                           x.Password == SecurityManager.Encrypt(password)).ToListAsync();
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
