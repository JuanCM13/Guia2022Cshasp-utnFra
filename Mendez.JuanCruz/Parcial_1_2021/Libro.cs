using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    {
        protected Autor autor;
        protected Int32 cantidadPaginas;
        protected static Random generadorPaginas;
        protected float precio;
        protected String titulo;

        protected Int32 CantidadPaginas
        {
            get 
            {
                if(cantidadPaginas == 0)
                {
                    this.cantidadPaginas = Libro.generadorPaginas.Next(10, 570);
                }

                return this.cantidadPaginas; 
            }
        }

        static Libro()
        {
            Libro.generadorPaginas = new Random();
        }

        public Libro(float precio, String titulo, Autor autor)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.precio = precio;
        }

        public Libro(String titulo, String apellido , String nombre , float precio) 
            : this(precio , titulo , new Autor(nombre , apellido))
        {
        }

        private static String Mostrar(Libro l)
        {
            StringBuilder str = new StringBuilder();
            String aux = "Libro sin crear..";
            
            if(!(l is null))
            {
                aux = l.autor;
                str.AppendLine($"Titulo: {l.titulo}\nPrecio: {l.precio}\nAutor: {aux}Cantidad Paginas: {l.CantidadPaginas}");
                aux = str.ToString();
            }
            return aux;
        }

        public static bool operator ==(Libro l1 , Libro l2)
        {
            bool ret = false;
            if(!(l1 is null) && !(l2 is null))
            {
                if(l1.titulo == l2.titulo && l1.autor == l2.autor)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public static implicit operator String(Libro l)
        {
            return Libro.Mostrar(l);
        }
    }
}
