using System;

using BibliotecaBoligrafo;
namespace ejer22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Consigna, invento Argentino*/
            Console.Title = "Ejer22";
            Boligrafo boligrafo1 = new Boligrafo(100 , ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(43, ConsoleColor.Red);
            String aux;

            Console.WriteLine("Nivel Tinta boli1: {0}", boligrafo1.GetTinta());
            Console.WriteLine("Nivel Tinta boli2: {0}", boligrafo2.GetTinta());

            if (boligrafo1.Pintar(160 , out aux))
            {
                Console.WriteLine(aux);
            }

            if (boligrafo2.Pintar(45, out aux))
            {
                Console.WriteLine(aux);
            }

            Console.WriteLine("Nivel Tinta boli1: {0}", boligrafo1.GetTinta());
            Console.WriteLine("Nivel Tinta boli2: {0}", boligrafo2.GetTinta());

            boligrafo1.Recargar();
            boligrafo2.Recargar();

            Console.WriteLine("Nivel Tinta boli1: {0}", boligrafo1.GetTinta());
            Console.WriteLine("Nivel Tinta boli2: {0}", boligrafo2.GetTinta());

            if (boligrafo1.Pintar(100, out aux))
            {
                Console.WriteLine(aux);
            }

            if (boligrafo2.Pintar(125, out aux))
            {
                Console.WriteLine(aux);
            }
            Console.WriteLine("Nivel Tinta boli1: {0}", boligrafo1.GetTinta());
            Console.WriteLine("Nivel Tinta boli2: {0}", boligrafo2.GetTinta());

            Console.ReadKey();
        }
    }
}
