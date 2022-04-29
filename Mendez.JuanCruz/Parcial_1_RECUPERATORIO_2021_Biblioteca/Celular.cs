using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular : Producto
    {
        private EGama gama;

        public Celular(String modelo , Fabricante fab , EGama gama)
            : base(modelo , fab)
        {
            this.gama = gama;
        }

        public static bool operator ==(Celular c1 , Celular c2)
        {
            bool ret = false;
            if(!(c1 is null) && !(c2 is null))
            {
                if(c1.gama == c2.gama && (Producto)c1 == c2)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Celular c1, Celular c2)
        {
            return !(c1 == c2);
        }

        public static explicit operator Double(Celular c)
        {
            Double ret = double.MinValue;
            if (!(c is null))
            {
                ret = c.Precio;
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Celular && (Celular)obj == this)
            {
                ret = true;
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{(String)this}Gama: {Enum.GetName(this.gama)}");

            return str.ToString();
        }
    }
}
