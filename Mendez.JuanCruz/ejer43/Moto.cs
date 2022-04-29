using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVeh
{
    public sealed class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short ruedas, short puertas, Colores color,short cilindrada) :base(ruedas , puertas , color)
        {
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            set
            {
                if(value < 1 || value > 1600)
                {
                    value = 150;
                }

                this.cilindrada = value;
            }
        }

        public String MostrarMoto()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Moto:\n{base.Mostrar()}Cilindrada: {this.cilindrada}");

            return str.ToString();
        }

    }
}
