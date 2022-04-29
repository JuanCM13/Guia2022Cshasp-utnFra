using System;

namespace ClaseSumador

{
    public class Sumador
    {
        private Int32 cantidadSumas;

        public Sumador(Int32 valor)
        {
            this.cantidadSumas = valor;
        }

        public Sumador() :this(0)
        {
        }

        public long Sumar(long n1 , long n2)
        {
            this.cantidadSumas++;

            return n1 + n2;
        }

        public String Sumar(String s1 , String s2)
        {
            this.cantidadSumas++;

            return s1 + s2;
        }

        public static double operator +(Sumador s1 , Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1 , Sumador s2)
        {
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }

            return false;
        }

        public static explicit operator Int32(Sumador s1)
        {
            return s1.cantidadSumas;
        }
    }
}
