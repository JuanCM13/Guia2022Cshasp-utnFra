using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentosMusicales
{
    public class Bateria :Instrumento
    {
        #region Campos
        private Int32 cuerpos;
        #endregion

        #region Constructores
        public Bateria(Int32 codigo , String marca , Eclasificacion tipoInstrumento , Int32 cantidadCuerpos)
        :base(marca , codigo , tipoInstrumento)
        {
            this.cuerpos = cantidadCuerpos;
        }
        #endregion

        #region Metodos
        public String MostrarBateria()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.Mostrar()}Cantidad Cuerpos Bateria: {this.cuerpos}");

            return str.ToString();
        }
        #endregion
    }
}
