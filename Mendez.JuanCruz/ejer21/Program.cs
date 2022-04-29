using System;

namespace ejer21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer21";
            Estudiante al1 = new Estudiante("Perez" , "0012345" , "Juan");
            Estudiante al2 = new Estudiante("Villalba", "0012356", "Federico");
            Estudiante al3 = new Estudiante("Gomez", "0012367", "Paula");

            al1.SetNotaPrimerParcial(1);
            al1.SetNotaSegundoParcial(10);

            al2.SetNotaPrimerParcial(10);
            al2.SetNotaSegundoParcial(8);

            al3.SetNotaPrimerParcial(4);
            al3.SetNotaSegundoParcial(4);

            Console.WriteLine(al1.Mostrar());
            Console.WriteLine(al2.Mostrar());
            Console.WriteLine(al3.Mostrar());

            Console.ReadKey();
        }
    }
}
