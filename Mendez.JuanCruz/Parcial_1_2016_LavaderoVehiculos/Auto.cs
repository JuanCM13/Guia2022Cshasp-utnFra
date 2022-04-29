using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laavadero
{
    public class Auto : Vehiculo
    {
        protected Int32 cantidadAsientos;

        public Auto(String patente, Byte cantRuedas, EMarcas marca , Int32 asientos)
            :base(patente,cantRuedas,marca)
        {
            this.CantidadAsientos = asientos;
        }

        public Int32 CantidadAsientos
        {
            get { return this.cantidadAsientos; }
            private set 
            {
                Int32 aux = value;
                if(value < 2 || value > 10)
                {
                    aux = 5; //estandard por default
                }
                this.cantidadAsientos = aux;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Tipo Vehiculo: Auto\n{this.MostrarDatosBases()}Cantidad Asientos: {this.CantidadAsientos}");

            return str.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
