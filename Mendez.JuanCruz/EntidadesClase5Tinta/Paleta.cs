using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTinta
{
    public class Paleta
    {
        //fields
        private List<Tempera> temperas;
        private Int32 cantidadMaximaColores;

        //Construc
        private Paleta()
        {
            this.temperas = new List<Tempera>();
        }

        public Paleta(Int32 cantidadMaxColores) :this()
        {
            this.cantidadMaximaColores = cantidadMaxColores;
        }

        //overloads

        public static implicit operator Paleta(Int32 cantidad)
        {
            return new Paleta(cantidad);           
        }

        public static explicit operator String(Paleta p)
        {
            String ret = String.Empty;
            if( !(p is null) )
            {
                ret = p.Mostrar();
            }
            return ret;
        }

        //methods

        private String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            foreach(Tempera temp in this.temperas)
            {
                str.AppendLine($"{Tempera.Mostrar(temp)}"); 
            }

            return str.ToString();
        }

        private Int32 ObtenerIndice(Tempera t)
        {
            Int32 counter = 0;
            Int32 ret = -1; //no se encontro o vino nullo

            if( !(t is null) )
            {
                foreach (Tempera temp in this.temperas)
                {
                    if (temp == t)
                    {
                        ret = counter;
                        break;
                    }
                    counter++;
                }
            }

            return ret;
        }

        //operators overload 

        //== \ !=

        public static bool operator ==(Paleta p , Tempera t)
        {
            bool ret = false;
            if( (!(p is null)) && p.ObtenerIndice(t) > -1)
            {
                ret = true;
            }
            return ret;
        }

        public static bool operator !=(Paleta p , Tempera t)
        {
            return !(p == t);
        }

        // + / -

        public static Paleta operator +(Paleta p , Tempera t)
        {
            Int32 indexTempera;
            if(p == t) //esto estaria de mas, total ya se filtra que sea igual en el Tempera + Tempera
            {
                indexTempera = p.ObtenerIndice(t);
                //a la posision donde se almacena el elemento, le asigno el resultado de la suma de su cant + la de t
                p.temperas[indexTempera] = p.temperas[indexTempera] + t;           
            }
            else
            {
                if(p.temperas.Count+1 <= p.cantidadMaximaColores)
                {
                    p.temperas.Add(t);                    
                }
            }
            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            Int32 index;
            if(p == t)
            {
                index = p.ObtenerIndice(t);
                if(p.temperas[index] > 0) //se tendria que hacer la conversion implicita y devolverme directamente la cantidad
                {
                    /*Aca nose que onda, no tengo un metodo Tinta - Tinta, y el atributo cantidad no puedo invocarlo,
                        asumo que tengo que referenciar el indice index, a una Tempera nueva y a cantidad le asigno
                        la nueva cantidad :s */
                    p.temperas[index] = p.temperas[index] - t;
                }

                //si no lo hacia en un if separado, si por ejemplo me restaba la cantidad total de una, despues al mostrarlo
                //me quedaba cargado (no removeaba el elemento) yquedaba cargado en 0, lo cual no creo que sea correcto.
                //asi me aseguro que apenas sale de la resta si es menor a 1 ya elimino el elemento no espero a la proxima
                //vez que quiera restarle algo..
                if(p.temperas[index] < 1)
                {
                    p.temperas.Remove(p.temperas[index]);
                }                               
            }
            return p;
        }

        /*
        public static Paleta operator +(Paleta p1 , Paleta p2)
        {
            if( !(p1 is null) && !(p2 is null))
            {
                for(int i=0; i<p2.temperas.Count; i++)
                {
                    p1 = p1 + p2.temperas[i];
                }
            }
            return p1;
        }
        */

        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta pAux = null;
            if (!(p1 is null) && !(p2 is null))
            {
                pAux = p1.temperas.Count + p1.temperas.Count;

                pAux.temperas.AddRange(p1.temperas); //copio ya de una la p1 a la nueva lista, total p1 no puede tener elementos repetidos

                //aca ya itero, la segunda lista, reutilizando el Paleta + Tinta, que ya setea si no esta, o agrega tinta si ya existe..
                foreach(Tempera tAux in p2.temperas)
                {
                    pAux = pAux + tAux;
                }
            }
            return pAux;
        }
    }
}
