using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Compra
    {

        public int obtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT COUNT(*) + 1 FROM compra");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    idCorrelativo = Convert.ToInt32( cmd.ExecuteScalar() ); // Ejecuta la consulta y devuelve la primer fila que encuentre
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }
            return idCorrelativo;
        }


        public bool Registrar (Compra ObjCompra, DataTable DetalleCompra, out string Mensaje)
        {
            Mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCompra", ObjConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", 1 );
                    cmd.Parameters.AddWithValue("IdProveedor",ObjCompra.ObjProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", ObjCompra.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", ObjCompra.NumeroDocumento);
                    cmd.Parameters.AddWithValue("NombreCompleto", ObjCompra.ObjProveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("MontoTotal", ObjCompra.MontoTotal);
                    cmd.Parameters.AddWithValue("Detalle_Compra", DetalleCompra);

                    //Parametros de Salida
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    ObjConexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return respuesta;
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra ObjCompra = new Compra();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT compra.IdCompra, usuario.NombreCompleto, proveedor.Documento, proveedor.RazonSocial, compra.TipoDocumento, compra.NumeroDocumento,");
                    query.AppendLine("compra.MontoTotal, CONVERT(CHAR(10), compra.FechaRegistro, 3)[FechaRegistro] FROM compra");
                    query.AppendLine("JOIN usuario ON usuario.IdUsuario = compra.IdUsuario");
                    query.AppendLine("JOIN proveedor ON proveedor.IdProveedor = compra.IdProveedor");
                    query.AppendLine("WHERE compra.NumeroDocumento = @numero");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ObjCompra = new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                ObjUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                ObjProveedor = new Proveedor() { Documento = dr["Documento"].ToString(), RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["NumeroDocumento"].ToString()

                            };
                            
                        }
                    }
                }
                catch (Exception ex)
                {

                    ObjCompra = new Compra();

                }
            }
            return ObjCompra;
        }

        public List<DetalleCompra> ObtenerDetalleCompra(int idCompra)
        {
            List<DetalleCompra> lista = new List<DetalleCompra>();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT producto.Nombre, detalle_compra.PrecioCompra, detalle_compra.Cantidad, detalle_compra.MontoTotal FROM detalle_compra");
                    query.AppendLine("JOIN producto ON producto.IdProducto = detalle_compra.IdProducto");
                    query.AppendLine("WHERE detalle_compra.IdCompra = @IdCompra");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);

                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);

                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DetalleCompra()
                            {
                                ObjProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {

                    lista = new List<DetalleCompra>();

                }
            }
            return lista;
        }



    }
}
