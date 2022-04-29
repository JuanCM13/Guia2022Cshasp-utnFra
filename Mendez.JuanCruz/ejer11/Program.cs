using System;

namespace ejer11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer11";
            Int32 acum = 0;
            Int32 num;

            do
            {
                Console.WriteLine("Ingrese un numero...");
                if(int.TryParse(Console.ReadLine() , out num))
                {
                    acum += num;
                    Console.WriteLine("Ingresamos otro? s/n");
                    if(Validador.ValidarRespuesta(Console.ReadLine()) == false)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Error..");
                }

            } while (true);
            Console.WriteLine("Acumulado: {0}", acum);
            Console.ReadKey();
        }
    }
}
