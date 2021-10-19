using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD_PeriferiaIT.Models;

namespace CRUD_Carvajal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VuelosController : ControllerBase
    {
        private readonly VuelosContext _context;

        public VuelosController(VuelosContext context)
        {
            _context = context;
        }


        // GET: api/Viajes
        /// <summary>
        /// Lista de todos los registros de vuelo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vuelos>>> GetVuelos()
        {
            return await _context.Vuelos.ToListAsync();
        }

        // GET: api/Viajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vuelos>> GetVuelos(int id)
        {
            var vuelos = await _context.Vuelos.FindAsync(id);

            if (vuelos == null)
            {
                return NotFound();
            }

            return vuelos;
        }


        // PUT: api/Viajes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Crear un registro nuevo de vuelo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="vuelos"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVuelos(int id, Vuelos vuelos)
        {
            if (id != vuelos.VueloID)
            {
                return BadRequest();
            }

            _context.Entry(vuelos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VuelosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // POST: api/Viajes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Actualizar registro de vuelo
        /// </summary>
        /// <param name="vuelos"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Vuelos>> PostVuelos(Vuelos vuelos)
        {
            _context.Vuelos.Add(vuelos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVuelos", new { id = vuelos.VueloID }, vuelos);
        }


        // DELETE: api/Viajes/5
        /// <summary>
        /// Eliminar registro de vuelo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVuelos(int id)
        {
            var vuelos = await _context.Vuelos.FindAsync(id);
            if (vuelos == null)
            {
                return NotFound();
            }

            _context.Vuelos.Remove(vuelos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VuelosExists(int id)
        {
            return _context.Vuelos.Any(e => e.VueloID == id);
        }
    }
}
