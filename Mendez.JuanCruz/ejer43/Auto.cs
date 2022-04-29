using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVeh
{
    public class Auto : Camion
    {
        private Int32 cantidadPasajeros;

        public Auto(short cantPuertas, short cantRuedas, Colores color, short cantMarchas, Int32 cantidadPasajeros)
            :base(cantPuertas , cantRuedas , color , cantMarchas , 0)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public Int32 CantidadPasajeros
        {
            set
            {
                if(value < 1 || value > 5)
                {
                    value = 4; //por default
                }

                this.cantidadPasajeros = value;
            }
        }

        public String MostrarAuto()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Auto:\n{base.Mostrar()}Cantidad Marchas: {this.cantidadMarchas}\nCantidad Pasajeros: {this.cantidadPasajeros}");

            return str.ToString();
        }
    }
}
