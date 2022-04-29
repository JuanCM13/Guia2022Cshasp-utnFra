using System;

using CamionerosMoyano;
namespace ejer24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio A01 - Vienen con sistema de auto-navegación*/
            Console.Title = "Ejer24";
            //Int32 largoLista = 3; El array termine haciendolo en otra clase, e hice una lista dentro de esa, donde asigno         
            //Camionero[] lista = new Camionero[largoLista]; camioneros

            EmpresaCamiones empresaCoviella = new EmpresaCamiones("Coviella");
            Camionero carlitos = new Camionero("Carlos");
            Camionero pepe = new Camionero("Pepe");
            Camionero jose = new Camionero("Jose");

            /*lista[0] = carlitos;
            lista[1] = pepe;
            lista[2] = jose;*/

            //Prueba para ver si funcionan filtros si la lista llega a estar vacia
            //Console.WriteLine(empresaCoviella.MostrarChoferConMasKilometros());
            //Console.WriteLine(empresaCoviella.MostrarData());

            empresaCoviella.AgregarCamionero(carlitos);
            empresaCoviella.AgregarCamionero(jose);
            empresaCoviella.AgregarCamionero(pepe);

            //Prueva para ver si funcionan filtros si la lista tiene choferes, pero estos choferes no tienen datos cargados
            //Console.WriteLine(empresaCoviella.MostrarChoferConMasKilometros());
            //Console.WriteLine(empresaCoviella.MostrarData());

            carlitos.SetKilometrosDia(1, 400);
            carlitos.SetKilometrosDia(2, 500);
            carlitos.SetKilometrosDia(3, 320);
            carlitos.SetKilometrosDia(4, 410);
            carlitos.SetKilometrosDia(5, 0);
            carlitos.SetKilometrosDia(6, 0);
            carlitos.SetKilometrosDia(7, 600);

            pepe.SetKilometrosDia(1, 150);
            pepe.SetKilometrosDia(2, 45);
            pepe.SetKilometrosDia(3, 0);
            pepe.SetKilometrosDia(4, 360);
            pepe.SetKilometrosDia(5, 0);
            pepe.SetKilometrosDia(6, 15);
            pepe.SetKilometrosDia(7, 1200);

            jose.SetKilometrosDia(1, 440);
            jose.SetKilometrosDia(2, 210);
            jose.SetKilometrosDia(3, 100);
            jose.SetKilometrosDia(4, 0);
            jose.SetKilometrosDia(5, 3);
            jose.SetKilometrosDia(6, 320);
            jose.SetKilometrosDia(7, 100);

            //PRUEBA DE FUNCIONALIDADES, PARA VER SI TODO FUNCA OKEY, DESCOMENTAR Y EJECUTAR...
            /* Console.WriteLine("---------------------------------------------------\n");
             Console.WriteLine(carlitos.MostrarData());
             Console.WriteLine("---------------------------------------------------\n");
             Console.WriteLine(pepe.MostrarData());
             Console.WriteLine("---------------------------------------------------\n");
             Console.WriteLine(jose.MostrarData());
             Console.WriteLine("---------------------------------------------------\n");

             PRUEBA DE KILOMETROS SEMANALES Y POR DIA, ANDA DE 10
             Console.WriteLine("Carlitos:\nSemanales: " + carlitos.KilometrosRecorridos());
             Console.WriteLine("Dia 4: " + carlitos.KilometrosRecorridos(4));

             Console.WriteLine("---------------------------------------------------\n");

             Console.WriteLine("Jose:\nSemanales: " + jose.KilometrosRecorridos());
             Console.WriteLine("Dia 4: " + jose.KilometrosRecorridos(4));

             Console.WriteLine("---------------------------------------------------\n");

             Console.WriteLine("Pepe:\nSemanales: " + pepe.KilometrosRecorridos());
             Console.WriteLine("Dia 4: " + pepe.KilometrosRecorridos(4));

             Console.WriteLine("---------------------------------------------------\n");*/

            Console.WriteLine(empresaCoviella.MostrarChoferConMasKilometros());//chofer que recorrio mas kilometros x semana
            Console.WriteLine(empresaCoviella.MostrarChoferConMasKilometros(3)); //chofer que recorrio mas kilometros x dia
            Console.WriteLine(empresaCoviella.MostrarChoferConMasKilometros(5)); //chofer que recorrio mas kilometros x dia
            Console.WriteLine(empresaCoviella.MostrarData()); //muestro toda la data de todos los choferes, toda la semana
            Console.WriteLine(empresaCoviella.MostrarData(1)); //muestro toda la data de todos los choferes, en x dia
            Console.ReadKey();
        }
    }
}
