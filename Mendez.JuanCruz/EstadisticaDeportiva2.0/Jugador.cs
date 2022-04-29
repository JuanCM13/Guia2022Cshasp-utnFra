using System;
using System.Text;

namespace EstadisticaDeportiva2._0
{
    public class Jugador
    {
        private Int32 dni;
        private String nombre;
        private Int32 partidosJugados;
        private Int32 totalGoles;
        private float promedioGoles;

        private Jugador()
        {
            this.dni = 0;
            this.nombre = String.Empty;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(Int32 dni, String nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(Int32 dni, String nombre, Int32 partidosJugados, Int32 totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public Int32 PartidosJugados
        {
            get { return this.partidosJugados; }            
        }

        public Int32 TotalGoles
        {
            get { return this.totalGoles; }
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

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Int32 Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        //methods

        public String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Estadisticas del Jugador {this.Nombre}:\nDni: {this.Dni}\nPartidos Jugados: {this.PartidosJugados}\n" +
                $"Cantidad Goles: {this.TotalGoles}\nPromedio Goles: {this.PromedioGoles}");

            return str.ToString();
        }

        //sobrecarga == !=

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool ret = false;

            if (!(j1 is null) && !(j2 is null))
            {
                if (j1.dni == j2.dni)
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
