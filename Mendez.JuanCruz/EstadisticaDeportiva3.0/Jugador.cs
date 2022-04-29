using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticaDeportiva3._0
{
    public class Jugador : Persona
    {

        private Int32 partidosJugados;
        private Int32 totalGoles;

        public Jugador(Int32 dni, String nombre) : base(nombre , dni)
        {
        }

        public Jugador(Int32 dni, String nombre, Int32 partidosJugados, Int32 totalGoles) : this(dni, nombre)
        {
            this.PartidosJugados = partidosJugados;
            this.TotalGoles = totalGoles;
        }

        public Int32 PartidosJugados
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; }
        }

        public Int32 TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; }
        }

        public float PromedioGoles
        {
            get
            {
                float ret = float.MinValue;
                if (this.partidosJugados > 0 && this.totalGoles != 0)
                {
                    ret = this.partidosJugados / (float)totalGoles;
                }
                return ret;
            }
        }

        //methods

        public override String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Jugador:\n{base.MostrarDatos()}Partidos Jugados: {this.PartidosJugados}\n" +
                $"Cantidad Goles: {this.TotalGoles}\nPromedio Goles: {this.PromedioGoles}");

            return str.ToString();
        }

        //sobrecarga == !=

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool ret = false;

            if (!(j1 is null) && !(j2 is null))
            {
                if (j1.Dni == j2.Dni)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
