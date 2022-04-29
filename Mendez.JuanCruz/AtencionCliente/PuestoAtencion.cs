using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AtencionCliente
{
    public class PuestoAtencion
    {
        private static Int32 numeroActual;
        private Puesto puesto;

        public static Int32 NumeroActual
        {
            get 
            {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
            }
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool AtenderCliente(Cliente cl)
        {
            if(!(cl is null))
            {
                Thread.Sleep(5000);
                return true;
            }
            return false;
        }
    }
}
