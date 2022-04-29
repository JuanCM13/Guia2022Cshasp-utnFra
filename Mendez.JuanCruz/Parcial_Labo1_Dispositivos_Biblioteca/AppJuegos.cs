using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispositivosBiblioteca
{
    public class AppJuegos : Aplicacion
    {
        public AppJuegos(String nombre , SistemaOperativo sistema , Int32 tam)
            :base(nombre , sistema , tam)
        {
        }

        public override int Tamanio
        {
            get { return this.tamanioMb; }
        }
    }
}
