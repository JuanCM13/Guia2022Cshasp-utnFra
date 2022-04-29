using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispositivosBiblioteca
{
    public static class Dispositivo
    {
        private static List<Aplicacion> aplicacionesInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            Dispositivo.aplicacionesInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            bool ret = false;
            if(!(app is null))
            {
                if(app.SistemaOperativo == Dispositivo.sistemaOperativo)
                {
                    ret = Dispositivo.aplicacionesInstaladas + app;
                }
            }
            return ret;
        }

        public static String ObtenerInformacionDispositivo()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"SO del dispositivo: {Enum.GetName(Dispositivo.sistemaOperativo)}");
            str.AppendLine("APLICACIONES INSTALADAS: \n");
        
            if(Dispositivo.aplicacionesInstaladas.Count > 0)
            {
                foreach(Aplicacion app in Dispositivo.aplicacionesInstaladas)
                {
                    str.AppendLine(app.ObtenerInformacionApp());
                }
            }
            else
            {
                str.AppendLine("Sin aplicaciones al momento..");
            }

            return str.ToString();
        }
    }
}
