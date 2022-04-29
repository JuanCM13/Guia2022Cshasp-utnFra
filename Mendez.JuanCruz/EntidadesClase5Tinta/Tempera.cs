using System;
using System.Text;

namespace EntidadesTinta
{
    /*
     * Tempera{
        (-)color : ConsoleColor
        (-)marca : String
        (-)cantidad : Int32
        //constructor 3 parámetros
        (-)Mostrar() : string//instancia
        (+)Mostrar(Tempera) : string//clase
        //sobrecargas
        == (Tempera, Tempera) : bool //marca y color
        implicit (Tempera) : int // cantidad
        + (Tempera, Tempera) : Tempera
        -> si temperas iguales, acumula cantidad
        + (Tempera, int) : Tempera
        -> acumula cantidad 
    }
     */
    public class Tempera
    {
        //fields
        private ConsoleColor color;
        private String marca;
        private Int32 cantidad;

        //constr
        public Tempera(ConsoleColor color , String marca , Int32 cantidadAagregar)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidadAagregar;
        }

        //methods
        private String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Color: {this.color}\nMarca: {this.marca}\nCantidad: {this.cantidad}");

            return str.ToString();
        }

        public static String Mostrar(Tempera t)
        {
            return t.Mostrar();
        }

        //overloads

        public static bool operator ==(Tempera t1 , Tempera t2)
        {
            bool ret = false;
            if( !(t1 is null) && !(t2 is null) )
            {
                if(t1.color == t2.color && t1.marca == t2.marca)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Tempera t1 , Tempera t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tempera t1)
        {
            return t1.cantidad;
        }

        public static Tempera operator +(Tempera t1 , Tempera t2)
        {
            Tempera ret = t1; //sino no me deja retornar
            Int32 cantTinta;
            if (t1 == t2)
            {
                cantTinta = t1.cantidad + t2; //creo que asi lo llamo al implicito, tengo que sumar entero + objeto y ahi me correria
                ret = new Tempera(t1.color, t1.marca, cantTinta);
            }
            return ret;
        }

        public static Tempera operator +(Tempera t1 , Int32 cant)
        {
            if( !(t1 is null) && cant > -1)
            {
                t1.cantidad += cant;
            }
            return t1;
        }

        public static Tempera operator -(Tempera t1, Int32 cant)
        {
            if (!(t1 is null) && cant > -1)
            {
                t1.cantidad -= cant;
            }
            return t1;
        }
    }
}
