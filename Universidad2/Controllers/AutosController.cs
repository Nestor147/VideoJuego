using Microsoft.AspNetCore.Mvc;
using Universidad2.Context;
using Universidad2.Models;

namespace Universidad2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutosController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public AutosController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarAuto")]
        public async Task<IActionResult> Post([FromBody] Autos autos)
        {
            _aplicacionContext.Autos.Add(autos);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado");
        }
        [HttpGet]
        [Route("MostrarAutos")]
        public async Task<IActionResult> Get()
        {
            List<Autos> listaAutos = _aplicacionContext.Autos.OrderByDescending(e => e.idAuto).ToList();
            return StatusCode(StatusCodes.Status200OK, listaAutos);
        }
        [HttpPut]
        [Route("EditarAutos/")]
        public async Task<IActionResult> Put([FromBody] Autos autos)
        {
            _aplicacionContext.Autos.Update(autos);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente");
        }
        [HttpDelete]
        [Route("EliminarAutos/")]
        public async Task<IActionResult> Delete(int? id)
        {
             Autos auto = _aplicacionContext.Autos.Find(id);
            _aplicacionContext.Autos.Remove(auto);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente");

        }

    }
}
