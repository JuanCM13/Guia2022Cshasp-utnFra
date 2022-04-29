using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
{
    class CalculadorDias
    {
        public static int DiasRestantes(DateTime fechaAcalcular)
        {
            DateTime fechaActual = DateTime.Now;

            return (fechaActual - fechaAcalcular).Days;
        }
    }
}
