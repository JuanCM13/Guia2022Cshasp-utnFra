using System;
using System.Text;

namespace Laavadero
{
    public abstract class Vehiculo
    {
        /*
        Clase Vehiculo que posea como atributos protegidos:
        patente : string (con una propiedad sólo lectura)
        cantRuedas : Byte
        marca : EMarcas (con los siguientes enumerados: Honda, Ford, Zanella, Scania, Iveco y Fiat). Crear propiedad de 
        sólo lectura.
        Y los siguientes métodos:
        (~) Mostrar() : string
        (+) Vehiculo (string, Byte, EMarcas) (sin sobrecargas)
        */

        protected String patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        public String Patente
        {
            get { return this.patente; }
        }

        public EMarcas Marca
        {
            get { return this.marca; }
        }

        private Byte CantidadRuedas //para filtrar la cantidad de ruedas, sino pueden meter cualquier zapallo
        {
            set
            {
                Byte aux = value;
                if(value < 2 || value > 30)
                {
                    aux = 4; //standard de ruedas
                }

                this.cantRuedas = aux;
            }
        }

        protected Vehiculo(String patente, Byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.CantidadRuedas = cantRuedas;
            this.marca = marca;
        }

        protected String MostrarDatosBases()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"Patente: {this.Patente}\nCantidad Ruedas: {this.cantRuedas}\nMarca: {this.Marca}");

            return str.ToString();
        }

        protected abstract String Mostrar();

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool ret = false;
            if (!(v1 is null) && !(v2 is null))
            {
                if (v1.marca == v2.marca && v1.patente == v2.patente)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is Vehiculo && (Vehiculo)obj == this)
            {
                ret = true;
            }
            return ret;
        }
    }
}
