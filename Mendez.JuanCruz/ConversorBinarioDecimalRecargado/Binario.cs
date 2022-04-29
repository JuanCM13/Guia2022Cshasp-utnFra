using System;

namespace ConversorBinarioDecimalRecargado
{
    public class Binario
    {
        private String numBinario;

        private Binario(String num)
        {
            if(Binario.EsBinario(num))
            {
                this.numBinario = num;
            }         
        }

        //implicit operator

        public static implicit operator Binario(String dato)
        {
            return new Binario(dato);
        }

        //explicit 

        public static explicit operator Deecimal(Binario bin)
        {
            Deecimal ret = null;
            if(!(bin is null))
            {
                ret = Conversor.ConversorB_D(bin.numBinario);
            }
            return ret;
        }

        public static explicit operator String(Binario b)
        {
            return b.numBinario;
        }

        //overloads

        public static String operator -(Binario bin , Deecimal dec)
        {
            String ret = String.Empty;
            Deecimal aux;
            if(!(bin is null) && !(dec is null))
            {
                aux  = dec-bin;
                ret = ((Binario)aux).numBinario;
            }

            return ret;
        }

        public static String operator +(Binario bin, Deecimal dec)
        {
            String ret = String.Empty;
            Deecimal aux;
            if (!(bin is null) && !(dec is null))
            {
                aux = dec + bin;
                ret = ((Binario)aux).numBinario;
            }

            return ret;
        }

        public static bool EsBinario(String cadena)
        {
            bool ret = true;
            if(!String.IsNullOrWhiteSpace(cadena))
            {
                foreach(char caracter in cadena)
                {
                    if(caracter != '1' && caracter != '0')
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
