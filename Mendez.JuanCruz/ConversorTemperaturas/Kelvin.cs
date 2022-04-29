using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class Kelvin
    {
        private double cantidadGrados;

        public Kelvin(double cant)
        {
            this.CantidadGrados = cant;
        }

        public double CantidadGrados
        {
            get { return this.cantidadGrados; }
            private set { this.cantidadGrados = value; }
        }

        public static implicit operator Kelvin(double cant)
        {
            return new Kelvin(cant);
        }

        public static implicit operator double(Kelvin k)
        {
            return k.CantidadGrados;
        }

        public static implicit operator String(Kelvin k)
        {
            return k.CantidadGrados.ToString("#,#.00");
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            double aux = k.CantidadGrados * 9 / 5 - 459.67;
            return aux;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Fahrenheit auxF = (Fahrenheit)k;
            return (Celsius)auxF;
        }

        // K == K
        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            bool ret = false;

            if (!(k1 is null) && !(k2 is null))
            {
                if (k1.CantidadGrados == k2.CantidadGrados)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        // K == F
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return f == k;
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        // K == C
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return c == k;
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        // K + K

        public static Kelvin operator +(Kelvin k1 , Kelvin k2)
        {
            Kelvin ret = null;
            if(!(k1 is null) && !(k2 is null))
            {
                ret = k1.CantidadGrados + k2.CantidadGrados;
            }
            return ret;
        }

        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            Kelvin ret = null;
            if (!(k1 is null) && !(k2 is null))
            {
                ret = k1.CantidadGrados - k2.CantidadGrados;
            }
            return ret;
        }

        // K + F

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return (Kelvin)(f + k);
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return (Kelvin)(f - k);
        }

        // K + C

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return (Kelvin)(c + k);
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return (Kelvin)(c - k);
        }
    }
}
