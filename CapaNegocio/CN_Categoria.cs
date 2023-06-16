using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {

        private CD_Categoria ObjCdCategoria = new CD_Categoria(); // Instanciar

        public List<Categoria> Listar()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdCategoria.Listar();

        }

        public int Registrar(Categoria Obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            // TENGO QUE PONER TODAS LAS VALIDACIONESSSSS  S DS DSADSDASDASDASDSA Das
            if (Obj.Descripcion == "")
            {
                Mensaje += "Es necesario el nombre de la categoria \n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                //Retornamos la misma lista que se encuentra en Datos
                return ObjCdCategoria.Registrar(Obj, out Mensaje);
            }


        }

        public bool Editar(Categoria Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdCategoria.Editar(Obj, out Mensaje);
        }

        public bool Eliminar(Categoria Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdCategoria.Eliminar(Obj, out Mensaje);
        }

    }
}
