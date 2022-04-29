using System;
using System.Text;

namespace Entidades
{
    public class Autor
    {
        private String nombre;
        private String apellido;

        public Autor(String nom , String apel)
        {
            this.nombre = nom;
            this.apellido = apel;
        }

        public static implicit operator String(Autor au)
        {
            StringBuilder str = new StringBuilder();
            return str.AppendLine($"{au.nombre} {au.apellido}").ToString();
        }

        public static bool operator ==(Autor au1 , Autor au2)
        {
            bool ret = false;

            if(!(au1 is null) && !(au2 is null))
            {
                if(au1.nombre == au2.nombre && au1.apellido == au2.apellido)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Autor au1, Autor au2)
        {
            return !(au1 == au2);
        }
    }
}
