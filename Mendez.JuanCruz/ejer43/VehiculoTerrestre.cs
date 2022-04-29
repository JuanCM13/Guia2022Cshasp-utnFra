using System;
using System.Text;

namespace EntidadesVeh
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        public VehiculoTerrestre(short ruedas,short puertas,Colores color)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuertas = puertas;
            this.color = color;
        }

        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Cantidad Puertas: {this.cantidadPuertas}\nCantidad Ruedas: {this.cantidadRuedas}\nColor: {Enum.GetName(this.color)}");

            return str.ToString();
        }

        public static bool operator ==(VehiculoTerrestre v1 , VehiculoTerrestre v2)
        {
            bool ret = false;
            if(!(v1 is null) && !(v2 is null))
            {
                if(v1.cantidadPuertas == v2.cantidadPuertas && v1.cantidadRuedas == v2.cantidadRuedas)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(VehiculoTerrestre v1, VehiculoTerrestre v2)
        {
            return !(v1 == v2);
        }


    }
}
