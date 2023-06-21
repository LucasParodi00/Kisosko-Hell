using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Venta
    {
        //public void listarVentas()
        //{
        //    using(SqlConnection ObjConexion = new SqlConnection())
        //    {
        //        StringBuilder query = new StringBuilder();
        //        query.AppendLine("select NumeroDocumento, CONVERT(CHAR(10), FechaRegistro, 103)[FechaRegistro], MontoTotal from venta "); 
        //        SqlCommand cmd = new SqlCommand(query.ToString(),ObjConexion);
        //        cmd.CommandType = CommandType.Text;
        //        ObjConexion.Open();
        //    }
        //}3

        public List<Venta> listaVentas()
        {
            List<Venta> lista = new List<Venta>();
            
            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                ObjConexion.Open();
                string query = "select NumeroDocumento, CONVERT(CHAR(10), FechaRegistro, 103)[FechaRegistro], MontoTotal from venta ";
                SqlCommand cmd = new SqlCommand(query, ObjConexion);

                using(SqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        lista.Add(new Venta()
                        {
                            NumeroDocumento = Reader["NumeroDocumento"].ToString(),
                            FechaRegistro = Reader["FechaRegistro"].ToString(),
                            MontoTotal = Convert.ToDecimal( Reader["MontoTotal"].ToString())
                        }) ;
                    }
                }
            }


            return lista;
        }

        public int obtenerCorrelativo()
        {
            int idCorrelativo = 0;

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT COUNT(*) + 1 FROM venta");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();

                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar()); // Ejecuta la consulta y devuelve la primer fila que encuentre
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;
                }
            }
            return idCorrelativo;
        }

        public bool restarStock (int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection ObjConexion = new SqlConnection (Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE producto SET Stock = Stock - @Cantidad WHERE @IdProducto = IdProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion .Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    respuesta = false;   
                }
            }


            return respuesta;
        }

        public bool sumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE producto SET Stock = Stock + @Cantidad WHERE @IdProducto = IdProducto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    ObjConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception)
                {
                    respuesta = false;
                }
            }


            return respuesta;
        }

        public bool Registrar(Venta ObjVenta, DataTable DetalleVenta, out string Mensaje)
        {
            Mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarVenta", ObjConexion);
                    cmd.Parameters.AddWithValue("IdUsuario", ObjVenta.ObjUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("TipoDocumento", ObjVenta.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocuemento", ObjVenta.NumeroDocumento);
                    cmd.Parameters.AddWithValue("DocumentoCliente", ObjVenta.DocumentoCliente);
                    cmd.Parameters.AddWithValue("NombreCliente", ObjVenta.NombreCliente);
                    cmd.Parameters.AddWithValue("MontoPago", ObjVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("MontoCambio", ObjVenta.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", ObjVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);

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

        public Venta ObtenerVenta(string numero)
        {

            Venta ObjVenta = new Venta();

            using (SqlConnection ObjConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    ObjConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT venta.IdVenta, usuario.NombreCompleto, venta.DocumentoCliente, venta.NombreCliente, venta.TipoDocumento,");
                    query.AppendLine("venta.NumeroDocumento, venta.MontoPago, venta.MontoCambio, venta.MontoTotal, CONVERT(CHAR(10), venta.FechaRegistro, 103)[FechaRegistro] FROM venta");
                    query.AppendLine("JOIN usuario ON usuario.IdUsuario = venta.IdUsuario");
                    query.AppendLine("WHERE venta.NumeroDocumento = @numero");
         
                    SqlCommand cmd = new SqlCommand(query.ToString(), ObjConexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            ObjVenta = new Venta()
                            {
                                IdVenta = int.Parse(dr["IdVenta"].ToString()),
                                ObjUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"].ToString()),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }

                }
                catch
                {
                    ObjVenta = new Venta();
                }

            }
            return ObjVenta;

        }

        public List<DetalleVenta> ObtenerDetalleVenta(int idVenta)
        {
            List<DetalleVenta> oLista = new List<DetalleVenta>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT producto.Nombre, detalle_venta.PrecioVenta, detalle_venta.Cantidad, detalle_venta.SubTotal FROM detalle_venta");
                    query.AppendLine("JOIN producto ON producto.IdProducto = detalle_venta.IdProducto");
                    query.AppendLine("WHERE detalle_venta.IdVenta = @IdVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@IdVenta", idVenta);
                    cmd.CommandType = System.Data.CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleVenta()
                            {
                                ObjProducto = new Producto() { Nombre = dr["Nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString()),
                            });
                        }
                    }

                }
                catch
                {
                    oLista = new List<DetalleVenta>();
                }
            }
            return oLista;
        }




    }
}
