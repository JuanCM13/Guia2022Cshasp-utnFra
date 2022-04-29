using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        //fields
        private double cantidad;
        private static double cotRespectoAdolar;

        //constr
        static Peso()
        {          
            Peso.cotRespectoAdolar = 102.65;
        }

        public Peso(double cant)
        {
            this.cantidad = cant;
        }

        public Peso(double cant, double cotizacion) :this(cant)
        {
            Peso.cotRespectoAdolar = cotizacion;        
        }

        //methods
        public static double GetCotizacion()
        {
            return Peso.cotRespectoAdolar;
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
            Peso.cotRespectoAdolar = cot;
        }

        //operators overload

        public static explicit operator Dolar(Peso p)
        {
            Dolar ret = null;
             if(!(p is null))
             {
                ret = new Dolar(p.GetCantidad() / Peso.GetCotizacion());
             }

            return ret;
        }
        
        public static explicit operator Euro(Peso p)
        {
            Dolar dlr = (Dolar)p;
            Euro ret = null;
            if( !(dlr is null) )
            {
                ret = (Euro)dlr;
            }
            return ret;
        }

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }

        //operators 

        //== / !=

        public static bool operator ==(Peso p , Peso p1)
        {
            return p.GetCantidad() == p1.GetCantidad();
        }

        public static bool operator ==(Peso p , Dolar d)
        {
            return p == (Peso)d;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }

        public static bool operator !=(Peso p, Peso p1)
        {
            return !(p == p1);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        // + / -

        public static double operator +(Peso p, Dolar d)
        {
            return d.GetCantidad() + ((Peso)d).GetCantidad();
        }

        public static double operator +(Peso p , Euro e)
        {
            return p.GetCantidad() + ((Peso)e).GetCantidad();
        }

        public static double operator -(Peso p, Dolar d)
        {
            return p.GetCantidad() - ((Peso)d).GetCantidad();
        }

        public static double operator -(Peso p, Euro e)
        {
            return p.GetCantidad() - ((Peso)e).GetCantidad();
        }
    }
}
