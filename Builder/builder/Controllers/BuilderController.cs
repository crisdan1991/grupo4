using builder.builder;
using builder.builder.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace builder.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuilderController : ControllerBase
    {

        [HttpGet(Name = "computador")]
        public activos computador(string activo)
        {
            var activos = new ActivoDirector();
            var compu = new Computador();
            var mesa = new mesa();
            var auto = new auto();

            switch (activo)
            {
                case "Computador":
                    activos.setBuilder(compu);
                    break;
                case "Mesa":
                     activos.setBuilder(mesa);
                    break;
                case "Auto":
                    activos.setBuilder(auto);
                    break;
            }

            activos.crearActivo();


          var res =  activos.getBuilder().getActivo();
           

            return res;
        }
    }
}