using System;

namespace ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //snipset o algo asi, cw y tab y me arma el writeLine
            /*
             * Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
             * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje:
             * "ERROR. ¡Reingresar número!".
             */
            Console.Title = "Ejer2";
            Int32 num;
            Int32 cuadrado;
            Int32 cubo;
            String aux;

            do
            {
                Console.WriteLine("Ingrese 1 numero mayor a cero...");
                aux = Console.ReadLine();

                if(int.TryParse(aux ,out num) && num > 0)
                {
                    break;
                }
                Console.WriteLine("Error, Reingrese!!");
            } while (true);

            cuadrado = (int) Math.Pow(num, 2);
            cubo = (int) Math.Pow(num, 3);

            Console.WriteLine($"El numero ingresado fue {num}\nSu cuadrado es: {cuadrado}\nSu cubo es: {cubo}");
            Console.ReadKey();
        }
    }
}
