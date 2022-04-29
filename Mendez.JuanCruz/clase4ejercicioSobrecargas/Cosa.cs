using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase4ejercicioSobrecargas
{
    class Cosa
    {
        //fields
        private int entero;
        private string cadena;
        private DateTime fecha;

        //constrr
        public Cosa()
        {
            this.entero = 10;
            this.cadena = String.Empty;
            this.fecha = DateTime.Now;
        }

        public Cosa(string cadena) :this()
        {
            this.cadena = cadena;
        }

        public Cosa(int num, string cadena) :this(cadena)
        {
            this.entero = num;
        }

        public Cosa(DateTime fecha, int num, string cadena) : this(num, cadena)
        {
            this.fecha = fecha;
        }

        public void EstablecerValor(int num)
        {
            this.entero = num;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        private string Mostrar()
        {
            string aux = this.entero + "\n" + this.cadena + "\n" + this.fecha;

            return aux;
        }

        public static string Mostrar(Cosa dato)
        {
            return dato.Mostrar();
        }
    }
}
