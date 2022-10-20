using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrjVehiculos.Data;
using PrjVehiculos.Dtos;
using PrjVehiculos.FactoryMethod;
using PrjVehiculos.Helper;
using PrjVehiculos.Models;

namespace PrjVehiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private readonly VehiculosContext _appDbContext;
        public AutoController(VehiculosContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConsultaTiposVehiculo([FromBody] DtoInPLaca dtoIn)
        {
            List<DtoInOutVehiculo> listTipoVehiculo = new List<DtoInOutVehiculo>();

            listTipoVehiculo.Add(new DtoInOutVehiculo { IdTipoVehiculo = 1, NombreTipoVehiculo = "Auto" });
            listTipoVehiculo.Add(new DtoInOutVehiculo { IdTipoVehiculo = 2, NombreTipoVehiculo = "Camioneta" });
            listTipoVehiculo.Add(new DtoInOutVehiculo { IdTipoVehiculo = 3, NombreTipoVehiculo = "Camión" });

            return Ok(listTipoVehiculo);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConsultaVehiculoPorPlaca([FromBody] DtoInPLaca dtoIn)
        {
            Vehiculo vehiculo = new Vehiculo();

            try
            {
                vehiculo = await _appDbContext.Vehiculo?.Where(p => p.Placa == dtoIn.Placa).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                throw;
            }

            return Ok(vehiculo);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CalcularMatricula([FromBody] DtoInPLaca dtoIn)
        {
            decimal valorMatricula = decimal.Zero;

            Vehiculo vehiculo = await _appDbContext.Vehiculo?.Where(p => p.Placa == dtoIn.Placa).FirstOrDefaultAsync();

            int idTipoVehiculo = vehiculo.TipoVehiculo.ToUpper() == "AUTO" ? 1 :
                                 vehiculo.TipoVehiculo.ToUpper() == "CAMIONETA" ? 2 :
                                 vehiculo.TipoVehiculo.ToUpper() == "CAMION" ? 3 : 0;

            Impuestos impuestos = await _appDbContext.Impuestos?.Where(p => p.IdImpuesto == 1).FirstOrDefaultAsync();

            if (idTipoVehiculo == 1)
            {
                Auto auto = VehiculoFactoryHelper.Factory<Auto>(TipoVehiculoEnum.AUTO);
                valorMatricula = auto.CalcularMatricula(impuestos, vehiculo);
            }

            if (idTipoVehiculo == 2)
            {
                Camioneta camioneta = VehiculoFactoryHelper.Factory<Camioneta>(TipoVehiculoEnum.CAMIONETA);
                valorMatricula = camioneta.CalcularMatricula(impuestos, vehiculo);
            }

            if (idTipoVehiculo == 3)
            {
                Camion camion = VehiculoFactoryHelper.Factory<Camion>(TipoVehiculoEnum.CAMION);
                valorMatricula = camion.CalcularMatricula(impuestos, vehiculo);
            }

            return Ok(valorMatricula);
        }
    }
}
