using System;

namespace ejer15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer15";
            Console.WriteLine(CalculadorDeArea.AreaCuadrado(8));
            Console.WriteLine("{0,-10:#,#.00}",CalculadorDeArea.AreaCirculo(10));
            Console.WriteLine(CalculadorDeArea.AreaTriangulo(10 , 4));

            Console.ReadKey();
        }
    }
}
