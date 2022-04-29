using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesVeh
{
    public class Concesionaria
    {
        private List<VehiculoTerrestre> listado;
        private Int32 cantidad;

        private Concesionaria(Int32 cantidad)
        {
            this.listado = new List<VehiculoTerrestre>();
            this.cantidad = cantidad;
        }

        public static implicit operator Concesionaria(Int32 cantidad)
        {
            Int32 aux = cantidad;
            if (aux < 0)
            {
                aux = 0;
            }

            return new Concesionaria(aux);
        }

        public static bool operator ==(Concesionaria con, VehiculoTerrestre veh)
        {
            bool ret = false;
            if (!(con is null) && !(veh is null))
            {
                foreach (VehiculoTerrestre v in con.listado)
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

        public static bool operator !=(Concesionaria con, VehiculoTerrestre veh)
        {
            return !(con == veh);
        }

        public static Concesionaria operator +(Concesionaria con, VehiculoTerrestre veh)
        {
            if (!(con is null) && !(veh is null))
            {
                if (con.listado.Count < con.cantidad && con != veh)
                {
                    con.listado.Add(veh);
                }
            }
            return con;
        }

        public static Concesionaria operator -(Concesionaria con, VehiculoTerrestre veh)
        {
            Int32 counter = 0;
            foreach(VehiculoTerrestre v in con.listado)
            {
                if(con == veh)
                {
                    con.listado.RemoveAt(counter);
                    break;
                }
                counter++;
            }
            return con;
        }

        public String MostrarDataConcesionaria()
        {
            StringBuilder str;
            String aux = "Lista vacia al momento";
            if(this.listado.Count > 0)
            {
                str = new StringBuilder();
                foreach(VehiculoTerrestre v in this.listado)
                {
                    if(v is Auto)
                    {
                        str.AppendLine(((Auto)v).MostrarAuto());
                    }
                    else
                    {
                        if(v is Camion)
                        {
                            str.AppendLine(((Camion)v).MostrarCamion());
                        }
                        else
                        {
                            if(v is Moto)
                            {
                                str.AppendLine(((Moto)v).MostrarMoto());
                            }
                            else
                            {
                                str.AppendLine(v.Mostrar());
                            }
                        }
                    }
                }

                aux = str.ToString();
            }
            return aux;
        }


    }
}
