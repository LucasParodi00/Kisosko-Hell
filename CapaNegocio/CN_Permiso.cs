using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {

        private CD_Permiso ObjCdPermiso = new CD_Permiso();

        public List<Permiso> Listar(int idUsuario)
        {



            return ObjCdPermiso.Listar(idUsuario); //Retornamos la misma lista que se encuentra en Datos
        }

    }
}
