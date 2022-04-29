using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialLibreria
{
    public class Vendedor
    {
        private String nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(String nombre) :this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Vendedor vendedor , Publicacion publicacion)
        {
            bool ret = false;
            if(!(vendedor is null) && !(publicacion is null))
            {
                if(publicacion.HayStock)
                {
                    vendedor.ventas.Add(publicacion);
                    publicacion.Stock--;
                    ret = true;
                }
            }
            return ret;
        }

        public static String ObtenerInformeDeVentas(Vendedor vendedor)
        {
            StringBuilder str = new StringBuilder();
            Single acumGanancia;

            if (!(vendedor is null))
            {
                acumGanancia = 0;
                str.AppendLine($"{vendedor.nombre}");
                str.AppendLine("------------------------------------\n");
                if(vendedor.ventas.Count > 0)
                {
                    foreach(Publicacion item in vendedor.ventas)
                    {
                        str.AppendLine(item.ObtenerInformacion());
                        acumGanancia += item.Importe;
                    }
                }
                else
                {
                    str.AppendLine("Sin ventas por el momento..");
                }

                str.AppendLine("\n------------------------------------\n");
                str.AppendLine($"Ganancia Total: {acumGanancia}");
            }
            else
            {
                str.AppendLine("Che me pasaste un vendedor sin crear... media pila");
            }

            return str.ToString();
        }

    }
}
