using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnciendanSusMotores2._0
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private String escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, String escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
            this.CantidadCombustible = 0;
            this.EnCompetencia = false;
            this.VueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public String Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public virtual String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            String aux = this.EnCompetencia == true ? "Compitiendo" : "No compite";

            str.AppendLine($"Escuderia: {this.Escuderia}\nNumero: {this.Numero}\n {aux}\nCantidad Combustible: {this.CantidadCombustible}\nVueltas Restantes: {this.VueltasRestantes}");

            return str.ToString();
        }
    }
}
