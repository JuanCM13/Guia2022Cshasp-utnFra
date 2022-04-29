using System;

namespace ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejer5";

            /*
             * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
                El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
                El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
                Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
             */

            Int32 acumAnterior;
            Int32 acumDespues;
            Int32 guia = 1;
            Int32 limite;

            do
            {
                Console.WriteLine("Ingrese hasta donde desea calcular..debe ser mayor a cero");
                if (int.TryParse(Console.ReadLine(), out limite) && limite > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error, ingrese un numero mayor a 0..");
                }

            } while (true);

            /*
             * Para no olvidarme:
             * la idea fue arrancar iterando en 1 hasta el limite que elije el usuario.
             * Uso dos fors, el primero arranca en 1 y llega hasta 1 menos que el elemento guia que es el que uso de referencia
             * el primero acumula 1 a 1. Una vez que termina de iterar y acumular, cuando llega al valor que vale guia en ese momento
             * Sale y arranca a iterar el segundo for. Este arranca en guia + 1, el otro terminaba en guia -1, asi el centro numerico
             * no se suma ni nada. y va acumulando, por cada iteracion pregunto, si el acumulador del segundo for, vale lo mismo que
             * el del primero o lo supera, rompo asi deja de iterar hasta el limite al dope.
             * Una vez que sale pregunta, si son iguales ambos acumuladores, quiere decir que la guia en ese momento es un centro
             * numerico, imprime, e incrementa la guia asi para a iterar el proximo elemento, siempre y cuando guia no llegue
             * al limite. Continua iterando....
             */
            do
            {
                acumAnterior = 0;
                acumDespues = 0;

                for (int i = 1; i < guia; i++)
                {
                    acumAnterior += i;
                }

                for (int j = guia + 1; j <= limite; j++)
                {
                    acumDespues += j;
                    if (acumDespues == acumAnterior || acumDespues > acumAnterior)
                    {
                        break;
                    }
                }

                if (acumDespues == acumAnterior)
                {
                    Console.WriteLine($"El numero {guia} es centro numerico...");
                }

                guia++;

            } while (guia <= limite);

            Console.WriteLine("Programa terminado");
            Console.ReadKey();
        }
    }
}
