using System;

using LibroIndexado;
namespace ejer42
{
    class Program
    {
        static void Main(string[] args)
        {
            //libro indexado
            Console.Title = "Ejer42";

            Libro libro = new Libro();
            libro[0] = "Jon I";
            libro[1] = "Daenerys II";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Tyrion III";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }

            Console.ReadKey();
        }
    }
}
