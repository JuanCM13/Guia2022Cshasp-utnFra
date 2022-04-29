using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentosMusicales
{
    public class CasaDeMusica
    {
        #region Campos
        private List<Instrumento> lista;
        private Int32 cantidadMaxima;
        #endregion

        #region Constructores
        public CasaDeMusica()
        {
            this.lista = new List<Instrumento>();
        }

        public CasaDeMusica(Int32 cantidad) :this()
        {
            this.cantidadMaxima = cantidad;
        }
        #endregion

        #region Propiedad
        public List<Instrumento> Lista
        {   
            get
            {               
                if(!(this.lista is null))
                {
                    return this.lista;
                }
                return null;
            }
        }
        #endregion

        #region Metodos
        public String Mostrar()
        {
            String ret = "La lista no tiene elementos cargados al momento..";
            StringBuilder str;

            if((this.Lista.Count > 0))
            {
                str = new StringBuilder();
                foreach(Instrumento ins in this.Lista)
                {
                    if(ins is Guitarra)
                    {
                        str.AppendLine(((Guitarra)ins).MostrarGuitarra());
                    }
                    else
                    {
                        if(ins is Trompeta)
                        {
                            str.AppendLine(((Trompeta)ins).MostrarTrompeta());
                        }
                        else
                        {
                            if (ins is Bateria)
                            {
                                str.AppendLine(((Bateria)ins).MostrarBateria());
                            }
                            else
                            {
                                str.AppendLine(ins.Mostrar());
                            }
                        }
                    }
                }
                ret = str.ToString();
            }
            return ret;
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(CasaDeMusica casa , Instrumento ins)
        {
            bool ret = false;
            if(!(casa is null) && !(ins is null))
            {
                foreach(Instrumento instrumento in casa.Lista)
                {
                    if(instrumento == ins)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(CasaDeMusica casa, Instrumento ins)
        {
            return !(casa == ins);
        }

        public static CasaDeMusica operator +(CasaDeMusica casa , Instrumento ins)
        {
            if(casa != ins && casa.Lista.Count+1 <= casa.cantidadMaxima)
            {
                casa.Lista.Add(ins);
            }

            return casa;
        }

        public static CasaDeMusica operator -(CasaDeMusica casa, Instrumento ins)
        {
            if(!(casa is null) && !(ins is null))
            {
                for (Int32 i = 0; i < casa.Lista.Count; i++)
                {
                    if (casa.Lista[i] == ins)
                    {
                        casa.Lista.RemoveAt(i);
                        break;
                    }
                }
            }
            return casa;
        }

            #endregion


    }
}
