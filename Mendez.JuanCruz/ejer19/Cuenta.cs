using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer19
{
    class Cuenta
    {
        //fields
        private String titular;
        private Double cantidad;

        //constr
        public Cuenta(String nombre, Double dinero)
        {
            this.titular = nombre;
            this.cantidad = dinero;
        }

        //getters
        public string GetTitular()
        {
            return this.titular;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }


        //methods
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Razon Social: {this.GetTitular()}\nCantidad Dinero En Cuenta: {this.GetCantidad()}");
            
            return str.ToString();
        }

        public void Ingresar(Double cantDinero)
        {
            if(cantDinero > -1)
            {
                this.cantidad += cantDinero;
            }
        }

        public void Retirar(Double cantDinero)
        {
            this.cantidad -= cantDinero;
        }

    }
}
