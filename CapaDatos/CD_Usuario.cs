using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Usuario
    {

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT IdUsuario, Documento, NombreCompleto, Correo, Clave, Estado, rol.IdRol, rol.Descripcion FROM usuario");
                    query.AppendLine("INNER JOIN rol ON usuario.IdRol = rol.IdRol");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                ObjRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), descripcion = dr["Descripcion"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Usuario>();

                }
            }

            return lista;
        }

        //Parametros de salida "Mensaje" es para retornar el mesanje de la BDD
        public int Registrar(Usuario Obj, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarUsuario", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("Documento", Obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", Obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", Obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", Obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", Obj.ObjRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", Obj.Estado);

                    //Parametros de Salida
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }


            return idUsuarioGenerado;
        }



        public bool Editar(Usuario Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarUsuario", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdUsuario", Obj.IdUsuario);
                    cmd.Parameters.AddWithValue("Documento", Obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", Obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", Obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", Obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", Obj.ObjRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", Obj.Estado);

                    //Parametros de Salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
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

        public bool Eliminar(Usuario Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdUsuario", Obj.IdUsuario);

                    //Parametros de Salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
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
