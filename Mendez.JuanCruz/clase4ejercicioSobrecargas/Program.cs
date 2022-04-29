using System;

namespace clase4ejercicioSobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjerEjemploSobreCargas";

            Cosa dato = new Cosa();
            Cosa dato2 = new Cosa(5 , "palabra2");
            Cosa dato3 = new Cosa("palabra3");
            Cosa dato4 = new Cosa(new DateTime(2021, 10, 25), 15, "palabra4");

            Console.WriteLine(Cosa.Mostrar(dato));
            Console.WriteLine(Cosa.Mostrar(dato2));
            Console.WriteLine(Cosa.Mostrar(dato3));
            Console.WriteLine(Cosa.Mostrar(dato4));


            dato.EstablecerValor(10);
            dato.EstablecerValor(new DateTime(2020, 05, 10));
            dato.EstablecerValor("Hola");

            Console.WriteLine(Cosa.Mostrar(dato));



            Console.ReadKey();
        }
    }
}
