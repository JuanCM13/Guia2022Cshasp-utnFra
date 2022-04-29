using System;
using System.Collections.Generic;
using System.Text;

namespace EstadisticaDeportiva3._0
{
    public class Equipo
    {
        private short cantJugadores;
        private String nombreEquipo;
        private List<Persona> listadoPersonas;

        private Equipo()
        {
            this.listadoPersonas = new List<Persona>();
        }

        public Equipo(short cantJugadores, String nombre) : this()
        {
            this.nombreEquipo = nombre;
            this.cantJugadores = cantJugadores;
        }

        public Persona this[Int32 index]
        {
            get
            {
                if (index > -1 && index <= this.listadoPersonas.Count - 1)
                {
                    return this.listadoPersonas[index];
                }
                return null;
            }
            set
            {
                if (index < this.listadoPersonas.Count) // aca es si ya existe, ahi lo modifica..
                {
                    this.listadoPersonas[index] = value;
                }
                else
                {
                    if (index < this.cantJugadores)
                    {
                        bool aux = this + value; //aplico la sobrecarga del + para agregar uno nuevo
                    }
                }
            }
        }

        public static bool operator +(Equipo e, Persona p)
        {
            bool ret = false;
            bool acceso = true;

            if (!(e is null) && !(p is null))
            {
                if (e.listadoPersonas.Count + 1 <= e.cantJugadores)
                {
                    foreach (Persona per in e.listadoPersonas)
                    {
                        if(per == p)
                        {
                            acceso = false;
                            break;
                        }
                    }

                    if (acceso)
                    {
                        e.listadoPersonas.Add(p);
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
            foreach (Persona person in this.listadoPersonas)
            {
                str.AppendLine(person.MostrarDatos());
            }

            return str.ToString();
        }
    }
}
