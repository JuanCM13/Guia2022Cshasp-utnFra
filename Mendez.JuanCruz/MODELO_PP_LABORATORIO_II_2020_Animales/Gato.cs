using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialAnimales
{
    public class Gato : Mascota
    {
        public Gato(String nombre,  String raza) : base(nombre , raza)
        {}

        protected override string Ficha()
        {
            StringBuilder str = new StringBuilder();

            str.Append($"Gato - {base.DatosCompletos()}");

            return str.ToString();
        }

        public static bool operator ==(Gato g1 , Gato g2)
        {
            bool ret = false;
            if(!(g1 is null) && !(g2 is null))
            {
                if((Mascota)g1 == g2)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Gato && (Gato)obj == this)
            {
                ret = true;
            }
            return ret;
        }
    }
}
