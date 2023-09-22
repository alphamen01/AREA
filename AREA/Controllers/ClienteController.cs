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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteProvider clienteProvider;

        public ClienteController(IClienteProvider clienteProvider)
        {
            this.clienteProvider = clienteProvider;
        }
        [HttpGet("clientes")]
        public async Task<IActionResult> GetAllAsync()
        {
            var results = await clienteProvider.GetAllAsync();
            if (results != null)
            {
                return Ok(results);
            }
            return NotFound("No se encontraron registros de clientes.");
        }

        [HttpGet("cliente/{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await clienteProvider.GetAsync(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound("No se encontro registro del cliente.");

        }
    }
}
