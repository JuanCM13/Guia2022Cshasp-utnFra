using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Dueño
    {
        //fields
        private String nombreDueño;
        private String domicilio;
        private Int32 telefono;
        private List<Mascota> mascotas;

        //constructors
        private Dueño()
        {
            this.NombreD = "Sin Asignar";
            this.Domicilio = "Sin Asignar";
            this.Telefono = 00000000;
            this.mascotas = new List<Mascota>();
        }

        public Dueño(String nombre , Int32 telefono) :this()
        {
            this.NombreD = nombre;
            this.Telefono = telefono;
        }

        public Dueño(String nombre, String direccion , Int32 telefono) :this(nombre , telefono)
        {
            this.Domicilio = direccion;
        }

        //props
        public string NombreD
        {
            get { return this.nombreDueño; }
            set { this.nombreDueño = value; }
        }

        public string Domicilio
        {
            get { return this.domicilio; }
            set { this.domicilio = value; }
        }

        public Int32 Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        //methods

        /// <summary>
        /// Agrega una mascota al listado de mascotas del dueño
        /// </summary>
        /// <param name="pichico"></param>
        public void AddMascota(Mascota pichico)
        {
            this.mascotas.Add(pichico);
        }

        /// <summary>
        /// Genera un string con todos los datos de mascotas e usuario, evalua cada caso si no tiene mascotas etc
        /// </summary>
        /// <returns></returns>
        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Dueño: {this.NombreD}\nDomicilio: {this.Domicilio}\nTelefono: {this.Telefono}\n{this.ListarMascotas()}");

            return str.ToString();
        }

        /// <summary>
        /// Genera un listado tipo string de todas las mascotas y la data de estos, del dueño
        /// </summary>
        /// <returns></returns>
        private String ListarMascotas()
        {
            StringBuilder str = new StringBuilder();

            if(this.mascotas.Count > 0)
            {
                for(int i=0; i<this.mascotas.Count; i++)
                {
                    str.AppendLine($"{this.mascotas.ElementAt(i).Mostrar()}");
                }
            }
            else
            {
                str.AppendLine("-Sin mascotas cargadas al momento-");
            }

            return str.ToString();
        }

    }
}
