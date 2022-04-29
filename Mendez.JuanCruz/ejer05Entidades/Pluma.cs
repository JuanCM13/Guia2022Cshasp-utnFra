using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer05Entidades
{
    public class Pluma
    {
        //fields
        private String marca;
        private Tinta tinta;
        private Int32 cantidad;

        //constr
        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(String marca) :this()
        {
            this.marca = marca;
        }

        public Pluma(String marca , Tinta tipoTinta) :this(marca)
        {
            this.tinta = tipoTinta;
        }

        public Pluma(String marca, Tinta tipoTinta , Int32 cantTinta) :this(marca , tipoTinta)
        {
            this.cantidad = cantTinta;
        }

        //overloads
        public static bool operator ==(Pluma p1 , Tinta t1)
        {
            bool ret = false;
            if(p1.tinta == t1)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Pluma p1 , Tinta t1)
        {
            return !(p1 == t1);
        }
        
        public static bool operator +(Pluma p1 , Tinta t1)
        {
            bool ret = false;
            if(p1 == t1)
            {
                ret = true;
                p1.cantidad++;
            }
            return ret;
        }

        public static bool operator -(Pluma p1 , Tinta t1)
        {
            bool ret = false;
            if(p1 == t1 && p1.cantidad > 0)
            {
                ret = true;
                p1.cantidad--;
            }
            return ret;
        }

        public static implicit operator String(Pluma p1)
        {
            return p1.Mostrar();
        }

        //methods
        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{Tinta.Mostrar(this.tinta)}Cantidad Tinta: {this.cantidad}\nMarca: {this.marca}");

            return str.ToString();
        }

    }
}
