using System;
using System.Text;

namespace EnciendanSusMotores
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private String escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero , String escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
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

        public String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();
            String aux = this.EnCompetencia == true ? "Compitiendo" : "No compite";

            str.AppendLine($"Escuderia: {this.escuderia}\nNumero: {this.numero}\n {aux}\nCantidad Combustible: {this.CantidadCombustible}\nVueltas Restantes: {this.VueltasRestantes}");

            return str.ToString();
        }

        public static bool operator ==(AutoF1 f1 , AutoF1 f2)
        {
            bool ret = false;
            if(!(f1 is null) && !(f2 is null))
            {
                if(f1.escuderia == f2.escuderia && f1.numero == f2.numero)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(AutoF1 f1, AutoF1 f2)
        {
            return !(f1 == f2);
        }
    }
}
