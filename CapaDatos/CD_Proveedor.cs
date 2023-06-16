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
    public class CD_Proveedor
    {

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdProveedor, Documento, RazonSocial, Correo, Telefono, Estado FROM proveedor");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                                Documento = dr["Documento"].ToString(),
                                RazonSocial= dr["RazonSocial"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Proveedor>();

                }
            }

            return lista;
        }

        //Parametros de salida "Mensaje" es para retornar el mesanje de la BDD
        public int Registrar(Proveedor Obj, out string Mensaje)
        {
            int idProveedorGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProveedor", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("Documento", Obj.Documento);
                    cmd.Parameters.AddWithValue("RazonSocial", Obj.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", Obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", Obj.Telefono);
                    cmd.Parameters.AddWithValue("Estado", Obj.Estado);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                Mensaje = ex.Message;
            }


            return idProveedorGenerado;
        }



        public bool Editar(Proveedor Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ModificarProveedor", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdProveedor", Obj.IdProveedor);
                    cmd.Parameters.AddWithValue("Documento", Obj.Documento);
                    cmd.Parameters.AddWithValue("RazonSocial", Obj.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", Obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", Obj.Telefono);
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

        public bool Eliminar(Proveedor Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdProveedor", Obj.IdProveedor);

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
