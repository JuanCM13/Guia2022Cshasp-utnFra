using System;

using EjerIntegrador;
namespace EjercicioIntegrador_2020_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Apellido y Nombre";//Cambiar por SU apellido y  SU nombre
            Cliente mauri = new Cliente(eTipoCliente.PoliticoCorrupto,"Mauri");
            Cliente fariña = new Cliente(eTipoCliente.Financista, "Fariña");
            Cliente mesias = new Cliente(eTipoCliente.JugadorDeFutbol,"Lio");
            CuentaOffShore messiOff = new CuentaOffShore(mesias, 123, 15000);
            CuentaOffShore mauriOff = new CuentaOffShore(mauri, 678, 25000);
            CuentaOffShore lazaroOff = new CuentaOffShore("Lázaro",eTipoCliente.EmpresarioCorructo, 456, 56000);
            CuentaOffShore otraDeMauri = new CuentaOffShore(mauri, 678,50000);
            CuentaOffShore fariOff = new CuentaOffShore(fariña, 666, 3500);
            ParaisoFiscal panamaPappers = eParaisosFiscales.Panama;
            panamaPappers += messiOff;
            panamaPappers += mauriOff;
            panamaPappers += lazaroOff;

            Console.WriteLine("------------------Cargados-----------------------");
            Console.WriteLine(panamaPappers.MostrarParaiso());
            panamaPappers += otraDeMauri;
            panamaPappers -= messiOff;
            panamaPappers -= fariOff;
            Console.WriteLine("------------------Listado sacando los eliminados..-----------------------");
            Console.WriteLine(panamaPappers.MostrarParaiso());
            Console.ReadLine();
        }
    }
}
