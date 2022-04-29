using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerr38
{
    public partial class Form1 : Form
    {
        Dictionary<String, Int32> listadoPalabras;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            this.listadoPalabras = new Dictionary<String, Int32>();
            String[] array;
            String palabraAanalizar = "";
            Int32 contadorVeces = 0;
            StringBuilder listaGeneradaDiccionario;

            if(!String.IsNullOrEmpty(this.richTxBx_Palabras.Text))
            {
                //anotaciones para mi yo del futuro, por que te vas a re olvidar de lo que hiciste..


                array = (this.richTxBx_Palabras.Text).Split(" "); //divido el texto, en palabras separadas por espacio
                Array.Sort(array); //lo ordeno asi siempre recorro con las palabras agrupadas, asi voy viendo cuando se repite o no
                for(Int32 i=0; i<array.Length; i++)
                {
                    if(i==0)
                    {
                        palabraAanalizar = array[i];
                        contadorVeces = 1;
                    }
                    else
                    {
                        //pregunto si i == largo, por que sino el ultimo elemento al no ser distinto del anterior
                        //nunca me lo toma, por eso si llega al final, de todas maneras lo agrego..
                        if(array[i] != palabraAanalizar || i == array.Length-1)
                        {
                            //asigno al diccionario la palabra que estaba validando, seteo la palabra actual
                            //como la nueva palabra a evaluar (recorre preguntando por esa) y seteo su contador en 1
                            this.listadoPalabras.Add(palabraAanalizar, contadorVeces);
                            palabraAanalizar = array[i];
                            contadorVeces = 1;
                        }
                        else
                        {
                            contadorVeces++;
                        }
                    }
                }
                
                listaGeneradaDiccionario = new StringBuilder();

                //Diccionario generado..
                /*foreach(var palabra in listadoPalabras)
                {
                    listaGeneradaDiccionario.AppendLine($"Lista sin ordenar\nPalabra: {palabra.Key} -- Cant Veces: {palabra.Value}");
                }

                MessageBox.Show(listaGeneradaDiccionario.ToString(), "Palabras!", MessageBoxButtons.OK);
                */

                Int32 control = 0;

                //esto lo google nose que onda, es complicado sortear el diccionario por valor, por key es mas facil :s
                foreach(KeyValuePair<string, Int32> palabra in listadoPalabras.OrderBy(key => key.Value))
                {
                    listaGeneradaDiccionario.AppendLine($"Palabra: {palabra.Key} -- Cant Veces: {palabra.Value}");                    
                    if (control == 2)
                    {
                        break;
                    }
                    control++;
                }

                MessageBox.Show(listaGeneradaDiccionario.ToString(), "Palabras!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Maquina, ingaresa palabras antes..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
        }
    }
}
