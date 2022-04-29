using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClaseshechoEnClase
{
    public class ClasePropia
    {
        public static string cadena;
        public static ConsoleColor color;

        public static string Mostrar()
        {
            return ClasePropia.Formato();
        }

        public static void Borrar()
        {
            ClasePropia.cadena = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = ClasePropia.color;
            Console.WriteLine(ClasePropia.Mostrar());

            Console.ResetColor();
        }

        private static string Formato()
        {
            StringBuilder str = new StringBuilder();
            string aux ="";
            string retorno;

            if (ClasePropia.TryParse(ClasePropia.cadena , out retorno))
            {
                for (int i = -1; i <= ClasePropia.cadena.Length; i++)
                {
                    aux += "*";
                }

                str.AppendLine(aux + "\n" + "*" + retorno + "*" + "\n" + aux);
            }
            else
            {
                str.AppendLine(" ");
            }

            return str.ToString();
        }

        private static bool TryParse(string dato , out string retorno)
        {
            bool ret = false;
            retorno = "";

            if(String.IsNullOrWhiteSpace(dato) == false)
            {
                retorno = dato;
                ret = true;
            }
            return ret;
        }
    }
}
