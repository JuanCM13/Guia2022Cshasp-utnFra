using System;
using System.Text;

namespace Estanteria
{
    public class Producto
    {
        private String codigoBarras;
        private String marca;
        private float precio;

        public Producto(String marca, String codigo, float precio)
        {
            this.marca = marca;
            this.codigoBarras = codigo;
            this.precio = precio;
        }

        public String GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static explicit operator String(Producto p)
        {
            if (!(p is null))
            {
                return p.codigoBarras;
            }

            return String.Empty;
        }

        public static String MostrarProducto(Producto p)
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Marca: {p.GetMarca()}\nPrecio: {p.GetPrecio()}\nCodigo Barras: {(String)p}");

            return str.ToString();
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            bool ret = false;

            if (!(prod1 is null) && !(prod2 is null))
            {
                if (prod1.GetMarca() == prod2.GetMarca() && (String)prod1 == (String)prod2)
                {
                    ret = true;
                }
            }

            return ret;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public static bool operator ==(Producto prod, String cadena)
        {
            bool ret = false;
            if (!(prod is null) && !(cadena is null))
            {
                if (prod.GetMarca() == cadena)
                {
                    ret = true;
                }
            }

            return ret;
        }

        public static bool operator !=(Producto prod, String cadena)
        {
            return !(prod == cadena);
        }
    }
}
