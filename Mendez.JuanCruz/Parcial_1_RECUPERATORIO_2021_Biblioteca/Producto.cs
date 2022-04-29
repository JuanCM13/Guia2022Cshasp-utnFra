using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected String modelo;
        protected float precio;

        public float Precio
        {
            get
            {
                if(this.precio == 0)
                {
                    this.precio = Producto.generadorDePrecios.Next(10500, 125000);
                }

                return this.precio;
            }
        }

        static Producto()
        {
            Producto.generadorDePrecios = new Random(); 
        }

        public Producto(String modelo , Fabricante fab)
        {
            this.modelo = modelo;
            this.fabricante = fab;
        }

        public Producto(String modelo, String marca , EPais pais)
            :this(modelo , new Fabricante(marca , pais))
        {
        }

        private static String Mostrar(Producto p)
        {
            StringBuilder str;
            String aux = "El producto no esta creado..";

            if(!(p is null))
            {
                str = new StringBuilder();
                aux = p.fabricante; //carga implicita

                str.AppendLine($"Fabricante: {aux}\nModelo: {p.modelo}\nPrecio: {p.Precio}");
                aux = str.ToString();
            }
            return aux;
        }

        public static bool operator ==(Producto p1 , Producto p2)
        {
            bool ret = false;
            if(!(p1 is null) && !(p2 is null))
            {
                if(p1.modelo == p2.modelo && p1.fabricante == p2.fabricante)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator String(Producto p)
        {
            return Producto.Mostrar(p);
        }
    }
}
