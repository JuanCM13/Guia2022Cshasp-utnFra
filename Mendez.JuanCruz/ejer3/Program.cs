using System;

namespace ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
               Validar que el dato ingresado por el usuario sea un número.
               Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
               Si ingresa "salir", cerrar la consola.
               Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
             */

            Console.Title = "Ejer3";
            String aux = "";
            Int32 num = -2; //si no lo setteo no me lo corre
            Int32 counter;
            do
            {
                Console.WriteLine("Ingrese un numero, positivo...");
                aux = Console.ReadLine();

                if (aux == "salir" || int.TryParse(aux, out num) && num > 0)
                {
                    break;
                }

                Console.WriteLine("Error, reingrese");

            } while (true);

            int controler;
            for (int i = 1; i <= num; i++)
            {
                counter = 1;
                controler = i;
                for (int j=controler; j>1 ; j--)
                {
                    if(controler % j == 0)
                    {
                        counter++;
                        if(counter > 2)
                        {
                            break; //rompo asi no sigue calculando al dope
                        }
                    }
                }

                if (counter == 2)
                {
                    Console.WriteLine($"El numero: {controler}, es primo");
                }
            }
            Console.WriteLine("Programa terminado");
            Console.ReadKey();
        }
    }
}
