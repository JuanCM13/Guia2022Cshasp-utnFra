using System;
using EstadisticaDeportiva3._0;

namespace ejer45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer45";

            //estadistica equiupos jugadores 2.0 con propiedades.
            Console.Title = "Ejer43";

            Equipo equipo = new Equipo(5, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);
            DirectorTecnico d1 = new DirectorTecnico("jorge", new DateTime(2020, 11, 13));

            Jugador j5 = new Jugador(1111, "Jugador agregado para testear el indexador", 6, 5);

            /*if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());
            
            Console.WriteLine("************************************************************");
            Console.WriteLine(equipo.MostrarDatos());
            */
            equipo[0] = j5;
            equipo[1] = j1;
            equipo[2] = j2;
            //equipo[3] = j5;
            //equipo[4] = j3;
            equipo[3] = j4;
            equipo[4] = d1;
            equipo[5] = j5;
            Console.WriteLine(equipo.MostrarDatos());

            equipo[0] = j3;
            Console.WriteLine("************************************************************");
            Console.WriteLine(equipo.MostrarDatos());


            Console.ReadKey();
        }
    }
}
