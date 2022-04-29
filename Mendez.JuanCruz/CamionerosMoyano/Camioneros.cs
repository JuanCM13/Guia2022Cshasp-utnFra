using System;
using System.Text;

namespace CamionerosMoyano
{
    public class Camionero
    {
        private String nombre;
        Single[] kilometrosXdia;

        public Camionero(String nombre)
        {
            this.nombre = nombre;
            this.kilometrosXdia = new Single[7] { -1 , -1, -1, -1, -1, -1, -1 };
        }

        /// <summary>
        /// Devuelve el nombre del chofer cargado en memoria en el momento
        /// </summary>
        /// <returns></returns>
        public string GetNombre()
        {
            return this.nombre;
        }

        /// <summary>
        /// Setea los kilometros recorridos por chofer en x dia
        /// </summary>
        /// <returns></returns>
        public bool SetKilometrosDia(Int32 dia , Single cantKilometros)
        {
            bool ret = false;

            if( this.EstaEnRango(dia) && cantKilometros > -1 )
            {
                this.kilometrosXdia.SetValue(cantKilometros, dia - 1);
                ret = true;
            }
            return ret;
        }

        /// <summary>
        /// Devuelve data de kilometros recorridos entre x e y dia
        /// </summary>
        /// <param name="desde"></param>
        /// <param name="hasta"></param>
        /// <returns></returns>
        public string MostrarData(Int32 desde , Int32 hasta)
        {
            StringBuilder semanaLaburada = new StringBuilder();

            semanaLaburada.AppendLine($"Chofer: {this.nombre}:"); //no llamo al MostrarData(diaEspecifico), asi no me
            for(int i= desde; i< hasta+1; i++)                  //tira el nombre del chofer en cada dia recorrido..
            {                                                   //por eso lo hice aparte
                semanaLaburada.Append(this.GenerarDataXdia(i));    
            }

            return semanaLaburada.ToString();
        }
         
        /// <summary>
        /// Devuelve data de kilometros recorridos en un dia especifico del chofer a evaluar
        /// </summary>
        /// <param name="diaEspecifico"></param>
        /// <returns></returns>
        public string MostrarData(Int32 diaEspecifico)
        {
            StringBuilder dia = new StringBuilder();

            dia.AppendLine($"Nombre: {this.nombre}:\n{this.GenerarDataXdia(diaEspecifico)}");

            return dia.ToString();
        }

        /// <summary>
        /// Muestrea la data de toda la semana
        /// </summary>
        /// <returns></returns>
        public string MostrarData()
        {
            return this.MostrarData(1, 7);
        }

        /// <summary>
        /// Genera un string con la informacion x dia de un chofer, evalua caso de que sea franco, o el dia no este 
        /// cargado...
        /// </summary>
        /// <param name="indexDia"></param>
        /// <returns></returns>
        private string GenerarDataXdia(int indexDia)
        {
            StringBuilder str = new StringBuilder();
            int indice;

            if (EstaEnRango(indexDia))
            {
                indice = indexDia - 1;
                
                if(this.kilometrosXdia[indice] == -1)
                {
                    str.AppendLine("Sin asignar...");
                }
                else
                {
                    if (this.kilometrosXdia[indice] > 0)
                    {
                        str.AppendLine($"Dia: {indexDia}: {this.kilometrosXdia[indice]} Kms");
                    }
                    else
                    {
                        str.AppendLine($"Dia: {indexDia}: Tiene Franco");
                    }
                }
            }  

            return str.ToString();
        }

        /// <summary>
        /// Evalua si el dia pasado por parametro esta en el rango de  1 A  7
        /// </summary>
        /// <param name="dia"></param>
        /// <returns></returns>
        private bool EstaEnRango(Int32 dia)
        {
            bool ret = false;
            if(dia > 0 && dia < 8)
            {
                ret = true;
            }
            return ret;
        }
        
        /// <summary>
        /// Devuelve el mayor kilometraje recorrido esa semana
        /// </summary>
        /// <returns>Mejor kilometraje</returns>
        public float KilometrosRecorridos()
        {
            float mejorDia = -1;
            float auxKms;

            for(int i=1; i<=7; i++)
            {
                auxKms = this.KilometrosRecorridos(i);
                if(i == 1 || mejorDia < auxKms)
                {
                    mejorDia = auxKms;
                }
            }

            return mejorDia;
        }

        /// <summary>
        /// Devuelve el kilometraje en x dia
        /// </summary>
        /// <param name="dia">dia a retornar</param>
        /// <returns>kilometraje , si esta vacio retorna -1 (que inicializa por default el array)</returns>
        public float KilometrosRecorridos(int dia)
        {
            float auxKms = -1;
            if(EstaEnRango(dia))
            {
                auxKms = this.kilometrosXdia[dia - 1];
            }

            return auxKms;
        }

        /// <summary>
        /// Devuelve el acumulado de todos los kms recorridos en la semana del chofer...
        /// </summary>
        /// <returns></returns>
        public float AcumuladoKilometros()
        {
            float acum = 0; 
            for(int i=1; i<=7; i++)
            {
                if(this.KilometrosRecorridos(i) > -1) //si ese dia esta asignado, sino no le resta dias (-1 que significa sin asignar)
                {
                    acum += this.KilometrosRecorridos(i);
                }            
            }

            return acum;
        }

    }
}
