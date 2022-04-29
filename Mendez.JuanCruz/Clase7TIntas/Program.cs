using System;

using EntidadesTinta;
namespace Clase7TIntas
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMER PARTE

            Tempera t1 = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera t2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera t3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera t4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera t5 = new Tempera(ConsoleColor.Green, "Temperita", 50);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Comparaciones");
            Console.WriteLine("**************************************************************");

            bool ret = t1 == t2;
            Console.WriteLine("T1 y T2 tendria que dar falso: \n{0}", ret);

            ret = t1 == t3;
            Console.WriteLine("T1 y T3 tendria que dar true: \n{0}", ret);

            ret = t1 == t4;
            Console.WriteLine("T1 y T4 tendria que dar false: \n{0}", ret);

            ret = t1 == null;
            Console.WriteLine("T1 y null tendria que dar false: \n{0}", ret);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Sumas");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("T1 + T2 tendria que dar T1, osea: red , alba , 50 \n{0}", Tempera.Mostrar((t1 + t2)) );
            Console.WriteLine("T1 + T3 tendria que dar red , alba , 75 \n{0}", Tempera.Mostrar((t1 + t3)));
            Console.WriteLine("T1 + T4 tendria que dar T1, osea: red , alba , 50 \n{0}", Tempera.Mostrar((t1 + t4)));
            Console.WriteLine("T1 + NULL tendria que dar T1: osea: red , alba , 50 \n{0}", Tempera.Mostrar((t1 + null)) );
            //Console.WriteLine("Hello World!");

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Sumas Tinta + Int");
            Console.WriteLine("**************************************************************");

            Int32 resultado = (t1 + 20); //para ver si funca la conversion implicita que devuelve cantidad
            Console.WriteLine("T1 + 30 tendria que dar 70: {0}", resultado);

            resultado = (t2 + 30); //para ver si funca la conversion implicita que devuelve cantidad
            Console.WriteLine("T2 + 30 tendria que dar 80: {0}", resultado);

            //SEGUNDA PARTE

            Paleta paletita = 3;

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Comparacion Paleta con Tinta");
            Console.WriteLine("**************************************************************");

            ret = paletita == t1; //tendria que dar falso por que por ahora la lista esta vacia
            Console.WriteLine("paletita == t1 tendria que dar false: {0}", ret);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Sumar Paleta con Tinta");
            Console.WriteLine("**************************************************************");

            paletita = paletita + t1;
            paletita = paletita + t2;
            paletita = paletita + t3;
            paletita = paletita + t4;
            paletita = paletita + t5;

            Console.WriteLine($"Tendria que tirarme agregarme 3, uno de esos lo suma en t1 y queda uno sin agregar por que supera" +
                                    $"el maximo de cantidad: \n{(String)paletita}");

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Restar Tintas de Paleta");
            Console.WriteLine("**************************************************************");

            paletita = paletita - t1;
            paletita = paletita - t2;
            paletita = paletita - t5;

            Console.WriteLine($"Tendria que restarle, al t1 el t1, quedaria en 25 y eliminar el t2: \n{(String)paletita}");

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Creacion y suma de las 2 paletas");
            Console.WriteLine("**************************************************************");

            Paleta paletita2 = 2;

            paletita2 = paletita2 + t5;
            paletita2 = paletita2 + t4;
            paletita2 = paletita2 + t3;
            paletita2 = paletita2 + t2;

            Console.WriteLine($"Paletita 2: \n{(String)paletita2}");

            Console.WriteLine($"Suma de paletita1 y paletita2, quedaria t1 igual, t4 igual, t3 igual, t2 igual y t5 agregando mas tinta..: \n{ (String)(paletita + paletita2) }");

            /*Funca perfecto scelente*/

            Console.ReadKey();
        }
    }
}
