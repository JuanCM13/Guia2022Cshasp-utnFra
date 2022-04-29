using System;

namespace Entidades
{
    public class Fabricante
    {
        private String marca;
        private EPais pais;

        public Fabricante(String marca , EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        public static bool operator ==(Fabricante f1 , Fabricante f2)
        {
            bool ret = false;
            if(!(f1 is null) && !(f2 is null))
            {
                if(f1.marca == f2.marca && f1.pais == f2.pais)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Fabricante f1, Fabricante f2)
        {
            return !(f1 == f2);
        }

        public static implicit operator String(Fabricante f)
        {
            String ret = String.Empty;
            if(!(f is null))
            {
                ret = f.marca + " - " + Enum.GetName(f.pais);
            }
            return ret;       
        }
    }
}
