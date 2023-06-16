using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Productos
    {

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT  producto.IdProducto, producto.Codigo, categoria.IdCategoria, categoria.Descripcion[DescripcionCategoria], producto.Nombre,  producto.Codigo, producto.Descripcion,  producto.Stock,  producto.PrecioCompra,  producto.PrecioVenta, producto.Estado FROM producto\r\n");
                    query.AppendLine("JOIN categoria ON categoria.IdCategoria = producto.IdCategoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                ObjCategoria = new Categoria() { IdCategoria = Convert.ToInt32(dr["IdCategoria"]), Descripcion = dr["DescripcionCategoria"].ToString(),  },
                                Stock = Convert.ToInt32(dr["Stock"]),
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"]),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<Producto>();

                }
            }

            return lista;
        }

        //Parametros de salida "Mensaje" es para retornar el mesanje de la BDD
        public int Registrar(Producto Obj, out string Mensaje)
        {
            int idProductoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("Codigo", Obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", Obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", Obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", Obj.ObjCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Estado", Obj.Estado);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    idProductoGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                Mensaje = ex.Message;
            }


            return idProductoGenerado;
        }



        public bool Editar(Producto Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_ModificarProducto", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdProducto", Obj.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", Obj.Codigo);
                    cmd.Parameters.AddWithValue("Nombre", Obj.Nombre);
                    cmd.Parameters.AddWithValue("Descripcion", Obj.Descripcion);
                    cmd.Parameters.AddWithValue("IdCategoria", Obj.ObjCategoria.IdCategoria);
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

        public bool Eliminar(Producto Obj, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", ObjConexion);

                    //Parametros de entrada
                    cmd.Parameters.AddWithValue("IdProducto", Obj.IdProducto);

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
