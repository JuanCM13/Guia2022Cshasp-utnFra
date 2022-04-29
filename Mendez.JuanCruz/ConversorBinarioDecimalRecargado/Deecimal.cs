using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinarioDecimalRecargado
{
    public class Deecimal
    {
        private Double numDecimal;

        private Deecimal(Double num)
        {
            this.numDecimal = num;
        }

        //implicit operator

        public static implicit operator Deecimal(Double dato)
        {
            return new Deecimal(dato);
        }

        //explicit operator

        public static explicit operator Binario(Deecimal dec)
        {
            Binario ret = null;
            if(!(dec is null))
            {
                ret = Conversor.ConversorD_B((int)dec.numDecimal);
            }

            return ret;
        }

        public static explicit operator Double(Deecimal d)
        {
            return d.numDecimal;
        }

        //overloads

        public static bool operator ==(Deecimal dec , Binario bin)
        {
            bool ret = false;
            Deecimal decimalAux;

            if(!(dec is null) && !(bin is null))
            {
                decimalAux = (Deecimal)bin;
                if(dec.numDecimal == decimalAux.numDecimal)
                {
                    ret = true;
                }
            }
            return ret; 
        }

        public static bool operator !=(Deecimal dec , Binario bin)
        {
            return !(dec == bin);
        }

        public static Double operator -(Deecimal dec , Binario bin)
        {
            Double ret = Double.MinValue;
            if (!(dec is null) && !(bin is null))
            {
                ret = dec.numDecimal - ((Deecimal)bin).numDecimal;               
            }
            return ret;
        }

        public static Double operator +(Deecimal dec, Binario bin)
        {
            Double ret = Double.MinValue;
            if (!(dec is null) && !(bin is null))
            {
                ret = dec.numDecimal + ((Deecimal)bin).numDecimal;
            }
            return ret;
        }
    }
}
