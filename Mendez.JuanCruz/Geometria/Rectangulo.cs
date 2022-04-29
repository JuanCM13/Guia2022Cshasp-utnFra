using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vert1 , Punto vert3)
        {
            this.vertice1 = vert1;
            this.vertice3 = vert3;
            this.vertice2 = new Punto(vert3.GetX(), vert1.GetY());
            this.vertice4 = new Punto(vert1.GetX(), vert3.GetY());
            this.perimetro = 0;
            this.perimetro = 0;
        }

        public float Perimetro()
        {
            float ret;
            int basee;
            int altura;

            if(this.perimetro == 0)
            {
                basee = Math.Abs(this.vertice1.GetX() , this.vertice2.)
            }
        }


    }
}
