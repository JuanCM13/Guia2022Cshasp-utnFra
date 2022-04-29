using System;
using System.Text;

namespace EstadisticaDeportiva
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
            this.promedioGoles = 0;
        }

        public Jugador(Int32 dni, String nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(Int32 dni, String nombre , Int32 partidosJugados , Int32 totalGoles) : this(dni,nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        //methods

        public float GetPromedioGoles()
        {
            float ret = float.MinValue;
            if(this.partidosJugados > 0 && this.totalGoles != 0)
            {
                ret = this.partidosJugados / (float)totalGoles;
            }
            return ret;
        }

        public String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Estadisticas del Jugador {this.nombre}:\nDni: {this.dni}\nPartidos Jugados: {this.partidosJugados}\n" +
                $"Cantidad Goles: {this.totalGoles}\nPromedio Goles: {this.GetPromedioGoles()}");

            return str.ToString();
        }

        //sobrecarga == !=

        public static bool operator ==(Jugador j1 , Jugador j2)
        {
            bool ret = false;

            if(!(j1 is null) && !(j2 is null))
            {
                if(j1.dni == j2.dni)
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
