using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentosMusicales
{
    public class Trompeta :Instrumento
    {
        #region Campos
        private String clave;
        #endregion

        #region Constructores
        public Trompeta(String marca, Int32 codigo, Eclasificacion clasificacion, String clave)
            : base(marca, codigo, clasificacion)
        {
            this.clave = clave;
        }
        #endregion

        #region Metodos
        public String MostrarTrompeta()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{base.Mostrar()}Clave: {this.clave}");

            return str.ToString();
        }
        #endregion
    }
}
