using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLibreria
{
    public class Comic : Publicacion
    {
        private bool esColor;

        public Comic(String nombre , bool esColor , Int32 stock , Single valor)
            :base(nombre , stock , valor)
        {
            this.esColor = esColor;
        }

        protected override bool EsColor
        {
            get { return this.esColor; }
        }
    }
}
