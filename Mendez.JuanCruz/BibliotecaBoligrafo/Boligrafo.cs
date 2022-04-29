using System;

namespace BibliotecaBoligrafo
{
    public class Boligrafo
    {
        //fields
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
    
        //cons
        public Boligrafo(short tinta , ConsoleColor color)
        {
            if(tinta >= Boligrafo.cantidadTintaMaxima)
            {
                tinta = Boligrafo.cantidadTintaMaxima;
            }

            if(tinta < 0)
            {
                tinta = 0;
            }

            this.tinta = tinta;
            this.color = color;
        }

        //getters
        public short GetTinta()
        {
            return this.tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        private void SetTinta(short cantidad)
        {
            short cantidadResultante = (short) (this.GetTinta() + (cantidad));
            if(cantidadResultante > -1 && cantidadResultante < Boligrafo.cantidadTintaMaxima+1 )
            {
                this.tinta = cantidadResultante;
            }
        }

        public void Recargar()
        {
            //this.tinta = Boligrafo.cantidadTintaMaxima; yo decia hacerlo asi, pero como dice reutilizar codigo
            //mepa que se hace como lo hago abajo

            this.SetTinta( (short)(Boligrafo.cantidadTintaMaxima - this.GetTinta()) );
        }
        /// <summary>
        /// Recorre restandole 1 a la cantidad de tinta (siempre y cuando sea mayor de 0) hasta que se agote o la tinta
        /// o se logre gastar todo lo que el usuario ingreso, por cada vuelta va poniendo una * que marca cuanto logro
        /// imprimir y retorna true.
        /// </summary>
        /// <param name="gasto">Cantidad de tinta a imprimir</param>
        /// <param name="dibujo">auxiliar donde se va a guardar la cantidad que se imprimio en * </param>
        /// <returns>true si logra imprimir al menos un *, sino false</returns>
        public bool Pintar(short gasto , out string dibujo)
        {
            bool ret = false;
            string aux = String.Empty;

            if (this.tinta > 0)
            {
                ret = true;
                for (int i = gasto; i > 0 ; i--)
                {
                    if (this.tinta == 0)
                    {
                        break;
                    }

                    aux += "*";
                    this.SetTinta(-1);
                }
                Console.ForegroundColor = this.GetColor();
            }

            dibujo = aux;
            return ret;
        }
    }
}
