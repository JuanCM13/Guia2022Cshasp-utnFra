using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laavadero
{
    public class Camion : Vehiculo
    {
        protected float tara;

        public Camion(String patente, Byte cantRuedas, EMarcas marca, float tara)
            : base(patente, cantRuedas, marca)
        {
            this.Tara = tara;
        }

        public float Tara
        {
            get { return this.tara; }
            private set
            {
                float aux = value;
                if (value < 1000 || value > 45000)
                {
                    aux = 20000; //estandard por default
                }
                this.tara = aux;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Tipo Vehiculo: Camion\n{this.MostrarDatosBases()}Peso Tara: {this.Tara}");

            return str.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
