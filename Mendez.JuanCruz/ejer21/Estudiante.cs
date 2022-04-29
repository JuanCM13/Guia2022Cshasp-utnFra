using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer21
{
    class Estudiante
    {
        //fields
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random; 

        //constr
        static Estudiante()
        {
            Estudiante.random = new Random();
        }

       /* public Estudiante() :this("Sin Asignar", "Sin Asignar", "Sin Asignar")
        {
        }*/

        public Estudiante(string ape, string leg, string nomb)
        {
            this.apellido = ape;
            this.legajo = leg;
            this.nombre = nomb;
            this.SetNotaPrimerParcial(0); //asumo que las inicializo por default aca :s
            this.SetNotaSegundoParcial(0);//asumo que las inicializo por default aca :s
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return ((this.notaPrimerParcial + this.notaSegundoParcial) / 2);
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if(this.notaPrimerParcial > 3 && this.notaSegundoParcial > 3)
            {
                notaFinal = Estudiante.random.Next(6, 10);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal(); //lo almaceno en un aux, asi no lo llamo a cada rato

            str.Append($"{this.nombre} , {this.apellido} , {this.legajo}\nPrimer Parcial: {this.notaPrimerParcial}\nSegundo Parcial: {this.notaSegundoParcial}\nPromedio: {this.CalcularPromedio()}\n");
            
            if(notaFinal != -1 )
            {
                str.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                str.AppendLine("Alumno Desaprobado");
            }

            return str.ToString();
        }
    }
}
