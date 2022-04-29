using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    class Tablas
    {
        public static string CalcularTablas(Int32 num)
        {
            StringBuilder str = new StringBuilder();
            Int32 calculado;

            for(int i=1; i<=9; i++)
            {
                calculado = num * i;
                str.AppendLine($"{num} * {i} = {calculado}");
            }

            return str.ToString();
        }
    }
}
