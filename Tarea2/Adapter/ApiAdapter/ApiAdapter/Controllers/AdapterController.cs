using adapter.Adapter;
using ApiAdapter.Model;
using Microsoft.AspNetCore.Mvc;
using ApiAdapter.Data;

namespace ApiAdapter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdapterController : ControllerBase
    {
        private readonly AdapterDbContext _context;

        public AdapterController(AdapterDbContext context)
        {
            _context = context;
        }


        [HttpGet(Name = "ObtenerTemperatura")]
        public  decimal Get(string Bloque)
        {
            decimal temperatura = 0;

            IDispositivo getTemp = new Dispositivo1();

            Temperatura tem = new Temperatura();

            switch (Bloque)
            { 
                case "Bloque A":
                    temperatura = getTemp.ObtenerTemperatura(Bloque);
                    tem.bloque = "Bloque A";
                    break;
                case "Bloque B":
                    temperatura = getTemp.ObtenerTemperatura(Bloque);
                    tem.bloque = "Bloque B";
                    break;
                case "Bloque C":
                    getTemp = new Adapter();
                    temperatura = getTemp.ObtenerTemperatura(Bloque);
                    tem.bloque = "Bloque C";
                    
                    break;

            }
            tem.temp = temperatura;
            _context.Temperatura.Add(tem);
            _context.SaveChanges();
            return temperatura;
        }
    }
}