using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {

        private CD_Usuario ObjCdUsuario = new CD_Usuario(); // Instanciar

        public List<Usuario> Listar()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdUsuario.Listar();

        }

        public int Registrar(Usuario Obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            // TENGO QUE PONER TODAS LAS VALIDACIONESSSSS  S DS DSADSDASDASDASDSA Das
            if (Obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del ususario\n";
            }
            if (Obj.NombreCompleto == "")
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
                return ObjCdUsuario.Registrar(Obj, out Mensaje);
            }


        }

        public bool Editar(Usuario Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdUsuario.Editar(Obj, out Mensaje);
        }

        public bool Eliminar(Usuario Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdUsuario.Eliminar(Obj, out Mensaje);
        }

    }
}
