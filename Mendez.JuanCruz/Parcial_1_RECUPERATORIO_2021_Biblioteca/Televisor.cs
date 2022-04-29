using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Televisor : Producto
    {
        public ETipo tipo;

        public Televisor(String modelo , String marca , EPais pais , ETipo tipo )
            : base(modelo , marca , pais)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Televisor t1 , Televisor t2)
        {
            bool ret = false;
            if(!(t1 is null) && !(t2 is null))
            {
                if(t1.tipo == t2.tipo && (Producto)t1 == t2) //coon castear solo uno ya toma los 2 como productos..
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Televisor t1, Televisor t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator Double(Televisor t)
        {
            Double ret = double.MinValue;
            if(!(t is null))
            {
                ret = t.Precio;
            }
            return ret;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;

            if(obj is Televisor && (Televisor)obj == this)
            {
                ret = true;
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{(String)this}Tipo: {Enum.GetName(this.tipo)}");

            return str.ToString();
        }
    }
}
