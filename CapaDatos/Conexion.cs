

using System.Configuration;
namespace CapaDatos
{
    public class Conexion
    {

        public static string cadena = ConfigurationManager.ConnectionStrings["CapaPresentacion.Settings1.BDD2"].ToString();

    }
}
