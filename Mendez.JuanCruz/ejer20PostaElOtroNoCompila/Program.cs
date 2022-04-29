using System;

namespace ejer20PostaElOtroNoCompila
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio I02 - ¿Vos cuántas primaveras tenés?
             */
            Console.Title = "Ejer20";

            //-----pruebo constructores sin parametros y con parametros
            Persona carlos = new Persona();
            Persona paula = new Persona("Paula", new DateTime(1990, 11, 08), 33458785);
            Persona camila = new Persona("Camila", new DateTime(2020, 05, 11), 50458224);

            Console.WriteLine(carlos.Mostrar());
            Console.WriteLine(paula.Mostrar());
            Console.WriteLine(camila.Mostrar());

            //-----seteo a carlos desde el main a ver si funca bien
            carlos.SetDni(19456425);
            carlos.SetFechaNacimiento(new DateTime(1983, 10, 5));
            carlos.SetNombre("Carlos");
            Console.WriteLine(carlos.Mostrar());

            //------pruebo si funca bien el metodo esMayor.
            Console.WriteLine($"{carlos.Mostrar()}{carlos.EsMayor()}\n");
            Console.WriteLine($"{paula.Mostrar()}{paula.EsMayor()}\n");
            Console.WriteLine($"{camila.Mostrar()}{camila.EsMayor()}\n");

            Console.ReadKey();
        }
    }
}
