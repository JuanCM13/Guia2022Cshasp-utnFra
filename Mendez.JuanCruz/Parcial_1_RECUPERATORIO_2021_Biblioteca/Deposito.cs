using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        private Int32 capacidad;
        private List<Producto> productos;

        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        private Deposito(Int32 capacidad) :this()
        {
            this.capacidad = capacidad;
        }

        public Double PrecioDeCelulares
        {
            get { return this.ObtenerPrecio(EProducto.PrecioDeCelulares); }
        }

        public Double PrecioDeTelevisores
        {
            get { return this.ObtenerPrecio(EProducto.PrecioDeTelevisores); }
        }

        public Double PrecioTotal
        {
            get { return this.ObtenerPrecio(EProducto.PrecioTotal); }
        }

        public static String Mostrar(Deposito dep)
        {
            StringBuilder str = new StringBuilder();

            if(!(dep is null))
            {
                str.AppendLine($"Cantidad disponible de Productos: {dep.capacidad}");
                str.AppendLine($"Total facturado de celulares: {dep.PrecioDeCelulares}");
                str.AppendLine($"Total de televisores facturado: {dep.PrecioDeTelevisores}");
                str.AppendLine($"Total Facturado: {dep.PrecioTotal}");
                if (dep.productos.Count > 0)
                {
                    str.AppendLine("-----------------------------------------------------------------------");
                    str.AppendLine("                             PRODUCTOS:");
                    str.AppendLine("-----------------------------------------------------------------------");
                    foreach (Producto prod in dep.productos)
                    {
                        str.AppendLine(prod.ToString());
                    }
                }
                else
                {
                    str.AppendLine("Sin productos cargados al momento..");
                }
            }
            else
            {
                str.AppendLine("Elemento vacio..");
            }
            return str.ToString();
        }

        public static implicit operator Deposito(Int32 capacidad)
        {
            return new Deposito(capacidad);
        }

        public static bool operator ==(Deposito dep , Producto p)
        {
            bool ret = false;
            if(!(dep is null) && !(p is null))
            {               
                foreach(Producto item in dep.productos)
                {
                    if(item.Equals(p))
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Deposito dep, Producto p)
        {
            return !(dep == p);
        }

        public static Deposito operator +(Deposito dep , Producto p)
        {
            if(!(dep is null) && !(p is null))
            {
                if(dep.productos.Count + 1 <= dep.capacidad)
                {
                    if((dep != p))
                    {
                        dep.productos.Add(p);
                    }                    
                    else
                    {
                        Console.WriteLine("Ya se encuentra en la lista..");
                    }
                }
                else
                {
                    Console.WriteLine("Lista llena...");
                }
            }
            return dep;
        }

        /*Método privado y de instancia ObtenerPrecio, retornará el valor del depósito de acuerdo con el enumerado EProducto que
        recibe como parámetro. Las propiedades públicas PrecioDeTelevisores, PrecioDeCelulares y PrecioTotal están asociadas al
        método ObtenerPrecio. Reutilizar código.*/

        private Double ObtenerPrecio(EProducto producto)
        {
            Int32 aux = (Int32)producto;
            Double acum = 0;

            foreach(Producto item in this.productos)
            {
                if(item is Televisor && aux == 0 || aux == 2)
                {
                    acum += item.Precio;
                }
                else
                {
                    if(item is Celular && aux == 1 || aux == 2)
                    {
                        acum += item.Precio;
                    }
                }
            }

            return acum;
        }
    }
}
