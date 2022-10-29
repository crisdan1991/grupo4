using Microsoft.AspNetCore.Mvc;
using TemplateMethod.Template;

namespace TemplateMethod.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> CalcularPrecio()
        {
            Libro libroDigital = new Digital();
            double precioDigital = libroDigital.CalcularPercioFinal();

            Libro libroImpreso = new Impreso();
            double precioImpreso = libroImpreso.CalcularPercioFinal();

            PreciosPorLibro result = new PreciosPorLibro { PrecioDigtal = precioDigital, PrecioImpreso = precioImpreso };

            return Ok(result);
        }
    }
}

public class PreciosPorLibro
{
    public double PrecioDigtal { get; set; }
    public double PrecioImpreso { get; set; }
}