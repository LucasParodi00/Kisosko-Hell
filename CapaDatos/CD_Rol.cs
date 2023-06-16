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
    public class CD_Rol
    {

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder(); // FUNCION PARA PERMITIR SALTOS DE LINEAAAAAAAAAA
                    query.AppendLine("SELECT idRol, Descripcion FROM rol");



                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    //cmd.Parameters.AddWithValue("@idUsuario", idUsuario); // Para reemplazar el @ 
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Rol>();

                }
            }

            return lista;
        }

    }
}
