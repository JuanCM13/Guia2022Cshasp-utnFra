using System;

using EnciendanSusMotores;
namespace ejer40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer40";
            Competencia c1 = new Competencia(4, 5);
            Competencia c2 = null;
            AutoF1 a1 = new AutoF1(1, "Ferrari");
            AutoF1 a2 = new AutoF1(2, "Aston");
            AutoF1 a3 = new AutoF1(3, "Renault");
            AutoF1 a4 = new AutoF1(1, "Ferrari");
            AutoF1 a5 = new AutoF1(4, "Red Bull");

            bool aux = c1 + a1;
            aux = c1 + null;
            aux = c1 + a2;
            aux = c1 + a2;
            aux = c1 + a3;
            aux = c1 + a4;
            aux = c1 + a5;

            aux = c2 + a1;

            Console.WriteLine(c1.MostrarDatos());


            Console.ReadKey();
        }
    }
}
