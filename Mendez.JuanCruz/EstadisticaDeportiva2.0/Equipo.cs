using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticaDeportiva2._0
{
    public class Equipo
    {
        private short cantJugadores;
        private String nombreEquipo;
        private List<Jugador> listadoJugadores;

        private Equipo()
        {
            this.listadoJugadores = new List<Jugador>();
        }

        public Equipo(short cantJugadores, String nombre) : this()
        {
            this.nombreEquipo = nombre;
            this.cantJugadores = cantJugadores;
        }

        public Jugador this[Int32 index]
        {
            get
            {
                if (index > -1 && index <= this.listadoJugadores.Count - 1)
                {
                    return this.listadoJugadores[index];
                }
                return null;
            }
            set
            {
                if (index < this.listadoJugadores.Count) // aca es si ya existe, ahi lo modifica..
                {
                    this.listadoJugadores[index] = value;
                }
                else
                {
                    if (index <= this.cantJugadores)
                    {
                        bool aux = this + value; //aplico la sobrecarga del + para agregar uno nuevo
                    }
                }
            }
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool ret = false;
            bool acceso = true;

            if (!(e is null) && !(j is null))
            {
                if (e.listadoJugadores.Count + 1 <= e.cantJugadores)
                {
                    foreach (Jugador jug in e.listadoJugadores)
                    {
                        if (jug == j)
                        {
                            acceso = false;
                            break;
                        }
                    }

                    if (acceso)
                    {
                        e.listadoJugadores.Add(j);
                        ret = true;
                    }
                }
            }
            return ret;
        }

        public String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Info Equipo:\nNombre: {this.nombreEquipo}\nCantidad Jugadores: {this.cantJugadores}\nJugadores Cargados:");
            foreach (Jugador jugador in this.listadoJugadores)
            {
                str.AppendLine(jugador.MostrarDatos());
            }

            return str.ToString();
        }
    }
}
