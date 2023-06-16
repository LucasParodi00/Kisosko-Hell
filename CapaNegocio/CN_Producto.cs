using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Productos ObjCdProducto = new CD_Productos(); // Instanciar

        public List<Producto> Listar()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdProducto.Listar();

        }

        public int Registrar(Producto Obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            // TENGO QUE PONER TODAS LAS VALIDACIONESSSSS  S DS DSADSDASDASDASDSA Das
            if (Obj.Codigo == "")
            {
                Mensaje += "Es necesario el Documento del ususario\n";
            }
            if (Obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del ususario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                //Retornamos la misma lista que se encuentra en Datos
                return ObjCdProducto.Registrar(Obj, out Mensaje);
            }


        }

        public bool Editar(Producto Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdProducto.Editar(Obj, out Mensaje);
        }

        public bool Eliminar(Producto Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdProducto.Eliminar(Obj, out Mensaje);
        }
    }
}
