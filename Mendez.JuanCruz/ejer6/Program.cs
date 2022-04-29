using System;

namespace ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejer6";
            /*
             Escribir un programa que determine si un año es bisiesto.
             Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también 
             son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
             Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            */

            Int32 año;

            do
            {
                Console.WriteLine("Ingrese un año..");
                if(int.TryParse(Console.ReadLine() , out año))
                {
                    if(año % 4 == 0 || (año % 100 != 0 && año % 400 == 0))
                    {
                        Console.WriteLine("El año {0} Es bisiesto..",año);
                    }
                    else
                    {
                        Console.WriteLine("El año {0} No es bisiesto..", año);
                    }
                }
                else
                {
                    Console.WriteLine("Error...");
                }

                Console.WriteLine("Continuamos? s/n");
                if (Console.ReadLine() != "s")
                {
                    break;
                }

            } while (true);
            Console.ReadKey();
        }
    }
}
