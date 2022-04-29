using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer18
{
    class Factoreo
    {
        public static double Factorial(Int32 num)
        {
            double aux = num;

            for (int i=num; i>0; i--)
            {
                if (i == 1) //sino rompo antes, como abajo multiplico por i-1, cuando sea 1, me va a multiplicar por 0
                {           //y termina dando el resultaod final 0
                    break;
                }
                aux = aux * (i-1);
            }
            return aux;
        }
    }
}
