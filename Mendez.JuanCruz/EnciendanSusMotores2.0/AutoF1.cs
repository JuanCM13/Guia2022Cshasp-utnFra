using System;
using System.Text;

namespace EnciendanSusMotores2._0
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosFuerza;

        public short CaballosFuerza
        {
            get { return this.caballosFuerza; }
            set { this.caballosFuerza = value; }
        }

        public AutoF1(short numero, String escuderia) : base(numero, escuderia)
        { }

        public AutoF1(short numero, String escuderia , short caballos) : this(numero, escuderia)
        {
            this.CaballosFuerza = caballos;
        }

        public static bool operator ==(AutoF1 f1, AutoF1 f2)
        {
            bool ret = false;
            if (!(f1 is null) && !(f2 is null))
            {
                if(f1.Escuderia == f2.Escuderia && f1.Numero == f2.Numero && f1.CaballosFuerza == f2.CaballosFuerza)
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

        public override string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Vehiculo: {this.GetType().Name}\n{base.MostrarDatos()}Caballos Fuerza: {this.CaballosFuerza}");

            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            bool ret = false;
            if(obj is AutoF1 && ((AutoF1)obj) == this)
            {
                ret = true;
            }

            return ret;
        }
    }
}
