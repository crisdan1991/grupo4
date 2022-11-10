using Microsoft.AspNetCore.Mvc;
using Mediator.Mediator;

namespace Mediator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediatorController : ControllerBase
    {
        //[HttpGet(Name = "mediador")]

        [HttpPost]
        [Route("mediador")]
        public void Mensajes([FromBody] MSN ObjMsn)
        {
            Mediator.Mediator mediator = new Mediator.Mediator();

            string tipoUsuario = ObjMsn.Usuario;
            string mensaje = ObjMsn.Mensaje;

            ICollague User1 = new User(mediator);
            ICollague User2 =new UserAdmin(mediator);

            mediator.Add(User1);
            mediator.Add(User2);

            switch(tipoUsuario)
            {
                case "Usuario2":
                    User2.Comminicate(mensaje);
                    break;

                case "Usuario1":
                    User1.Comminicate(mensaje);
                    break;

            }
        }
    }
}