using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejer7";
            /*
             * Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de
             * horas trabajadas en el mes de N cantidad de empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor
            hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por 
            $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y 
            el total a cobrar neto de todos los empleados ingresados.
             */
            
            Double hora;
            String nombre;
            Int32 antiguedad;
            Double cantHoras;
            double cashTotal;
            double totalAcobrarConDescuento;
            
            do
            {
                Console.WriteLine("Ingrese el nombre del empleado..");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el precio de la hora laburada..");
                hora = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la antiguedad del empleado..");
                antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas muleadas..");
                cantHoras = double.Parse(Console.ReadLine());

                cashTotal = (cantHoras * hora) + (antiguedad * 150);

                totalAcobrarConDescuento = cashTotal - ((cashTotal * 13) / 100);

                Console.WriteLine($"Empleado: {nombre}\nHoras Trabajadas: {cantHoras}\nSueldo bruto: {cashTotal}\nSueldo Con deducciones: {totalAcobrarConDescuento}");


                Console.WriteLine("Seguimos? s/n");
                if(Console.ReadLine() != "s")
                {
                    break;
                }

            } while (true);

            Console.WriteLine("Programa finalizado");
            Console.ReadKey();
        }
    }
}
