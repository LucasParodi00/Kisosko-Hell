using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Cliente
    {

        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdCliente, Documento, NombreCompleto, Correo, Telefono, Estado FROM cliente");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);

                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                           lista.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Cliente>();

                }
            }

            return lista;
        }

        //Parametros de salida "Mensaje" es para retornar el mesanje de la BDD
        public int Registrar(Cliente Obj, out string Mensaje)
        {
            int idClienteGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCliente", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("Documento", Obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", Obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", Obj.Correo);
                    cmd.Parameters.AddWithValue("Telefono", Obj.Telefono);
                    cmd.Parameters.AddWithValue("Estado", Obj.Estado);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                Mensaje = ex.Message;
            }


            return idClienteGenerado;
        }



        public bool Editar(Cliente Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ModificarCliente", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdCliente", Obj.IdCliente);
                    cmd.Parameters.AddWithValue("Documento", Obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", Obj.NombreCompleto);
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

        public bool Eliminar(Cliente Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM cliente WHERE IdCliente = @id", ObjConexion);
                    cmd.Parameters.AddWithValue("@id", Obj.IdCliente);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    respuesta =  cmd.ExecuteNonQuery () > 0 ? true : false ;

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
