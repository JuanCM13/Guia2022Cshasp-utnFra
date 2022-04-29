using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamionerosMoyano
{
    public class EmpresaCamiones
    {
        private String nombreEmpresa;
        private List<Camionero> lista;

        public EmpresaCamiones(String nombre)
        {
            this.nombreEmpresa = nombre;
            this.lista = new List<Camionero>();
        }

        /// <summary>
        /// Devuelve el nombre de la empresa
        /// </summary>
        /// <returns></returns>
        public String GetNombreEmpresa()
        {
            return this.nombreEmpresa;
        }

        /// <summary>
        /// Devuelve la lista
        /// </summary>
        /// <returns></returns>
        public List<Camionero> GetListaCamioneros()
        {
            return this.lista;
        }

        /// <summary>
        /// Agrega un camionero a la lista
        /// </summary>
        /// <param name="chofer"></param>
        public void AgregarCamionero(Camionero chofer)
        {
            this.GetListaCamioneros().Add(chofer);
        }

        /// <summary>
        /// Evalua que chofer recorrio mas kilometros acumulados en la semana
        /// </summary>
        /// <returns></returns>
        public String MostrarChoferConMasKilometros()
        {
            Camionero camioneroMaximo = null;
            float maximoKmSemana = 0;
            float kilometrosAevaluar;
            StringBuilder retorno = new StringBuilder(); 

            if(this.GetListaCamioneros().Count > 0)
            {
                for (int i = 0; i < (this.GetListaCamioneros().Count); i++)
                {
                    kilometrosAevaluar = (this.GetListaCamioneros().ElementAt(i)).AcumuladoKilometros();

                    if (i == 0 || maximoKmSemana < kilometrosAevaluar)
                    {
                        camioneroMaximo = (this.GetListaCamioneros().ElementAt(i));
                        maximoKmSemana = kilometrosAevaluar;
                    }
                }

                retorno.AppendLine($"El camionero mas groso es: {camioneroMaximo.GetNombre()}, recorrio un total de: {maximoKmSemana} Kms en toda la semana");
            }
            else
            {
                retorno.AppendLine("Todavia no se ingresaron camioneros al listado..");
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Muestra el chofer con mas kilometros recorridos en x dia
        /// </summary>
        /// <param name="diaAbuscar"></param>
        /// <returns></returns>
        public String MostrarChoferConMasKilometros(int diaAbuscar)
        {
            Camionero camioneroMaximo = null;
            float cantKilometros = 0;
            float maximaCantidadKilometros = 0;
            StringBuilder retorno = new StringBuilder();

            if(this.GetListaCamioneros().Count > 0)
            {
                for (int i = 0; i < (this.GetListaCamioneros().Count) ; i++)
                {
                    cantKilometros = (this.GetListaCamioneros().ElementAt(i)).KilometrosRecorridos(diaAbuscar);
                    if (i == 0 || maximaCantidadKilometros < cantKilometros)
                    {
                        maximaCantidadKilometros = cantKilometros;
                        camioneroMaximo = this.GetListaCamioneros().ElementAt(i);
                    }
                }
                retorno.AppendLine($"El camionero mas groso el dia {diaAbuscar}, es: {camioneroMaximo.GetNombre()}, este recorrio: {maximaCantidadKilometros} Kms ese dia...");
            }
            else
            {
                retorno.AppendLine("Todavia no se ingresaron camioneros al listado..");
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Devuelve string de data de todos los choferes, toda la semana y agrega nombre empresa, este es publico
        /// </summary>
        /// <returns></returns>
        public String MostrarData()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.GetNombreEmpresa()}:");

            if(this.GetListaCamioneros().Count > 0)
            {
                str.AppendLine(this.GenerarDataChoferes());
            }
            else
            {
                str.AppendLine("No se ingresaron choferes al momento..");
            }

            return str.ToString();
        } 

        /// <summary>
        /// Genera data de x dia de todos los camioineros cargados..
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        public String MostrarData(int dia)
        {
            StringBuilder str = new StringBuilder();

            for(int i=0; i<this.GetListaCamioneros().Count; i++)
            {
                str.Append(this.GetListaCamioneros().ElementAt(i).MostrarData(dia));
            }

            return str.ToString();
        }

        /// <summary>
        /// Genera string de data semanal de todos los choferes
        /// </summary>
        /// <returns></returns>
        private String GenerarDataChoferes()
        {
            StringBuilder str = new StringBuilder();

            for(int i=0; i< this.GetListaCamioneros().Count; i++)
            {
                str.AppendLine((this.GetListaCamioneros().ElementAt(i).MostrarData()));
            }
            return str.ToString();
        }

    }
}
