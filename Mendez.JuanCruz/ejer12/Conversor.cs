using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    class Conversor
    {
        public static int ConversorB_D(string binario)
        {
            Int32 num;
            String caracter;
            Double acum = 0;
            Int32 posision = 0; //asi multiplica el ultimo elemento del string, en la base 0, despues el anteultimo *1 etc

            for(int i= binario.Length-1 ; i>=0 ; i--)
            {
                caracter = binario.Substring(i, 1);
                if(int.TryParse(caracter , out num))
                {
                    acum += (num * Math.Pow(2, posision));
                }
                posision++; //tengo que hacerlo con una var auxiliar, sino de la manera que lo plante, me va a
                //multiplicar al revez en vez de arrancar en cero desde el ultimo la multiplicacion, lo arranca en 6...
            }

            return (int)acum;
        }

        public static string ConversorD_B(Int32 numero)
        {
            string aux = "";
            Int32 auxN;
            Int32 auxDato = numero;
            string retornoDadoVuelta = "";
            do
            {
                auxN = (auxDato % 2);
                aux += auxN.ToString();

                auxDato = auxDato / 2;

                /*if(auxDato == 1)
                {
                    aux += "1";
                    break;
                }*/

            } while (auxDato > 0);


            for(int j=aux.Length-1 ; j>-1; j--)
            {
                retornoDadoVuelta += aux[j];
            }

            return retornoDadoVuelta;
        }

        
    }
}
