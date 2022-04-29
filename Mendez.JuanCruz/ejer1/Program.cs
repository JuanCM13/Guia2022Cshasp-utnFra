using System;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Consigna#
            Ingresar 5 números por consola, guardándolos en una variable escalar. 
            Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            */
            Console.Title = "Ejer1";
            string aux;
            Int32 num;
            Int32 max = 0;
            Int32 min = 0;
            Int32 acum = 0;
            Double prom = 0;
            Int32 tam = 5;

            for(int i=0; i<tam; i++)
            {
                Console.WriteLine("Ingrese 1 numero..");
                aux = Console.ReadLine();
                if(int.TryParse(aux, out num))
                {
                    if(i==0)
                    {
                        max = num;
                        min = num;
                    }
                    else
                    {
                        if(min > num)
                        {
                            min = num;
                        }
                        else
                        {
                            if(max < num)
                            {
                                max = num;
                            }
                        }
                    }
                }
                acum += num;
            }

            if(tam > 0)
            {
                prom = acum / (float)tam;
            }

            Console.WriteLine($"El numero maximo fue: {max}\nEl minimo fue: {min}\nEl promedio dio: {prom.ToString("#.##")}");
            Console.ReadKey();
        }
    }
}
