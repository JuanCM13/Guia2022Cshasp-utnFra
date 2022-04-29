using System;
using Laavadero;

namespace Parcial_1_2016_LavaderoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parcial 1 - Laboratorio 2 - 2016";

            Lavadero lav1 = new Lavadero( 150.25F , 250.60F, 100.50F);
            Lavadero lav2 = new Lavadero(200 , 200 , 200); //lavadero vacio de prueba
            Auto auto1 = new Auto("FA256", 4, EMarcas.Honda, 25); //tendria que mostrarme 5 asientos...
            Auto auto2 = new Auto("JS150", 50, EMarcas.Ford, 6); //tendria que mostrarme 4 ruedas...
            Camion camion1 = new Camion("CA458", 14, EMarcas.Scania, -50); //tendria que mostrarme el standard de tara
            Camion camion2 = new Camion("CA675", 10, EMarcas.Iveco, 25000);
            Moto moto1 = new Moto("MS124", 2, EMarcas.Zanella, 8000); //tendria que mostrarme el standard de cilindrada
            Moto moto2 = new Moto("MS800", 4, EMarcas.Honda, 350);

            //pruebas para ver si no toma repetidos:
            Auto auto3 = new Auto("FA256", 4, EMarcas.Honda, 25); //tendria que mostrarme 5 asientos...
            Moto moto3 = new Moto("MS124", 2, EMarcas.Zanella, 8000); //tendria que mostrarme el standard de cilindrada

            //prueba de agregado de vehiculos
            lav1 += auto1;
            lav1 += auto2;
            lav1 += auto3; //no tiene que tomarlo
            lav1 += camion1;
            lav1 += camion2;
            lav1 += moto1;
            lav1 += moto2;
            lav1 += moto3; //no tiene que tomarlo

            Console.WriteLine("\n********************************************************************");
            Console.WriteLine("Muestro elementos cargados, tendrian que ser 6, todos menos moto3 y auto3");
            Console.WriteLine("********************************************************************");
            Console.WriteLine(lav1); //aca llamo al ToString sobrecargado

            Console.WriteLine("\n********************************************************************");
            Console.WriteLine("Muestro ganancias totales y por tipo de vehiculo\nTendria que dar total: 1.002,7");
            Console.WriteLine("********************************************************************");
            
            Console.WriteLine("\n\nTotal:");
            Console.WriteLine("-" + lav1.MostrarTotalFacturado());

            Console.WriteLine("\n\nPor autos");
            Console.WriteLine("- " + lav1.MostrarTotalFacturado(EVehiculos.Auto) + " -");

            Console.WriteLine("\n\nPor camiones");
            Console.WriteLine("- " + lav1.MostrarTotalFacturado(EVehiculos.Camion) + " -");

            Console.WriteLine("\n\nPor motos");
            Console.WriteLine("- " + lav1.MostrarTotalFacturado(EVehiculos.Moto) + " -");

            Console.WriteLine("\n********************************************************************");
            Console.WriteLine("Ordenamiento de listas: ");
            Console.WriteLine("********************************************************************");

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Por marcas");
            Console.WriteLine("********************************************************************");
            lav1.Vehiculos.Sort(lav1.OrdenarVehiculosPorMarca);
            Console.WriteLine(lav1);

            Console.WriteLine("********************************************************************");
            Console.WriteLine("Por patentes");
            Console.WriteLine("********************************************************************");
            lav1.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(lav1);

            Console.WriteLine("\n********************************************************************");
            Console.WriteLine("Eliminado de vehiculos: Solo tendrian que figurar Auto2, Camion1 y Moto2");
            Console.WriteLine("********************************************************************");

            lav1 -= auto1;
            lav1 -= camion2;
            lav1 -= moto1;
            Console.WriteLine(lav1);

            Console.WriteLine("\n********************************************************************");
            Console.WriteLine("Lavadero vacio, no tendria que romper sino no mostrar los datos de vehiculos..");
            Console.WriteLine("********************************************************************");
            Console.WriteLine(lav2);

            Console.ReadKey();
        }
    }
}
