using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {


        public Negocio ObtenerDatos ()
        {
            Negocio ObjNegocio = new Negocio ();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open ();
                    string query = " SELECT IdNegocio, Nombre, RUC, Direccion FROM negocio WHERE IdNegocio = 1 ";
                    SqlCommand cmd = new SqlCommand (query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader ())
                    {
                        while (dr.Read ())
                        {
                            ObjNegocio = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                RUC = dr["RUC"].ToString(),
                            };
                        }
                    }
                }
            }
            catch (Exception)
            {
                ObjNegocio = new Negocio();                
            }

            return ObjNegocio;
        }

        public bool GuardarDatos (Negocio ObjNegocio, out string mensaje)
        {

            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE negocio SET Nombre = @nombre, RUC = @ruc, Direccion = @direccion WHERE IdNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@nombre", ObjNegocio.Nombre);
                    cmd.Parameters.AddWithValue("@ruc", ObjNegocio.RUC);
                    cmd.Parameters.AddWithValue("@direccion", ObjNegocio.Direccion);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar los datos del negocio";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta =false;
                mensaje =ex.Message;
            }
            return respuesta;
        }

        public byte[] ObtenerLogo (out bool obtenido)
        {   
            obtenido = true;
            byte[] logoByte = new byte[0];

           

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT Logo FROM negocio WHERE IdNegocio = 1 ";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType= CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            logoByte = (byte[])dr["Logo"];
                            //ObjNegocio = new Negocio()
                            //{
                            //    IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                            //    Nombre = dr["Nombre"].ToString(),
                            //    Direccion = dr["Direccion"].ToString(),
                            //    RUC = dr["RUC"].ToString(),
                            //};
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                logoByte = new byte[0];
            }

            return logoByte;
        }

        public bool ActualizarLogo (byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE negocio SET Logo = @logo WHERE IdNegocio = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@logo", imagen);
                   
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar la imagen del negocio";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }

    }
}
