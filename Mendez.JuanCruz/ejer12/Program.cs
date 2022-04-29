using System;

namespace ejer12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.ConversorB_D("001101110"));

            Console.WriteLine("\n\n");
            Console.WriteLine(Conversor.ConversorD_B(345));

            Console.ReadKey();
        }
    }
}
