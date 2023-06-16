using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {

        private CD_Cliente ObjCdCliente = new CD_Cliente(); // Instanciar

        public List<Cliente> Listar()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdCliente.Listar();

        }

        public int Registrar(Cliente Obj, out string Mensaje)
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
                return ObjCdCliente.Registrar(Obj, out Mensaje);
            }


        }

        public bool Editar(Cliente Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdCliente.Editar(Obj, out Mensaje);
        }

        public bool Eliminar(Cliente Obj, out string Mensaje)
        {

            //Retornamos la misma lista que se encuentra en Datos

            return ObjCdCliente.Eliminar(Obj, out Mensaje);
        }
    }
}
