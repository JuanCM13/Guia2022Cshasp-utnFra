using System;

using InstrumentosMusicales;
namespace ejercicioClase8InstrumentosMusicales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjerClase8";
            CasaDeMusica casa2 = new CasaDeMusica();
            CasaDeMusica casa = new CasaDeMusica(4);
            Instrumento i1 = new Instrumento("pirulo", 1111);
            Instrumento i2 = new Instrumento("pirulo", 1111);
            Guitarra g1 = new Guitarra(Eclasificacion.Cuerdas, ETipoGuitarra.Electroacústica, 2222, "Fender", 6);
            Bateria b1 = new Bateria(3333,"per",Eclasificacion.Percusion,6);
            Trompeta t1 = new Trompeta("trom", 4444, Eclasificacion.Vientos, "agudo");
            Guitarra g2 = new Guitarra(Eclasificacion.Cuerdas, ETipoGuitarra.Criolla, 5555, "Gibson", 6);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Prueba de agregado de elementos, tendrian que tomar todo menos g2 y i2");

            casa = casa + i1;
            casa = casa + i2;
            casa = casa + g1;
            casa = casa + b1;
            casa = casa + t1;
            casa = casa + g2;

            Console.WriteLine(casa.Mostrar());

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Prueba de eliminacion de instr, tendrian que dejar de figurar i1 y t1");

            casa = casa - i1;
            casa = casa - t1;

            Console.WriteLine(casa.Mostrar());

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Prueba de lista vacia, tendrian que tirar mensaje de error, no romper");

            Console.WriteLine(casa2.Mostrar());

            Console.ReadKey();
        }
    }
}
