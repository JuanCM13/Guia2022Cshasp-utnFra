using System;

namespace ConversorTemperaturas
{
    public class Celsius
    {
        private double cantidadGrados;

        public Celsius(double cant)
        {
            this.CantidadGrados = cant;
        }

        public double CantidadGrados
        {
            get { return this.cantidadGrados; }
            private set { this.cantidadGrados = value; }
        }

        public static implicit operator Celsius(double cant)
        {
            return new Celsius(cant);
        }

        public static implicit operator double(Celsius c)
        {
            return c.CantidadGrados;
        }

        public static implicit operator String(Celsius c)
        {
            return c.CantidadGrados.ToString("#,#.00");
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            double aux = c.CantidadGrados * (9 / (float)5) + 32;
            Fahrenheit ret = aux;
            return ret;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Fahrenheit auxF = (Fahrenheit)c;
            return (Kelvin)auxF;
        }

        // C == C
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            bool ret = false;

            if (!(c1 is null) && !(c2 is null))
            {
                if (c1.CantidadGrados == c2.CantidadGrados)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }

        // C == f

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return f == c;
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        // C == K
        public static bool operator ==(Celsius c, Kelvin k)
        {
            bool ret = false;
            if (!(k is null))
            {
                ret = c == (Celsius)k;
            }
            return ret;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        // C + C

        public static Celsius operator +(Celsius c1 , Celsius c2)
        {
            Celsius ret = null;
            if(!(c1 is null) && !(c2 is null))
            {
                ret = c1.CantidadGrados + c2.CantidadGrados;
            }
            return ret;
        }

        public static Celsius operator -(Celsius c1, Celsius c2)
        {
            Celsius ret = null;
            if (!(c1 is null) && !(c2 is null))
            {
                ret = c1.CantidadGrados - c2.CantidadGrados;
            }
            return ret;
        }

        // C + F

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return (Celsius)(f + c);
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            Celsius ret = null;
            if (!(c is null) && !(f is null))
            {
                ret = (Celsius)(f - c);
            }
            return ret;
        }

        // C + K

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            Celsius ret = null;
            if (!(c is null) && !(k is null))
            {
                ret = c + (Celsius)k;
            }
            return ret;
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            Celsius ret = null;
            if (!(c is null) && !(k is null))
            {
                ret = c - (Celsius)k;
            }
            return ret;
        }
    }
}
