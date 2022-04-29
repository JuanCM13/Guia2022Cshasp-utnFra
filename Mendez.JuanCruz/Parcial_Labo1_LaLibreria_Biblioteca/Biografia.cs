using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLibreria
{
    public class Biografia : Publicacion
    {
        protected override bool EsColor
        {
            get { return false; }
        }

        public Biografia(String nombre)
            :base(nombre)
        {}

        public Biografia(String nombre, Int32 stock)
            :base(nombre , stock)
        {}

        public Biografia(String nombre , Int32 stock , Single valor)
            :base(nombre , stock , valor)
        {}

        public override bool HayStock
        {
            get
            {
                if (this.stock > 0)
                {
                    return true;
                }
                return false;
            }            
        }

        public static explicit operator Biografia(String nombre)
        {
            return new Biografia(nombre);
        }
    }
}
