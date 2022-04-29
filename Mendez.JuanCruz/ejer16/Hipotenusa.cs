using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    class Hipotenusa
    {
        public static double TrianguloRectanguloHipotenusa(double baseT , double altura)
        {
            return Math.Sqrt((Math.Pow(baseT, 2) + Math.Pow(altura, 2)));
        }
    }
}
