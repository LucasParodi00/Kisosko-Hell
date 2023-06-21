using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {

        private CD_Venta ObjCdVenta = new CD_Venta(); // Instanciar

        public int obtenerCorrelativo()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdVenta.obtenerCorrelativo();

        }

        public bool Registrar(Venta ObjVenta, DataTable DetalleVenta, out string Mensaje)
        {

            return ObjCdVenta.Registrar(ObjVenta, DetalleVenta, out Mensaje);
        }

        public bool restarStock(int idProducto, int cantidad)
        {
            return ObjCdVenta.restarStock(idProducto, cantidad);

        }

        public bool sumarStock(int idProducto, int cantidad)
        {
            return ObjCdVenta.sumarStock(idProducto, cantidad);
        }

        public Venta ObtenerVenta(string numero)
        {
            Venta ObjVenta = ObjCdVenta.ObtenerVenta(numero);

            if (ObjVenta.IdVenta != 0)
            {
                List<DetalleVenta> oDetalleVenta = ObjCdVenta.ObtenerDetalleVenta(ObjVenta.IdVenta);
                ObjVenta.ObjDetalleVenta = oDetalleVenta;
            }

            return ObjVenta;

        }

        public List<Venta> listaVentas()
        {
            return ObjCdVenta.listaVentas();
        }
    }
}
