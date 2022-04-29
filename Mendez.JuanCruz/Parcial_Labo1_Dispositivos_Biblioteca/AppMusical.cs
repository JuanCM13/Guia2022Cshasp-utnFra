using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispositivosBiblioteca
{
    public class AppMusical : Aplicacion
    {
        private List<String> listaCanciones;

        public override int Tamanio
        {
            get 
            {
                Int32 auxRet = this.tamanioMb;
                if(this.listaCanciones.Count > 0)
                {
                    auxRet +=  this.listaCanciones.Count * 2;
                }

                return auxRet; 
            }
        }

        public AppMusical(String nombre, SistemaOperativo sistema, Int32 tam)
            : this(nombre, sistema, tam , new List<string>() )
        {             
        }
        
        public AppMusical(String nombre, SistemaOperativo sistema, Int32 tam , List<String> lista)
            :base(nombre , sistema , tam)               
        {
            this.listaCanciones = lista;
        }

        public override String ObtenerInformacionApp()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.ObtenerInformacionApp()}Listado Canciones: \n");

            if(this.listaCanciones.Count > 0)
            {
                foreach (String item in this.listaCanciones)
                {
                    str.AppendLine(item);
                }
            }
            else
            {
                str.AppendLine("No hay canciones cargadas al momento!");
            }

            return str.ToString();
        }

    }
}
