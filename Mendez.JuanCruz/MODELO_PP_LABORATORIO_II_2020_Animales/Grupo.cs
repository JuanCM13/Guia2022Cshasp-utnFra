using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialAnimales
{
    public class Grupo
    {
        private List<Mascota> manada;
        private String nombre;
        private static EtipoManada tipo;

        public EtipoManada Tipo
        {
            set { Grupo.tipo = value; }
        }

        static Grupo()
        {
            Grupo.tipo = EtipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(String nombre) :this()
        {
            this.nombre = nombre;
        }

        public Grupo(String nombre , EtipoManada tipo) :this(nombre)
        {
            this.Tipo = tipo;
        }

        public static bool operator ==(Grupo grupo , Mascota mascota)
        {
            bool ret = false;
            if(!(grupo is null) && !(mascota is null))
            {
                foreach(Mascota item in grupo.manada)
                {
                    if(item.Equals(mascota)) //acordate en este caso de usar el equals sobreescrito
                    {                       //sino el == va a evaluarlo como Mascota, y nosotros necesitamos que depende el caso
                        ret = true;         //si es perro evalue si la mascota es perro y llame a ese == y lo mismo con gato
                        break;              //el equals como labura polimorficamente hace eso, no tenemos que castear ni nada
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Grupo grupo, Mascota mascota)
        {
            return !(grupo == mascota);
        }


        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {
            if (!(grupo is null) && !(mascota is null))
            {
                if(grupo != mascota)
                {
                    grupo.manada.Add(mascota);
                }
                else
                {
                    Console.WriteLine($"Ya esta en la manada , {mascota}");
                }
            }
            else
            {
                Console.WriteLine("ALGO FALLO..");
            }
            return grupo;
        }

        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            Int32 counter;
            if (!(grupo is null) && !(mascota is null))
            {
                counter = 0;
                if (grupo == mascota)
                {
                    foreach(Mascota item in grupo.manada)
                    {                        
                        if(item == mascota)
                        {
                            grupo.manada.RemoveAt(counter);
                            break;
                        }
                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine($"No existe esa mascota en la lista , {mascota}..");
                }
            }
            else
            {
                Console.WriteLine("ALGO FALLO..");
            }

            return grupo;
        }

        public static implicit operator String(Grupo g)
        {
            StringBuilder str = new StringBuilder();
            if(!(g is null))
            {
                str.AppendLine($"Grupo: {g.nombre} - tipo: {Enum.GetName(Grupo.tipo)}");
                str.AppendLine($"Integrantes: {g.manada.Count()}");

                if(g.manada.Count > 0)
                {
                    foreach(Mascota item in g.manada)
                    {
                        str.AppendLine(item.ToString());
                    }
                }
            }
            else
            {
                str.AppendLine("El objeto no se instancio..");
            }

            return str.ToString();
        }

    }
}
