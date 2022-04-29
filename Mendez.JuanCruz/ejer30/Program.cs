using System;

using ConversorTemperaturas;
namespace ejer30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversor de temp
            Console.Title = "Ejer30";

            Fahrenheit fah = 350;
            Celsius cel = 420;
            Kelvin kel = 255;

            Console.WriteLine($"350ºF a celcius es: {((Celsius)fah).CantidadGrados} y a kel es: {((Kelvin)fah).CantidadGrados}");
            Console.WriteLine($"420ºC a fahrenheit es: {((Fahrenheit)cel).CantidadGrados} y a kel es: {((Kelvin)cel).CantidadGrados}");
            Console.WriteLine($"255ºK a fahrenheit es: {((Fahrenheit)kel).CantidadGrados} y a celsius es: {((Celsius)kel).CantidadGrados}");

            Console.WriteLine($"350ºF + 420ºC es: {(fah + cel).CantidadGrados} Fahrenheit y {(cel + fah).CantidadGrados} Centigrados");
            Console.WriteLine($"420ºC + 255ºK es: {(cel + kel).CantidadGrados} Celsius y {(kel + cel).CantidadGrados} Kelvin");

            Console.ReadKey();
        }
    }
}
 