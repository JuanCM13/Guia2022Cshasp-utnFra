using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticaDeportiva3._0
{
    public class Persona
    {
        private long dni;
        private String nombre;

        public long Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        
        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Persona(String nombre)
        {
            this.Nombre = nombre;
            this.dni = -1; //sin cargar..
        }

        public Persona(String nombre, Int32 dni) :this(nombre)
        {
            this.Dni = dni;
        }

        public virtual String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            String aux = "Sin asignar";
            if(this.Dni > -1)
            {
                aux = this.Dni.ToString();
            }

            str.AppendLine($"Dni: {aux}\nNombre: {this.Nombre}");

            return str.ToString();
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Persona p1 , Persona p2)
        {
            bool ret = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if(p1.Dni == p2.Dni)
                {
                    ret = true;
                }
            }
            return ret;
        }
    }
}
