using System;

namespace ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            Int32 acum = 0;
            Int32 cantVeces = 10;
            Int32 valMinimo = 0;
            Int32 valMaximo = 0;

            for (int i=0; i< cantVeces; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entre -100 y 100..\nLleva ingresados: {0} numeros",i);
                    if (int.TryParse(Console.ReadLine(), out num) && Validador.Validar(num, -100, 100))
                    {
                        break;
                    }

                    Console.WriteLine("Error, reingrese");

                } while (true);

                acum += num;

                if(i == 0)
                {
                    valMinimo = num;
                    valMaximo = num;
                }
                else
                {
                    if(valMinimo > num)
                    {
                        valMinimo = num;
                    }
                    else
                    {
                        if(valMaximo < num)
                        {
                            valMaximo = num;
                        }
                    }
                }
            }

            Console.WriteLine($"El promedio fue de {acum / (float)cantVeces}\nEl minimo fue: {valMinimo}\nEl maximo fue: {valMaximo}");
            Console.ReadKey(); 
        }
    }
}
