using System.Data.SqlClient;

namespace Mediator
{
    internal class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;

        private bool seguridad;

        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "todolist";
            this.Servidor = "38.67.136.229";
            this.Usuario = "todolist";
            this.Clave = "Todo2022!";
            this.seguridad = false;
        }

        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";

                if(this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id="+ this.Usuario +"; Password="+this.Clave;
                }
            }
            catch (Exception ex)
            { 
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion crearInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }



    }
}
