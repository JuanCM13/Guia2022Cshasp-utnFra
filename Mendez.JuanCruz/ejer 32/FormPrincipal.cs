using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ingresante;
namespace ejer_32
{
    public partial class FormPrincipal : Form
    {
        Ingresado ingresante;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //this.listBx_Pais.SelectionMode = SelectionMode.MultiExtended;
            this.listBx_Pais.Items.Add("Argentina");
            this.listBx_Pais.Items.Add("Uruguay");
            this.listBx_Pais.Items.Add("Chile");
            this.numericUd_Edad.Maximum = 100;
            this.numericUd_Edad.Minimum = 18;
            //ver si estos dos los dejo con valor por default o no... pensar ah
            //this.listBx_Pais.SelectedValue = null;
            //this.rb_NoBinario.Checked = true;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Int32 edad = (Int32) this.numericUd_Edad.Value;
            String nombre = this.txtBx_Nombre.Text;
            String direccion = this.txtBx_Direccion.Text;

            this.ingresante = new Ingresado(this.CursoSeleccionados() , direccion , edad , this.GeneroSeleccionado() , nombre , this.PaisSeleccionado());

            MessageBox.Show(ingresante.Mostrar() , String.Empty , MessageBoxButtons.OK);
        }

        /// <summary>
        /// Recorre los chb del groupbox de cursos y devuelve un string con los valores checkeados
        /// </summary>
        /// <returns>string con los cursos, o string diciendo que no se selecciono ninguno</returns>
        private String[] CursoSeleccionados()
        {
            Int32 cantidadDeCursos = this.groupBx_Cursos.Controls.Count; //asi consigo un conteo de la cantidad de elementos cargados en el groupbox
            String[] ret = new String[cantidadDeCursos];
            bool seleccionado = false;
            Int32 index = 0; 

            //hice un recontra choclo, pero recorro los elementos del groupbox con un foreach, y al
            //array de cursos le voy agregando, el texto del valor clickeado, el largo del array lo manejo
            //con un index auxiliar y el largo que le asigno es la cantidad de elementos cargados al momento
            //en el groupbox. Es un re choclo seguro hay algun metodo que simplifica todo jajajaja
            //1159845784

            foreach (CheckBox chB in this.groupBx_Cursos.Controls.OfType<CheckBox>())
            {
                if (chB.Checked)
                {
                    ret[index] = chB.Text;    
                    seleccionado = true;
                    index++;
                }
            }

            if (seleccionado == false)
            {
                ret[0] = "Sin Cursos al momento";
            }

            return ret;
        }

        /// <summary>
        /// Recorre los rb del groupbox de cursos y devuelve un string con el valor checkeado
        /// </summary>
        /// <returns>string con el genero seleccionado, sino por default esta asignado el no binario</returns>
        private String GeneroSeleccionado()
        {
            String ret = String.Empty;
            bool seleccionado = false;

            //...ofType<RadioButton>() devuelve el listado de radio buttons en el groupbox
            foreach (RadioButton rb in this.groupbx_Genero.Controls.OfType<RadioButton>())
            {
                if(rb.Checked) //si hay alguno seleccionado (la prop Checked del rb es true)
                {
                    ret = rb.Text;
                    seleccionado = true;
                    break;
                }
            }

            if(seleccionado == false)
            {
                ret = "Sin asignar";
            }

            return ret;
        }

        private String PaisSeleccionado()
        {
            String ret;

            if(this.listBx_Pais.SelectedItem is null) //LO LLAMO SIN EL TO STRING, POR QUE SINO SI ES NULL AHI ROMPE
            {                                           //si verifico que no es null, ahi lo asigno al ret con el .tostring()
                ret = "Sin Asignar";
            }
            else
            {
                ret = this.listBx_Pais.SelectedItem.ToString();
            }

            return ret;
        }
    }
}
