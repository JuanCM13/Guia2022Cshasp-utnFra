using System;
using System.Text;

namespace ejer05Entidades
{
    public class Tinta
    {
        //fields
        private ConsoleColor color;
        private EtipoTinta tinta;

        //const
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tinta = EtipoTinta.Comun;
        }

        public Tinta(ConsoleColor color) :this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color , EtipoTinta tinta) :this(color)
        {
            this.tinta = tinta;
        }

        //overloads
        public static bool operator ==(Tinta t1 , Tinta t2)
        {
            bool ret = false;
            if(t1.tinta == t2.tinta && t1.color == t2.color)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Tinta t1 , Tinta t2)
        {
            return !(t1 == t2);
        }

        public static explicit operator String(Tinta t1)
        {
            StringBuilder aux = new StringBuilder();

            aux.AppendLine($"Tipo tinta: {Enum.GetName(typeof(EtipoTinta), t1.tinta)}\nColor: {t1.color}");
            
            return aux.ToString();
        }

        //methods
        private String Mostrar()
        {
            if(Object.ReferenceEquals(this , null) == false)
            {
                return (String)this;
            }    
            else
            {
                return "Tipo Tinta: Sin asignar";
            }
        }

        public static String Mostrar(Tinta t1)
        {
            if (Object.ReferenceEquals(t1, null) == false)
            {
                return t1.Mostrar();
            }
            else
            {
                return "Tipo Tinta: Sin asignar";
            }
        }
    }
}
