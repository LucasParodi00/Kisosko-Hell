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
    public class CN_Compra
    {
        private CD_Compra ObjCdCompra = new CD_Compra(); // Instanciar

        public int obtenerCorrelativo()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdCompra.obtenerCorrelativo();

        }

        public bool Registrar(Compra ObjCompra, DataTable DetalleCompra, out string Mensaje)
        {

            return ObjCdCompra.Registrar(ObjCompra, DetalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            Compra ObjCompra = ObjCdCompra.ObtenerCompra(numero);

            if (ObjCompra.IdCompra != 0)
            { 
                List<DetalleCompra> ObjDetalleCompra = ObjCdCompra.ObtenerDetalleCompra(ObjCompra.IdCompra);

                ObjCompra.ObjDetalleCompra = ObjDetalleCompra; ///obj
            }
            return ObjCompra;
        }

        public List<Compra> listarCompras()
        {
            return ObjCdCompra.listaCompras();
        }
    }
}
