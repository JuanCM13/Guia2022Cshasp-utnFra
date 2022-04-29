using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela : Libro
    {
        private EGenero genero;

        public Novela(String titulo , float precio , Autor autor , EGenero genero)
            : base(precio , titulo , autor)
        {
            this.genero = genero;
        }

        public static bool operator ==(Novela n1, Novela n2)
        {
            bool ret = false;
            if (!(n1 is null) && !(n2 is null))
            {
                if ( (Libro)n1 == n2 && n1.genero == n2.genero)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator Single(Novela n)
        {
            return n.precio;
        }

        public override bool Equals(object obj)
        {
            bool ret = false;

            if (obj is Novela && (Novela)obj == this)
            {
                ret = true;
            }
            return ret;
        }

        public override String ToString()
        {
            StringBuilder str = new StringBuilder();
            String aux = this;

            str.AppendLine($"Tipo: {Enum.GetName(this.genero)} {aux}");

            return str.ToString();
        }
    }
}
