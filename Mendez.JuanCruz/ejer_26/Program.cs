using System;

using ClaseSumador;
namespace ejer_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer26";

            Sumador suma = new Sumador(25);
            Sumador suma2 = new Sumador(27);

            Console.WriteLine( suma.Sumar(25 , 26));
            Console.WriteLine(suma2.Sumar("PEPE" , "Diosito"));
            Console.WriteLine(suma.Sumar("Jorge" , "Macri"));

            if(suma | suma2)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine($"SUMA S2: { (Int32)suma2}");
                Console.WriteLine($"SUMA S1: { (Int32) suma}");
            }

            Console.ReadKey();
        }
    }
}
