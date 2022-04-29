using System;

namespace ejercicioClaseshechoEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePropia.cadena = "Hola mundo";

            Console.WriteLine(ClasePropia.Mostrar());

            //ClasePropia.Borrar();
            Console.WriteLine(ClasePropia.Mostrar());

            ClasePropia.color = ConsoleColor.Red;
            ClasePropia.ImprimirEnColor();

            ClasePropia.cadena = null;
            Console.WriteLine(ClasePropia.Mostrar());

            ClasePropia.cadena = "Hola mundo";
            Console.WriteLine(ClasePropia.Mostrar());
            
            Console.ReadKey();
        }
    }
}
