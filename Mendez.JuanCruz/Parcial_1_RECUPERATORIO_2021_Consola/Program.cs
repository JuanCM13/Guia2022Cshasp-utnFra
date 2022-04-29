using System;
using Entidades;

namespace Parcial_1_RECUPERATORIO_2021_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parcial2021Recuperatorio";

            Deposito miDeposito = 7;
            Fabricante f1 = new Fabricante("Samsung", EPais.Corea);
            Fabricante f2 = new Fabricante("Huawei", EPais.China);

            Televisor t1 = new Televisor("LED 4K", "Philips", EPais.Holanda, ETipo.Led);
            Televisor t2 = new Televisor("Plasma 2000", "Noblex", EPais.Argentina, ETipo.Plasma);
            Televisor t3 = new Televisor("LED 4K", "Philips", EPais.Holanda, ETipo.Tubo);
            Televisor t4 = new Televisor("LED 4K", "Philips", EPais.Holanda, ETipo.Led);
            Celular c1 = new Celular("A6", f1, EGama.Media);
            Celular c2 = new Celular("A20", f2, EGama.Alta);
            Celular c3 = new Celular("A20", f2, EGama.Baja);
            Celular c4 = new Celular("Iphone 12", new Fabricante("Apple", EPais.USA), EGama.Alta);
            Celular c5 = new Celular("A20", f1, EGama.Alta);
            miDeposito += c1;
            //YA INGRESADO
            miDeposito += c1;
            miDeposito += t1;
            miDeposito += t2;
            miDeposito += t3;
            miDeposito += c2;
            miDeposito += c3;
            //YA INGRESADO
            miDeposito += t4;
            miDeposito += c4;
            //SIN LUGAR
            miDeposito += c5;
            Console.WriteLine(Deposito.Mostrar(miDeposito));
            Console.ReadLine();
        }
    }
}
