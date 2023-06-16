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
                    cmd.Parameters.AddWithValue("IdUsuario", 1);
                    cmd.Parameters.AddWithValue("TipoDocumento", ObjVenta.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocuemento", ObjVenta.NumeroDocumento);
                    cmd.Parameters.AddWithValue("DocumentoCliente", ObjVenta.DocumentoCliente);
                    cmd.Parameters.AddWithValue("NombreCliente", ObjVenta.NombreCliente);
                    cmd.Parameters.AddWithValue("MontoPago", ObjVenta.MontoTotal);
                    cmd.Parameters.AddWithValue("MontoCambio", ObjVenta.MontoTotal);
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






    }
}
