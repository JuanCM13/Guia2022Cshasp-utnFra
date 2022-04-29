using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnciendanSusMotores
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private static Random auxR;


        static Competencia()
        {
            Competencia.auxR = new Random();
        }

        private Competencia()
        {
            this.competidores = new List<AutoF1>();            
        }

        public Competencia(short cantCompe , short cantidVuelta):this()
        {
            this.cantidadCompetidores = cantCompe;
            this.cantidadVueltas = cantidVuelta;
        }

        public String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Cantidad Competidores: {this.cantidadCompetidores}\nCantidad Vueltas: {this.cantidadVueltas}");
            if(this.competidores.Count > 0)
            {
                foreach(AutoF1 item in this.competidores)
                {
                    str.AppendLine(item.MostrarDatos());
                }
            }
            else
            {
                str.AppendLine("Sin competidores al momento..");
            }

            return str.ToString();
        }

        public static bool operator ==(Competencia com , AutoF1 au)
        {
            bool ret = false;

            if(!(com is null) && !(au is null))
            {
                foreach(AutoF1 item in com.competidores)
                {
                    if(item == au)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Competencia com, AutoF1 au)
        {
            return !(com == au);
        }

        public static bool operator +(Competencia com, AutoF1 au)
        {
            bool ret = false;

            if (!(com is null) && !(au is null))
            {
                if(com.competidores.Count +1 <= com.cantidadCompetidores && com != au)
                {
                    au.CantidadCombustible = (short)Competencia.auxR.Next(15, 100);
                    au.EnCompetencia = true;
                    au.VueltasRestantes = com.cantidadVueltas;
                    com.competidores.Add(au);
                    ret = true;
                }
            }
            return ret;
        }

        public static bool operator -(Competencia com, AutoF1 au)
        {
            bool ret = false;
            Int32 counter;

            if (!(com is null) && !(au is null))
            {
                if(com == au)
                {
                    counter = 0;
                    foreach(AutoF1 item in com.competidores)
                    {
                        if(item == au)
                        {
                            com.competidores.RemoveAt(counter);
                            ret = true;
                            break;
                        }
                        counter++;
                    }
                }
            }
            return ret;
        }

    }
}
