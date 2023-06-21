using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{   
    
    public class CN_BDD
    {
        private BDD ObjCDBDD = new BDD();


        public bool copiaSeguridad (string nombre)
        {

            return ObjCDBDD.CopiaSeguridad(nombre);
        }

        public bool restaurarBdd(string ruta)
        {
            return ObjCDBDD.restaurarBdd (ruta);
        }

    }
}
