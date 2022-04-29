using System;

namespace ejer19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio I01 - Creo que necesito un préstamo
             */
            Console.Title = "Ejer19";
            //-----------
            Cuenta anibal = new Cuenta("Anibal",180000);
            Cuenta sandro = new Cuenta("Sandro", 60000);

            Console.WriteLine(anibal.Mostrar());
            Console.WriteLine(sandro.Mostrar());


            //----------TEST INGRESOS
            anibal.Ingresar(20000);
            sandro.Ingresar(40000);

            Console.WriteLine(anibal.Mostrar());
            Console.WriteLine(sandro.Mostrar());

            //---------TEST RETIRO
            anibal.Retirar(200001);
            sandro.Retirar(59000);
            
            Console.WriteLine(anibal.Mostrar());
            Console.WriteLine(sandro.Mostrar());

            //--------TEST INGRESO UNO SOLO
            anibal.Ingresar(150);

            Console.WriteLine(anibal.Mostrar());
            Console.WriteLine(sandro.Mostrar());

            Console.ReadKey();
        }
    }
}
