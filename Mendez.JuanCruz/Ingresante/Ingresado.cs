using System;
using System.Text;

namespace Ingresante
{
    public class Ingresado
    {
        //fields
        private String[] cursos;
        private String direccion;
        private Int32 edad;
        private String genero;
        private String nombre;
        private String pais;

        //constru
        public Ingresado(String[] cursos, String direccion, Int32 edad , String genero, String nombre, String pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        //methods
        public String Mostrar()
        {
            StringBuilder str = new StringBuilder();

            //interpolacion de strings, es ir metiendolos entre ${}
            str.Append($"Nombre: {this.nombre}\nDireccion: {this.direccion}\nEdad: {this.edad}\nGenero: {this.genero}\n");
            str.AppendLine($"Pais: {this.pais}\n Curso/s: \n{String.Join('\n', this.cursos)}");
            //a ver si funca el String.Join, en teoria tendria que hacer un string con todos los elementos
            //del array separados por lo que especifique yo, en este caso un \n o puedo probar con una ','

            return str.ToString();
        }
    }
}
