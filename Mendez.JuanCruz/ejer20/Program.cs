using System;

namespace ejer20
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio I02 - ¿Vos cuántas primaveras tenés?
             */
            Console.Title = "Ejer20";

            //-----
            Persona carlos = new Persona();
            Persona paula = new Persona("Paula", new DateTime(1990,11,08), 33458785);
            Persona camila = new Persona("Camila", new DateTime(2020,05,11), 50458224);

            Console.WriteLine(carlos.Mostrar());
            Console.WriteLine(paula.Mostrar());
            Console.WriteLine(camila.Mostrar());


            Console.ReadKey();
        }
    }
}
