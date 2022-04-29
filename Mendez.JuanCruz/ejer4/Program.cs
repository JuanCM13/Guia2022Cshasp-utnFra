using System;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
            (excluido el mismo) que son divisores del número.
            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            Escribir una aplicación que encuentre los 4 primeros números perfectos.
            */

            Console.Title = "ejer4";

            Int32 cantidadDenumerosAencontrar = 4;
            Int32 contadorPerfectos = 0;
            Int32 acum;
            Int32 guia = 1;

            /*Para no olvidarme, arranco y seteo la guia en 1, ya que arranco a evaluar numeros desde el 1, el 0 no..
             uso do while e itero hasta que encuentre la cantidad de numeros hardcodeada (4 en este caso)
             arranco a comparar y hago un for interno para evaluar los numeros divisibles desde uno antes que la guia,
                asi excluyo y no se suma el mismo numero que siempre  es divisible por si mismo, hasta el 1 inclusive
                acumulo los divisores, sale del for y si el acumulador llega a ser igual al numero guia, el numero es perfecto
                imprime e incrementa el contador de perfectos.
                Luego avanza en 1 la guia para ir recorriendo 1 a 1 y evaluar cual es perfecto o no. hasta que
                el contador de primos llegue a ser 4...*/
            do
            {
                acum = 0;

                for(int i=guia-1; i>0; i--) 
                {
                    if(guia % i == 0)
                    {
                        acum += i;
                    }
                }

                if(acum == guia)
                {
                    Console.WriteLine($"El numero: {guia} es perfecto!");
                    contadorPerfectos++;
                }

                guia++;

            } while (contadorPerfectos != cantidadDenumerosAencontrar);

            Console.WriteLine("Programa finalizado...");
            Console.ReadKey();
        }
    }
}
