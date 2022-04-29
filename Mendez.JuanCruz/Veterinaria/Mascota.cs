using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinaria
{
    public class Mascota
    {
        //fieldss
        private String nombreMascota;
        private MascotaTipo especie;
        private DateTime fechaNacimiento;
        private List<String> vacunas;
        
        //enum
        public enum MascotaTipo { Perro = 1, Gato = 2, Otro = 3 }

        //constructors
        public Mascota(String nombre, MascotaTipo especie, DateTime nacimiento)
        {
            this.nombreMascota = nombre;
            this.especie = especie;
            this.fechaNacimiento = nacimiento;
            this.vacunas = new List<String>();
        }

        //methods
        public String GetNombre()
        {
            return this.nombreMascota;
        }

        public MascotaTipo GetEspecie()
        {
            return this.especie;
        }

        public List<String> GetVacunas()
        {
            return this.vacunas;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        /// <summary>
        /// Setea una vacuna en el listado de vacunas de la mascota
        /// </summary>
        /// <param name="vacuna"></param>
        public void SetVacuna(string vacuna)
        {
            this.GetVacunas().Add(vacuna);
        }

        /// <summary>
        /// Devuelve toda la data de la mascota generada hasta el momento
        /// </summary>
        /// <returns></returns>
        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Nombre Mascota: {this.GetNombre()}\nEspecie: {this.GetEspecie()}\nEdad: {Mascota.CalcularEdadMascota(this.GetFechaNacimiento())}\n" +
                $"{this.GenerarListadoVacunas()}");

            return str.ToString();
        }

        /// <summary>
        /// Metodo de clase, recibe fecha nacimiento y calcula a partir de este, los años, en forma de int
        /// </summary>
        /// <param name="fechaNacim"></param>
        /// <returns></returns>
        public static Int32 CalcularEdadMascota(DateTime fechaNacim)
        {
            return DateTime.Today.AddTicks(-fechaNacim.Ticks).Year - 1;
        }

        /// <summary>
        /// Recorre el listado de vacunas y genera un listado a partir de las que tiene la mascota cargada
        /// </summary>
        /// <returns></returns>
        private String GenerarListadoVacunas()
        {
            StringBuilder str = new StringBuilder();

            if(this.GetVacunas().Count > 0)
            {
                str.AppendLine($"Vacunas de {this.GetNombre()}:");
                foreach(String aux in this.GetVacunas())
                {
                    str.AppendLine($"-{aux}");
                }
            }
            else
            {
                str.AppendLine("El pichicho no tiene vacunas todavia");
            }
            return str.ToString();
        }
    }

}
