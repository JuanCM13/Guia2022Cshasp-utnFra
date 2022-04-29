using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        //fields
        private double cantidad;
        private static double cotRespectoAdolar;

        //constr
        static Euro()
        {
            Euro.cotRespectoAdolar = 1.17;
        }

        public Euro(double cant)
        {
            this.cantidad = cant;
        }

        public Euro(double cant, double cotizacion) : this(cant)
        {
            Euro.cotRespectoAdolar = cotizacion;
        }

        //methods
        public static double GetCotizacion()
        {
            return Euro.cotRespectoAdolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        /*
         * Metodo agregado del ejercicio 3 win forms       
         */

        public static void SetCotizacion(double cot)
        {
            Euro.cotRespectoAdolar = cot;
        }

        //operators explicit/implicit overload
        public static explicit operator Dolar(Euro e)
        {
            Dolar ret = null;
            if (!(e is null))
            {
                ret = new Dolar(e.GetCantidad() / Euro.GetCotizacion());
            }

            return ret;
        }

        public static explicit operator Peso(Euro e)
        {
            Dolar dlr = (Dolar)e;
            Peso ret = null;
            if( !(dlr is null) )
            {
                ret = (Peso)dlr;
            }
            return ret;
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        //operators 

        //== / !=

        public static bool operator ==(Euro e , Euro e1)
        {
            return e.GetCantidad() == e1.GetCantidad();
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }

        public static bool operator !=(Euro e, Euro e1)
        {
            return !(e == e1);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Peso p1)
        {
            return !(e == p1);
        }

        // + / -

        public static double operator +(Euro e, Dolar d)
        {
            return e.GetCantidad() + ((Euro)d).GetCantidad();
        }

        public static double operator +(Euro e, Peso p)
        {
            return e.GetCantidad() + ((Euro)p).GetCantidad();
        }

        public static double operator -(Euro e, Dolar d)
        {
            return e.GetCantidad() - ((Euro)d).GetCantidad();
        }

        public static double operator -(Euro e, Peso p)
        {
            return e.GetCantidad() - ((Euro)p).GetCantidad();
        }
    }
}
