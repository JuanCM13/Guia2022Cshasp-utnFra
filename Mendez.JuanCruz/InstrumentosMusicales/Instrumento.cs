using System;
using System.Text;

namespace InstrumentosMusicales
{
    public class Instrumento
    {
        #region Fields
        protected String marca;
        protected Int32 codigo;
        #endregion

        #region Constructores

        public Instrumento(String marca, Int32 codigo)
        {
            this.marca = marca;
            this.codigo = codigo;
        }

        public Instrumento(String marca, Int32 codigo, Eclasificacion instrumento) : this(marca, codigo)
        {
            this.Clasificacion = instrumento;
        }

        #endregion

        #region Props
        protected Eclasificacion Clasificacion { get; set; }

        #endregion

        #region metodos
        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();
            String tipoInstrumento = Enum.GetName(this.Clasificacion);

            if (String.IsNullOrEmpty(tipoInstrumento))
            {
                tipoInstrumento = "Sin Especificar";
            }
            str.AppendLine($"Marca: {this.marca}\nCodigo: {this.codigo}\nTipo: {tipoInstrumento}");

            return str.ToString();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Instrumento i1, Instrumento i2)
        {
            bool ret = false;
            if (!(i1 is null) && !(i2 is null))
            {
                if (i1.codigo == i2.codigo)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator !=(Instrumento i1, Instrumento i2)
        {
            return !(i1 == i2);
        }
        #endregion
    }
}




