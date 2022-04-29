using System;

using ejer05Entidades;
namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejer5clase";
            Pluma bic = new Pluma("Corchito" , new Tinta(ConsoleColor.Blue , EtipoTinta.China));
            Tinta tintaPrueba = new Tinta(ConsoleColor.Blue, EtipoTinta.China);

            Console.WriteLine(bic);

            if (bic == new Tinta(ConsoleColor.Red))
            {
                Console.WriteLine("Es igual");
            }
            else
            {
                if(bic + tintaPrueba)
                {
                    Console.WriteLine(bic); 
                }
            }

            if(bic - tintaPrueba && bic - tintaPrueba)
            {
                Console.WriteLine(bic);
            }
            
            if(bic - tintaPrueba)
            {
                Console.WriteLine(bic);
            }
            else
            {
                Console.WriteLine("El boligrafo ya esta vacio...");
            }
	
            Console.ReadKey();
        }
    }
}
