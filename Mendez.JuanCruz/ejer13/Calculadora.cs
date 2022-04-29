using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{
    class Calculadora
    {
        public static double Calcular(int numA , int numB , string operador)
        {
            double result = 0;

            switch(operador)
            {
                case "+":
                    result = numA + numB;        
                break;
                case "-":
                    result = numA - numB;
                break;
                case "*":
                    result = numA * numB;
                break;
                case "/":
                    if(Calculadora.Validar(numB))
                    {
                        result = numA / numB;
                    }
                break;
            }

            return result;
        }

        private static bool Validar(int divisor)
        {
            bool ret = false;

            if(divisor != 0)
            {
                ret = true;
            }
            return ret;
        }
    }
}
