using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MuyVosBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuyVosBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VentasController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<VentasController>
        [HttpGet("GetVentas")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listVentas = await _context.Ventas.ToListAsync();
                return Ok(listVentas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<VentasController>
        [HttpPost("PostVenta")]
        public async Task<IActionResult> Post([FromBody] Venta venta)
        {
            try
            {
                _context.Add(venta);
                await _context.SaveChangesAsync();
                return Ok(venta);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<VentasController>/5
        [HttpPut("UpdateVenta/{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Venta venta)
        {
            try
            {
                if (id != venta.Id)
                {
                    return BadRequest();
                }
                _context.Update(venta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Actualizado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<VentasController>/5
        [HttpDelete("DeleteVenta/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var venta = await _context.Ventas.FindAsync(id);

                if (venta == null)
                {
                    return NotFound();
                }

                _context.Ventas.Remove(venta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Producto eliminado" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
