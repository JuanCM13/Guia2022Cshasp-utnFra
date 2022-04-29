using System;
using System.Collections.Generic;

namespace LibroIndexado
{
    public class Libro
    {
        private List<String> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public String this[Int32 pag]
        { 
            get 
            {
                if (pag > -1 && pag < this.paginas.Count)
                {
                    return this.paginas[pag];
                }

                return String.Empty;
            }

            set
            {
                if (pag > -1 && pag < this.paginas.Count)
                {
                    this.paginas[pag] = value;
                }
                else
                {
                    if(pag >= this.paginas.Count)
                    {
                        this.paginas.Add(value);
                    }
                }
            }
        }
    }
}
