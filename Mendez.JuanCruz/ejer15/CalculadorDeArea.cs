using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class CalculadorDeArea
    {
        public static double AreaTriangulo(double baseT , double altura)
        {
            return (baseT * altura)/2;
        }

        public static double AreaCuadrado(double longitudLado)
        {
            return longitudLado * 4;
        }

        public static double AreaCirculo(double radio)
        {
            return Math.PI * (Math.Pow((radio), 2));  
        }
    }
}
