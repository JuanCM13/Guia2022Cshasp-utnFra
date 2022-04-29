using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer20PostaElOtroNoCompila
{
    class Persona
    {
        //fields
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        //constr

        public Persona() : this("Sin asignar", new DateTime(1910,01,01), 0)
        {
        }

        public Persona(string nombre, DateTime fechaN, int dni)
        {
            this.SetNombre(nombre);
            this.SetFechaNacimiento(fechaN);
            this.SetDni(dni);
        }

        //getters//setters

        public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaNacimiento(DateTime fecha)
        {
            this.fechaNacimiento = fecha;
        }

        public void SetDni(int dato)
        {
            this.dni = dato;
        }

        //methods

        public int CalcularEdad()
        {
            DateTime fActual = DateTime.Now;

            //lo copie de stack, preguntar como lo calcula...
            return DateTime.Today.AddTicks(-this.GetFechaNacimiento().Ticks).Year - 1;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Nombre: {this.GetNombre()}\nEdad: {this.CalcularEdad()}\nDni: {this.GetDni()}");

            return str.ToString();
        }

        public string EsMayor()
        {
            String ret = "Es menor de edad";

            if (this.CalcularEdad() > 17)
            {
                ret = "Es mayor de edad";
            }

            return ret;
        }
    }
}
