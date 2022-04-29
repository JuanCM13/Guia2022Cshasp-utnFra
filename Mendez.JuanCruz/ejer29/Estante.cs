using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estanteria
{
    public class Estante
    {
        private Producto[] productos;
        private Int32 ubicacionEstante;

        private Estante(Int32 capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(Int32 ubicacion, Int32 capacidad) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static String MostrarEstante(Estante es)
        {
            StringBuilder str = null;

            if (!(es is null))
            {
                str = new StringBuilder();

                str.AppendLine($"Ubicacion estante: {es.ubicacionEstante}");
                foreach (Producto pro in es.GetProductos())
                {
                    str.AppendLine(Producto.MostrarProducto(pro));
                }
            }

            return str.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool ret = false;
            if (!(e is null) && !(p is null))
            {
                for(Int32 i=0; i<e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e , Producto p)
        {
            bool ret = false;

            if(e!=p)
            {
                for(Int32 i=0; i<e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        ret = true;
                        break;                        
                    }
                }
            }
            return ret;
        }

        public static Estante operator -(Estante e , Producto p)
        {
            Estante ret = null;
            if(!(e is null) && !(p is null))
            {
                for(Int32 i=0; i<e.GetProductos().Count(); i++)
                {
                    if((e.GetProductos())[i] == p)
                    {
                        (e.GetProductos())[i] = null;
                        ret = e;
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
