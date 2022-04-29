using System;

namespace ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejer9";
            Int32 cantVeces;
            Int32 guia = 0;
            Int32 cantEspacios;

            do
            {
                Console.WriteLine("Ingrese la cantidad de escalones de la torre...");
                if (int.TryParse(Console.ReadLine(), out cantVeces) && cantVeces > 0)
                {
                    break;
                }

                Console.WriteLine("Error..");

            } while (true);


            cantEspacios = (cantVeces*10) -1; //*10 para que no quede en el margen izquierdo, le agrego bastantes espacios
            for (int i = 0; i < cantVeces; i++)
            {
                if (i == 0)
                {
                    guia = 1;
                }
                else
                {
                    guia += 2;
                    cantEspacios--;
                }
                
                for (int c = 0; c < cantEspacios; c++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < guia; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
