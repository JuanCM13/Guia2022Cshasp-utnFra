using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laavadero
{
    //ME QUEDE EN HACER LAS SOBRECARGAS DE == + Y -, SEGUIR DESDE AHI Y PROBAR TODO! bien hecho juan :)

    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) :this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }
        }

        public String Detalle
        {
            get
            {
                StringBuilder str = new StringBuilder();

                str.AppendLine($"Informacion Lavadero:\nPrecio Autos: {this.precioAuto}\nPrecio Camion: {this.precioCamion}" +
                    $"\nPrecio Moto: {this.precioMoto}\n\nVehiculos ingresados hoy:");

                if (this.Vehiculos.Count > 0)
                {
                    foreach (Vehiculo veh in this.Vehiculos)
                    {
                        str.AppendLine("\n-------------------------------------------------------------------------");
                        str.Append(veh.ToString());
                        str.AppendLine("-------------------------------------------------------------------------\n");
                    }
                }
                else
                {
                    str.AppendLine("Sin vehiculos al momento...");
                }

                return str.ToString();
            }
        }

        public Double MostrarTotalFacturado()
        {
            Double aux = 0;
            foreach (EVehiculos veh in Enum.GetValues(typeof(EVehiculos)))
            {
                aux += this.MostrarTotalFacturado(veh);
            }

            return aux;
        }

        public Double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            Int32 indiceEnumerado = (Int32)vehiculo;
            Int32 contadorVehiculos = 0;
            Double ret = 0;
            float precioAux = 0;

            //1 auto, 2 camion , 3 moto

            if (this.Vehiculos.Count > 0)
            {
                foreach (Vehiculo veh in this.Vehiculos)
                {
                    switch (indiceEnumerado)
                    {
                        case 1:
                            if (veh is Auto)
                            {
                                contadorVehiculos++;
                                precioAux = this.precioAuto;
                            }
                            break;
                        case 2:
                            if (veh is Camion)
                            {
                                contadorVehiculos++;
                                precioAux = this.precioCamion;
                            }
                            break;
                        case 3:
                            if (veh is Moto)
                            {
                                contadorVehiculos++;
                                precioAux = this.precioMoto;
                            }
                            break;
                    }
                }

                ret = contadorVehiculos * precioAux;
            }
            return ret;
        }

        public static bool operator ==(Lavadero lav, Vehiculo veh)
        {
            bool ret = false;
            if (!(lav is null) && !(veh is null))
            {
                foreach (Vehiculo v in lav.Vehiculos)
                {
                    if (v == veh)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        //probar el contains a ver si me toma la sobrecarga del reference de vehiculo == vehiculo...

        public static bool operator !=(Lavadero lav, Vehiculo veh)
        {
            return !(lav == veh);
        }

        public static Lavadero operator +(Lavadero lav , Vehiculo veh)
        {
            if(!(lav is null) && !(veh is null))
            {
                if(lav != veh)
                {
                    lav.Vehiculos.Add(veh);
                }
            }
            return lav;
        }

        public static Lavadero operator -(Lavadero lav, Vehiculo veh)
        {
            if (!(lav is null) && !(veh is null))
            {
                if (lav == veh)
                {
                    lav.Vehiculos.Remove(veh); //sobrecargue el reference de == de veh == veh, tendria que funcar..
                }
            }
            return lav;
        }

        public static Int32 OrdenarVehiculosPorPatente(Vehiculo v1 , Vehiculo v2)
        {
            Int32 ret = 0;
            
            if(!(v1 is null) && !(v2 is null))
            {
                ret = String.Compare(v1.Patente, v2.Patente);
            }

            return ret;
        } 

        public Int32 OrdenarVehiculosPorMarca(Vehiculo v1 , Vehiculo v2)
        {
            Int32 ret = 0;

            if (!(v1 is null) && !(v2 is null))
            {
                ret = String.Compare(Enum.GetName(v1.Marca), Enum.GetName(v2.Marca));
            }
            return ret;
        }

        public override string ToString()
        {
            return this.Detalle;
        }
    }
}
