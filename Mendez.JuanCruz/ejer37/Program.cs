using System;
using System.Collections.Generic;

namespace ejer37
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Carga en list, la ordeno, recorro la lista y cargo la pila y la cola
             * .los positivos descendentes los muestro con la pila (lifo), asi como se cargan de menor a mayor
             y la pila recorre del ultimo al primero, filtro los positivos y los muestra ordenados.
            
             .los negativos ascendentes los muestro con la cola (fifo), como se cargan de menor a mayor
            filtro los negativos y los muestra ordenados*/

            Console.Title = "Ejer37";

            List<Int32> listado = new List<Int32>();
            Queue<Int32> cola = new Queue<Int32>();
            Stack<Int32> pila = new Stack<int>();

            listado.Add(-15);
            listado.Add(145);
            listado.Add(-35);
            listado.Add(4756);
            listado.Add(333);
            listado.Add(458);
            listado.Add(412);
            listado.Add(1);
            listado.Add(22);
            listado.Add(16);
            listado.Add(423);
            listado.Add(123);
            listado.Add(113);

            Console.WriteLine("***************************************************************");
            Console.WriteLine("Lista: ");
            Console.WriteLine("***************************************************************");
            foreach (Int32 item in listado)
            {
                Console.Write(item + "-");
            }
            listado.Sort();


            foreach (Int32 item in listado)
            {
                cola.Enqueue(item);
                pila.Push(item);
            }

            Console.WriteLine("\n\n\n***************************************************************");
            Console.WriteLine("Positivos Descendentemente: ");
            Console.WriteLine("***************************************************************");
            foreach(Int32 item in pila)
            {
                if(item > 0)
                {
                    Console.Write(item + "-");
                }
            }

            Console.WriteLine("\n\n\n***************************************************************");
            Console.WriteLine("Negativos Ascendentemente: ");
            Console.WriteLine("***************************************************************");
            foreach (Int32 item in cola)
            {
                if (item < 0)
                {
                    Console.Write(item + "-");
                }
            }

            Console.ReadKey();
        }
    }
}