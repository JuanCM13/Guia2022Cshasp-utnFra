using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentosMusicales
{
    public class Guitarra :Instrumento
    {
        #region Campos
        private Int32 cantidadCuerdas;
        #endregion

        #region Constructores
        public Guitarra(Int32 codigo , String marca , Int32 cantCuerdas , Eclasificacion tipoInstrumento , ETipoGuitarra tipoGuitarra)
            :base(marca , codigo , tipoInstrumento)
        {
            this.cantidadCuerdas = cantCuerdas;
            this.TipoGuitarra = tipoGuitarra;
        }

        public Guitarra(Eclasificacion tipoInstrumento, ETipoGuitarra tipoGuitarra, Int32 codigo, String marca, Int32 cantCuerdas)
         :this(codigo, marca , cantCuerdas , tipoInstrumento , tipoGuitarra)
        {
        }
        #endregion

        #region Props
        protected ETipoGuitarra TipoGuitarra { get; set; }
        #endregion

        #region Metodos
        public String MostrarGuitarra()
        {
            StringBuilder str = new StringBuilder();
           
            str.AppendLine($"{base.Mostrar()}Tipo Guitarra: {Enum.GetName(this.TipoGuitarra)}\nCantidad Cuerdas: {this.cantidadCuerdas}");
           
            return str.ToString();
        }
        #endregion
    }
}
