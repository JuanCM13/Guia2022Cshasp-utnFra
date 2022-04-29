using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laavadero
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;

        public Moto(String patente, Byte cantRuedas, EMarcas marca, float cilindrada)
            : base(patente, cantRuedas, marca)
        {
            this.Cilindrada = cilindrada;
        }

        public float Cilindrada
        {
            get { return this.cilindrada; }
            private set
            {
                float aux = value;
                if (value < 25 || value > 1600)
                {
                    aux = 150; //estandard por default
                }
                this.cilindrada = aux;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Tipo Vehiculo: Motocicleta\n{this.MostrarDatosBases()}Cilindrada: {this.Cilindrada}");

            return str.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
