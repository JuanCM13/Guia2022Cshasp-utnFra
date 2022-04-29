using System;

namespace Billetes
{
    public class Dolar
    {
        //fields
        private double cantidad;
        private static double cotRespectoAdolar;

        //constr
        static Dolar()
        {
            Dolar.cotRespectoAdolar = 1;
        }

        public Dolar(double cant)
        {
            this.cantidad = cant;
        }

        //methods
        public static double GetCotizacion()
        {
            return Dolar.cotRespectoAdolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        //operators overload

        public static explicit operator Euro(Dolar d)
        {
            Euro ret = null;
            if( !(d is null))
            {
                ret = new Euro( Euro.GetCotizacion() * d.GetCantidad() );
            }
            return ret;
        }

        public static explicit operator Peso(Dolar d)
        {
            Peso ret = null;
            if( !(d is null) )
            {
                ret = new Peso(Peso.GetCotizacion() * d.GetCantidad());
            }
            return ret;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        //operators 

        // == / !=
        
        public static bool operator ==(Dolar d , Dolar d1)
        {
            return d.GetCantidad() == d1.GetCantidad();
        }

        public static bool operator ==(Dolar d , Euro e)
        {
            return d == (Dolar)e;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d == (Dolar)p;
        }

        public static bool operator !=(Dolar d, Dolar d1)
        {
            return !(d == d1);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d , Peso p)
        {
            return !(d == p);
        }

        // + / -

        public static double operator +(Dolar d , Peso p)
        {
            return d.GetCantidad() + ((Dolar)p).GetCantidad();
        }

        public static double operator +(Dolar d, Euro e)
        {
            return d.GetCantidad() + ((Dolar)e).GetCantidad();
        }

        public static double operator -(Dolar d , Peso p)
        {
            return d.GetCantidad() - ((Dolar)p).GetCantidad();
        }

        public static double operator -(Dolar d, Euro e)
        {
            return d.GetCantidad() - ((Dolar)e).GetCantidad();
        }
    }
}
