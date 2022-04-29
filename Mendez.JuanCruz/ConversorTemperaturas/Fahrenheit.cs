using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    public class Fahrenheit
    {
        private double cantidadGrados;

        public Fahrenheit(double cant)
        {
            this.CantidadGrados = cant;
        }

        public double CantidadGrados
        {
            get { return this.cantidadGrados; }
            private set { this.cantidadGrados = value; }
        }

        public static implicit operator Fahrenheit(double cant)
        {
            return new Fahrenheit(cant);
        }

        public static implicit operator double(Fahrenheit f)
        {
            return f.CantidadGrados;
        }

        public static implicit operator String(Fahrenheit f)
        {
            return f.CantidadGrados.ToString("#,#.00");
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            double aux = (f.CantidadGrados - 32) * (5 / (float)9);
            Celsius ret = aux;
            return ret;
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            double aux = (f.CantidadGrados + 459.67) * (5 / (float)9);
            Kelvin ret = aux;
            return ret;
        }

        //F == F
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            bool ret = false;

            if (!(f1 is null) && !(f2 is null))
            {
                if (f1.CantidadGrados == f2.CantidadGrados)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        //F == C

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool ret = false;
            if (!(c is null))
            {
                ret = f == (Fahrenheit)c;
            }
            return ret;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        //F == K
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool ret = false;
            if (!(k is null))
            {
                ret = f == (Fahrenheit)k;
            }
            return ret;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        //Fah + Fah
        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            Fahrenheit ret = null;

            if (!(f1 is null) && !(f2 is null))
            {
                ret = f1.CantidadGrados + f2.CantidadGrados;
            }
            return ret;
        }

        public static Fahrenheit operator -(Fahrenheit f1, Fahrenheit f2)
        {
            Fahrenheit ret = null;

            if (!(f1 is null) && !(f2 is null))
            {
                ret = f1.CantidadGrados - f2.CantidadGrados;
            }
            return ret;
        }

        //Fah + Cel
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            Fahrenheit ret = null;

            if (!(f is null) && !(c is null))
            {
                ret = f.CantidadGrados + (Fahrenheit)c;
            }
            return ret;
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            Fahrenheit ret = null;

            if (!(f is null) && !(c is null))
            {
                ret = f.CantidadGrados - (Fahrenheit)c;
            }
            return ret;
        }

        //Fah + Kel
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            Fahrenheit ret = null;

            if (!(f is null) && !(k is null))
            {
                ret = f.CantidadGrados + (Fahrenheit)k;
            }
            return ret;
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            Fahrenheit ret = null;

            if (!(f is null) && !(k is null))
            {
                ret = f.CantidadGrados - (Fahrenheit)k;
            }
            return ret;
        }
    }
}