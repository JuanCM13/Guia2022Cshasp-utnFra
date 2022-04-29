using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticaDeportiva3._0
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(String nombre) :base(nombre)
        {
        }

        public DirectorTecnico(String nombre, DateTime fecha) :this(nombre)
        {
            this.fechaNacimiento = fecha;
        }

        public override String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Director Tecnico: \n{base.MostrarDatos()}Fecha nacimiento : {this.fechaNacimiento}");

            return str.ToString();
        }

        public static bool operator ==(DirectorTecnico d1 , DirectorTecnico d2)
        {
            bool ret = false;
            if(!(d1 is null) && !(d2 is null))
            {
                if(d1.fechaNacimiento == d2.fechaNacimiento && d1.Nombre == d2.Nombre)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }


    }
}
