using System;

using ConversorBinarioDecimalRecargado;
namespace ejer28
{
    class Program
    {
        static void Main(string[] args)
        {
            Binario bin = "10110010";
            Deecimal dec = 4576;

            Console.WriteLine((String)bin);
            Console.WriteLine((Double)dec);

            Console.WriteLine(((String)(Binario)dec));
            Console.WriteLine(((Double)(Deecimal)bin));

            Console.WriteLine("10110010 + 4576 da: decimal: "+ (Double)(dec + bin));
            Console.WriteLine("10110010 + 4576 da: binario: " + (String)(bin + dec));
        }
    }
}
