using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVeh
{
    public class Camion : VehiculoTerrestre
    {
        protected short cantidadMarchas;
        private Int32 pesoCarga;

        public Camion(short cantPuertas, short cantRuedas, Colores color, short cantMarchas, Int32 peso) :base(cantRuedas , cantPuertas , color)
        {
            this.CantidadMarchas = cantMarchas;
            this.PesoCarga = peso;
        }

        public short CantidadMarchas
        {
            set
            {
                if (value < 1 || value > 6)
                {
                    value = 4; //por default
                }

                this.cantidadMarchas = value;
            }
        }

        public Int32 PesoCarga
        {
            set
            {
                if(value < 100 || value > 110000)
                {
                    value = 50000;
                }

                this.pesoCarga = value;
            }
        }

        public String MostrarCamion()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.Mostrar()}Cantidad Marchas: {this.cantidadMarchas}\nPeso Carga: {this.pesoCarga}");

            return str.ToString();
        }
    }
}
