using Api.Models;
using Api.Persistences;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly EmpleadoServices _empleadoServices;

        public EmpleadoController(EmpleadoServices empleadoServices, AppDbContext appDbContext)
        {
            _empleadoServices = empleadoServices;
        }


        [HttpPost(nameof(AgregarDatosMasivos))]
        public async Task<IActionResult> AgregarDatosMasivos()
        {
            var response = await _empleadoServices.AgregarDatosAsincronaMasivamente();
            return Ok(response);
        }

        [HttpPut(nameof(ActualizarDatosMasivos))]
        public async Task<IActionResult> ActualizarDatosMasivos()
        {
            var response = await _empleadoServices.ActualizarDatosAsincronaMasivamente();
            return Ok(response);
        }

        [HttpDelete(nameof(EliminarDatosMasivos))]
        public async Task<IActionResult> EliminarDatosMasivos()
        {
            var response = await _empleadoServices.EliminarDatosAsincronaMasivamente();
            return Ok(response);
        }
    }
}
