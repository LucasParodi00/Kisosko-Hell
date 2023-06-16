using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {

        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder(); // FUNCION PARA PERMITIR SALTOS DE LINEAAAAAAAAAA
                    query.AppendLine("SELECT rol.IdRol, permiso.Nombre FROM permiso");
                    query.AppendLine("JOIN rol ON rol.IdRol = permiso.IdRol");
                    query.AppendLine("JOIN usuario ON usuario.IdRol = rol.IdRol");
                    query.AppendLine("WHERE usuario.IdRol = @idUsuario");


                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario); // Para reemplazar el @ 
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                ObjRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                Acceso = dr["Nombre"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Permiso>();

                }
            }

            return lista;
        }

    }
}
