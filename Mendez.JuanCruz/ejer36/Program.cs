using System;

namespace ejer36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejer36";

            Int32 largo = 20;
            Int32[] array = new Int32[largo];
            //String aux;

            for(Int32 i=0; i<array.Length; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero... Lleva ingresados: {0} Numeros", i);
                    if (Int32.TryParse(Console.ReadLine(), out Int32 aux))
                    {
                        array[i] = aux;
                        break;
                    }

                    Console.WriteLine("Error, ingrese un numero entero..");
                } while (true);
            }

            Console.WriteLine("\n\n****************************************");
            Console.WriteLine("Listado de numeros:");
            Console.WriteLine("****************************************");
            foreach (Int32 num in array)
            {
                Console.Write(num + "-");
            }

            Console.WriteLine("\n\n\n****************************************");
            Console.WriteLine("Listado de numeros ordenados ascendentemente:");
            Console.WriteLine("****************************************");
            Array.Sort(array);
            foreach (Int32 num in array)
            {
                Console.Write(num + "-");
            }

            Console.WriteLine("\n\n\n****************************************");
            Console.WriteLine("Listado de numeros ordenados descendentemente:");
            Console.WriteLine("****************************************");
            Array.Reverse(array);
            foreach (Int32 num in array)
            {
                Console.Write(num + "-");
            }


            Console.ReadKey();
        }
    }
}
