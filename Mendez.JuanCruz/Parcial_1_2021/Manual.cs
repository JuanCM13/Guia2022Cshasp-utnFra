using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        private ETipo tipo;

        public Manual(String titulo , String apellido , String nombre , float precio , ETipo tipo)
            : base(titulo , apellido , nombre , precio)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Manual m1 , Manual m2)
        {
            bool ret = false;
            if(!(m1 is null) && !(m2 is null))
            {
                if(m1 == (Libro)m2 && m1.tipo == m2.tipo)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }

        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;

            if(obj is Manual && (Manual)obj == this)
            {
                ret = true;
            }
            return ret;
        }

        public override String ToString()
        {
            StringBuilder str = new StringBuilder();
            String aux = this;

            str.AppendLine($"Tipo: {Enum.GetName(this.tipo)} {aux}");

            return str.ToString();
        }

    }
}
