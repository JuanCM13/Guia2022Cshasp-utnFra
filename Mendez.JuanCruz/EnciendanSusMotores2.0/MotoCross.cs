using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnciendanSusMotores2._0
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public MotoCross(short numero , String escuderia) : base(numero , escuderia)
        {}

        public MotoCross(short numero, String escuderia , short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            bool ret = false;
            if (!(m1 is null) && !(m2 is null))
            {
                if (m1.Escuderia == m2.Escuderia && m1.Numero == m2.Numero && m1.cilindrada == m2.cilindrada)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        public override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Vehiculo: {this.GetType().Name}\n{base.MostrarDatos()}Caballos Fuerza: {this.Cilindrada}");

            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is MotoCross && ((MotoCross)obj) == this)
            {
                ret = true;
            }

            return ret;
        }
    }
}
