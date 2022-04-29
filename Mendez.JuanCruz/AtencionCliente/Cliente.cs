using System;

namespace AtencionCliente
{
    public class Cliente
    {
        private String nombre;
        private Int32 numero;

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Int32 Numero
        {
            get { return this.numero; }
        }

        public Cliente(Int32 numero) : this(numero, "Sin asignar")
        {
        }

        public Cliente(Int32 numero, String nombre)
        {
            this.Nombre = nombre;
            this.numero = numero;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool ret = false;
            if (!(c1 is null) && !(c2 is null))
            {
                if (c1.Numero == c2.Numero)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
