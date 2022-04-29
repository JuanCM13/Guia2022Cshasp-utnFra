using System;

using EstadisticaDeportiva;
namespace ejer39
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(4, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);

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
            Console.WriteLine(equipo.MostrarDatos());

            equipo[0] = j2;
            Console.WriteLine("************************************************************");
            Console.WriteLine(equipo.MostrarDatos());

            Console.ReadKey();
        }
    }
}
