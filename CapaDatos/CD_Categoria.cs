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
    public class CD_Categoria
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdCategoria, Descripcion, Estado FROM categoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])

                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Categoria>();

                }
            }

            return lista;
        }

        //Parametros de salida "Mensaje" es para retornar el mesanje de la BDD
        public int Registrar(Categoria Obj, out string Mensaje)
        {
            int Resultado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("Descripcion", Obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", Obj.Estado);


                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    Resultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                Resultado = 0;
                Mensaje = ex.Message;
            }


            return Resultado;
        }



        public bool Editar(Categoria Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ModificarCategoria", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdCategoria", Obj.IdCategoria);
                    cmd.Parameters.AddWithValue("Descripcion", Obj.Descripcion);
                    cmd.Parameters.AddWithValue("Estado", Obj.Estado);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
                throw;
            }


            return respuesta;
        }

        public bool Eliminar(Categoria Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdCategoria", Obj.IdCategoria);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
                throw;
            }


            return respuesta;
        }
    }
}
