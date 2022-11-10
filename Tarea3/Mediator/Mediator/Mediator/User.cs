using System.Data.SqlClient;

namespace Mediator.Mediator
{
    class User : ICollague
    {
        public User(IMediator mediator) : base(mediator)
        { 

        }
        
        public override void Receive(string messaje)
        {
            
            SqlConnection con = new SqlConnection();
            
            string mensaje = messaje;
            string sql = "INSERT INTO MENSAJE(USUARIO_MENSAJE, MENSAJE, TIPO_MENSAJE) " +
                "VALUES('Usuario2','" + mensaje +"','Mensaje a Usuario1')";
            con = Conexion.crearInstancia().crearConexion();

            SqlCommand cmd= new SqlCommand(sql, con);

            con.Open();
            string respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "Fallo ingreso";
            Console.WriteLine(respuesta);
        }
    }
}
