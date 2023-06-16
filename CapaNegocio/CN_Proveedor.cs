using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Proveedor
    {

        private CD_Proveedor ObjCdProveedor = new CD_Proveedor(); // Instanciar

        public List<Proveedor> Listar()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdProveedor.Listar();

        }

        public int Registrar(Proveedor Obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            // TENGO QUE PONER TODAS LAS VALIDACIONESSSSS  S DS DSADSDASDASDASDSA Das
            if (Obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del ususario\n";
            }
            if (Obj.RazonSocial == "")
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
                return ObjCdProveedor.Registrar(Obj, out Mensaje);
            }


        }

        public bool Editar(Proveedor Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdProveedor.Editar(Obj, out Mensaje);
        }

        public bool Eliminar(Proveedor Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdProveedor.Eliminar(Obj, out Mensaje);
        }

    }
}
