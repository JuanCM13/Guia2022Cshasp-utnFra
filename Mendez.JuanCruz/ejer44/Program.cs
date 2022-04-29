using System;

using EntidadesVeh;
namespace ejer44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EjerClase8";
            Concesionaria c1 = 4;
            Concesionaria c2 = 0;
            VehiculoTerrestre v1 = new VehiculoTerrestre(4 , 2 , Colores.Rojo);
            Auto a1 = new Auto(3, 6, Colores.Azul, 5 , 9);
            Camion cam1 = new Camion(6, 12, Colores.Negro, 5, 9000);
            Moto m1 = new Moto(2, 1, Colores.Gris, 500);
            Moto m2 = new Moto(2, 1, Colores.Gris, 500);
            Auto a2 = new Auto(3, 6, Colores.Azul, 5, 9);
            Auto a3 = new Auto(3, 4, Colores.Rojo, 6, 3);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Prueba de agregado de elementos, tendrian que tomar todo menos m2 y a3");

            c1 = c1 + v1;
            c1 = c1 + cam1;
            c1 = c1 + m1;
            c1 = c1 + m2;
            c1 += a2;
            c1 += a3;

            Console.WriteLine(c1.MostrarDataConcesionaria());

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Prueba de eliminacion de lista, tendrian que dejar de figurar v1 y cam1");

            c1 = c1 - v1;
            c1 = c1 - cam1;

            Console.WriteLine(c1.MostrarDataConcesionaria());

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Prueba de lista vacia, tendrian que tirar mensaje de error, no romper");

            c2 += v1;
            c2 += cam1;
            c2 += m1;
            c2 += m2;

            Console.WriteLine(c2.MostrarDataConcesionaria());

            Console.ReadKey();
        }
    }
}
