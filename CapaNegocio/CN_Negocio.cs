using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Negocio
    {

        private CD_Negocio ObjCdNegocio = new CD_Negocio(); // Instanciar

        public Negocio ObtenerDatos()
        {

            //Retornamos la misma lista que se encuentra en Datos
            return ObjCdNegocio.ObtenerDatos();

        }

        public bool GuardarDatos(Negocio Obj, out string Mensaje)
        {

            Mensaje = string.Empty;

            // TENGO QUE PONER TODAS LAS VALIDACIONESSSSS  S DS DSADSDASDASDASDSA Das
            if (Obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del negocio\n";
            }
            if (Obj.RUC == "")
            {
                Mensaje += "Es necesario el RUC del negocio \n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                //Retornamos la misma lista que se encuentra en Datos
                return ObjCdNegocio.GuardarDatos(Obj, out Mensaje);
            }


        }

        public byte[] ObtenerLogo( out bool obtenido)
        {
            return ObjCdNegocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return ObjCdNegocio.ActualizarLogo(imagen, out mensaje);
        }

    }
}
