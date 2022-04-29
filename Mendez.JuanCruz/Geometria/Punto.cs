using System;

namespace Geometria
{
    public class Punto
    {
        private int y;
        private int x;

        public Punto(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
