using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuyVosBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<UsuariosController>
        [HttpGet("GetUsuarios")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listUsuarios = await _context.Usuarios.ToListAsync();
                return Ok(listUsuarios);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
