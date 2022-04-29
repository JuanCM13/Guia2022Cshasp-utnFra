using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private Int32 capacidad;
        private List<Libro> libros;
    
        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }

        private Biblioteca(Int32 capacidad) :this()
        {
            this.capacidad = capacidad;
        }
        
        public double PrecioDeManuales
        {
            get 
            {
                return this.ObtenerPrecio(ELibro.PrecioManuales);
            }
        }

        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioNovelas);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this.ObtenerPrecio(ELibro.PrecioTotal);
            }
        }

        public static implicit operator Biblioteca(Int32 capacidad)
        {
            return new Biblioteca(capacidad);
        }

        public static bool operator ==(Biblioteca bib , Libro lib)
        {
            bool ret = false;
            if(!(bib is null) && !(lib is null))
            {
                ret = bib.libros.Contains(lib);
            }
            return ret;
        }

        public static bool operator !=(Biblioteca bib, Libro lib)
        {
            return !(bib == lib);
        }

        public static Biblioteca operator +(Biblioteca bib, Libro lib)
        {
            if( (bib is not null) && !(lib is null))
            {
                if(bib.libros.Count < bib.capacidad)
                {
                    if(bib != lib)
                    {
                        bib.libros.Add(lib);
                    }                    
                    else
                    {
                        Console.WriteLine("Ya esta cargado en la lista!!");
                    }
                }
                else
                {
                    Console.WriteLine("No hay mas lugar en la lista!!");
                }
            }

            return bib;
        }

        public static String Mostrar(Biblioteca bib)
        {
            StringBuilder str = new StringBuilder();

            if(!(bib is null))
            {
                str.AppendLine($"Capacidad Biblioteca: {bib.capacidad} Libros");

                if (bib.libros.Count > 0)
                {
                    str.AppendLine($"Total por Manuales: {bib.PrecioDeManuales}\nTotal por Novelas: {bib.PrecioDeNovelas}");
                    str.AppendLine($"Total facturado: {bib.PrecioTotal}");                 

                    str.AppendLine("---------------------------------------------------------------------------");
                    str.AppendLine("                            Listado Libros");
                    str.AppendLine("---------------------------------------------------------------------------\n");
                    
                    foreach (Libro item in bib.libros)
                    {
                        str.Append(item.ToString()); 
                    }
                }
                else
                {
                    str.AppendLine("Sin libros al momento..");
                }
            }
            else
            {
                str.AppendLine("El objeto biblioteca no existe...");
            }
           

            return str.ToString();
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            Single acum = 0;
            Int32 tipo = (Int32)tipoLibro;

            foreach(Libro lib in this.libros)
            {
                if(lib is Manual && (tipo == 0 || tipo == 2)) //lo mismo que poner tipo == eTipo.Manual etc
                {
                    acum += (Single)((Manual)lib);
                }
                else
                {
                    if(lib is Novela && (tipo == 1 || tipo == 2))
                    {
                        acum += (Single)((Novela)lib);
                    }
                }
            }

            return acum;

        }
    }
}
