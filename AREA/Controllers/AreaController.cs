using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AREA.Interfaces;
using AREA.Models;

namespace AREA.Controllers
{
    [Route("api")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaProvider areaProvider;

        public AreaController(IAreaProvider areaProvider)
        {
            this.areaProvider = areaProvider;
        }

        [HttpGet("areas")]
        public async Task<IActionResult> GetAllAsync()
        {
            var results = await areaProvider.GetAllAsync();
            if (results != null)
            {
                return Ok(results);
            }
            return NotFound("No se encontraron registros de areas.");
        }

        [HttpGet("area/{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await areaProvider.GetAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("No se encontro registro del area.");

        }

        [HttpPut("area/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, Area area)
        {
            if (id != area.id_area)
            {
                return BadRequest("El ID proporcionado en la URL no coincide con el ID del área proporcionado en el cuerpo de la solicitud.");
            }

            var result = await areaProvider.UpdateAsync(id, area);

            if (result)
            {
                return Ok(result);
            }
            else
            {
                return NotFound("El área no se encontró o no se pudo actualizar.");
            }
        }

        [HttpPost("area")]
        public async Task<IActionResult> AddAsync(Area area)
        {
            var result = await areaProvider.AddAsync(area);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest("No se pudo registrar el área.");
        }

        [HttpDelete("area/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await areaProvider.DeleteAsync(id);
            if (result == true)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
