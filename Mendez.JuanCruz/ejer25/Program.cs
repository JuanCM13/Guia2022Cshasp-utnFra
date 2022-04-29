using System;
using Veterinaria;

namespace ejer25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio A02 - La veterinaria*/
            Console.Title = "Ejer25";
            Int32 largoLista = 3;
            Dueño[] listaVeterinario = new Dueño[largoLista];

            Dueño d1 = new Dueño("Jorge" , 42473455);
            Dueño d2 = new Dueño("Pepe", "Calle Falsa 123", 42524798);
            Dueño d3 = new Dueño("Sara", "Calle recontra false 123", 1533458874);
            Mascota m1 = new Mascota("Firu", Mascota.MascotaTipo.Perro, new DateTime(2021, 01, 20));
            Mascota m2 = new Mascota("Don", Mascota.MascotaTipo.Gato, new DateTime(2015, 11, 23));
            Mascota m3 = new Mascota("Peep", Mascota.MascotaTipo.Perro, new DateTime(2009, 05, 13));
            Mascota m4 = new Mascota("Vito", Mascota.MascotaTipo.Gato, new DateTime(2011, 08, 31));

            m2.SetVacuna("Triple Felina");
            m4.SetVacuna("Vacuna Contra Rabia");

            //prueba para ver como reacciona el dueño sin mascotas 
            Console.WriteLine(d1.Mostrar());
            Console.WriteLine(d2.Mostrar());
            Console.WriteLine(d3.Mostrar());

            d1.AddMascota(m1);
            d2.AddMascota(m2);
            d3.AddMascota(m3);
            d3.AddMascota(m4);

            listaVeterinario[0] = d1;
            listaVeterinario[1] = d2;
            listaVeterinario[2] = d3;
            
            foreach(Dueño aux in listaVeterinario)
            {
                Console.WriteLine(aux.Mostrar());
            }

            Console.ReadKey();
        }
    }
}
