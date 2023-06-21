using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class BDD
    {


        public bool CopiaSeguridad(string nombre)
        {

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                   
                    string fechaHora = System.DateTime.Now.ToString("dd_MM_yyyy");

                    ObjConexion.Open();
                    string query = "BACKUP DATABASE [proyecto_tallerII] TO  DISK = N'D:\\LucasParodi\\UNNE\\Taller de Programacion II\\Proyecto\\TallerII\\ProyectoTallerII\\ProyectoTallerII\\BDD\\Respaldos\\" + nombre + "_" + fechaHora + ".bak" + "' WITH NOFORMAT, NOINIT,  NAME = N'proyecto_tallerII-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    //string query = "UPDATE cliente SET Estado = 0 WHERE Documento = '65552222'";
                    SqlCommand cmd = new SqlCommand(query, ObjConexion);

                    cmd.CommandType = CommandType.Text;
                    
                    using (SqlDataReader Reader = cmd.ExecuteReader()) { Reader.Read(); }

                    return true;

                }

            }
            catch (Exception)
            {
                return false;                
            }
        }

        public bool restaurarBdd( string ruta )
        {
            try
            {
                using (SqlConnection ObjConexion = new SqlConnection (Conexion.cadena))
                {
                    ObjConexion.Open ();

                    using (SqlCommand command = new SqlCommand("USE master", ObjConexion))
                    {
                        command.ExecuteNonQuery();
                    }

                    string setSingleUserSql = "ALTER DATABASE proyecto_tallerII SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    using (SqlCommand command = new SqlCommand(setSingleUserSql, ObjConexion))
                    {
                        command.ExecuteNonQuery();
                    }
                   
                    string restoreSql = "RESTORE DATABASE [proyecto_tallerII] FROM DISK='" + ruta + "' WITH RECOVERY, FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                    using (SqlCommand command = new SqlCommand(restoreSql, ObjConexion))
                    {
                        command.ExecuteNonQuery();
                    }
                 
                    using (SqlCommand command = new SqlCommand("USE master", ObjConexion))
                    {
                        command.ExecuteNonQuery();
                    }

                    string setMultiUserSql = "ALTER DATABASE proyecto_tallerII SET MULTI_USER";
                    using (SqlCommand command = new SqlCommand(setMultiUserSql, ObjConexion))
                    {
                        command.ExecuteNonQuery();
                    }




                    //string query = "RESTORE DATABASE [proyecto_tallerII] FROM DISK='" + ruta + "' WITH RECOVERY, FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                    //SqlCommand cmd = new SqlCommand (query.ToString(), ObjConexion);
                    //cmd.ExecuteNonQuery();

                    //cmd.CommandType = CommandType.Text;
                    //using (SqlDataReader Reader = cmd.ExecuteReader()) { Reader.Read(); }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }




    }
}
