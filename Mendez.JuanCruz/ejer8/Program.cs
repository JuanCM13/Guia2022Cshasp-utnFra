using System;

namespace ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejer8";
            Int32 cantVeces;
            Int32 guia = 0;

            do
            {
                Console.WriteLine("Ingrese la cantidad de escalones de la torre...");
                if(int.TryParse(Console.ReadLine() , out cantVeces) && cantVeces > 0)
                {
                    break;
                }

                Console.WriteLine("Error..");

            } while (true);
            

            for(int i=0; i<cantVeces; i++)
            {
                if(i == 0)
                {
                    guia = 1;
                }
                else
                {
                    guia += 2;
                }

                for(int j=0; j<guia; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }
            
            Console.ReadKey();
        }
    }
}
