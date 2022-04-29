using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialAnimales
{
    public class Perro : Mascota
    {
        private Int32 edad;
        private bool esAlfa;

        public Perro(String nombre , String raza) : this(nombre , raza , 0 , false)
        {}

        public Perro(String nombre, String raza , Int32 edad , bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder str = new StringBuilder();
            String aux = "";

            if(this.esAlfa == true)
            {
                aux = "Alfa de la manada,";
            }

            str.Append($"Perro - {base.DatosCompletos()} , {aux} edad {this.edad}");

            return str.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool ret = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if((Mascota)p1 == p2 && p1.edad == p2.edad)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator Int32(Perro p)
        {
            if(!(p is null))
            {
                return p.edad;
            }

            return -1; //error 
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Perro && (Perro)obj == this)
            {
                ret = true;
            }
            return ret;
        }
    }
}
