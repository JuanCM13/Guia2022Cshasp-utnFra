using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool ret = false;
            
            if(respuesta == "s")
            {
                ret = true;
            }
            return ret;
        }
    }
}
