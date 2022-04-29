using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    class Validador
    {
        public static bool Validar(int dato, int min, int max)
        {
            bool ret = false;
            if(dato >= min && dato <= max)
            {
                ret = true;
            }
            return ret;
        }

    }
}
