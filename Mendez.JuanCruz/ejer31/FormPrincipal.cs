using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer31
{
    public partial class FormPrincipal : Form
    {
        private StringBuilder str;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Load_Event(object sender, EventArgs e)
        {
            this.btnSaludar.FlatAppearance.BorderSize = 2;
            this.btnSaludar.FlatAppearance.BorderColor = Color.Blue;
            this.cmbMaterias.DataSource = Enum.GetValues(typeof(Materias));
            this.cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMaterias.SelectedItem = Materias.Laboratorio2;
        }

        private void BtnSaludar_enterColor(object sender, EventArgs e)
        {
            this.btnSaludar.BackColor = Color.Transparent;
        }

        //-------------------------------------------------------------------------------------------
        //este no va, le pifie al boton...
        private void BtnSaludar_mouseLeave(object sender, EventArgs e)
        {
            this.btnSaludar.BackColor = SystemColors.GradientInactiveCaption; //el que asigne al inicio
        }
        //-------------------------------------------------------------------------------------------

        private void BtnSaludar_LeaveColor(object sender, EventArgs e)
        {
            this.btnSaludar.BackColor = SystemColors.GradientInactiveCaption; //el que asigne al inicio
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            FormSaludador saludador;
            Materias materiaSeleccionada;
            String enumerado = null;

            if(String.IsNullOrEmpty(this.txtBxNombre.Text) == false && String.IsNullOrEmpty(this.txtBxApellido.Text) == false)
            {
                str.Append($"Soy {this.txtBxNombre.Text.Trim()}, {this.txtBxApellido.Text.Trim()}");

                //aca el this.cmbMaterias.SelectedText no funca con los dropbox list, asi que tuve que usar el value y castearlo a string...
                //materiaSeleccionada = (Materias)Enum.Parse(typeof(Materias), this.cmbMaterias.SelectedValue.ToString()); //obtengo el enum de materia seleccionado
                //en el cmb, enumParse me devuelve un enum generico  //asi que lo casteo a Materias.
                //lo de arriba no hizo falta, el cmb.SelectedValue ya me devuelve el objeto del tipo que lo cargue
                        //en este caso un objeto enum de tipo Materias, asi que el parse es al dope

                materiaSeleccionada = (Materias)this.cmbMaterias.SelectedValue; //me devuelve object, si o si castearlo a materias
                enumerado = Enum.GetName(typeof(Materias), materiaSeleccionada);// aca consigo el nombre en string del enumerado asi se lo paso como string de una al constructor de formSaludador

                str.AppendLine($"Y mi materia favorita es: {enumerado}");
                saludador = new FormSaludador(this.Text , str.ToString());
                saludador.ShowDialog();                                                                                                                      
            }                                                                                                  
            else
            {
                this.MensajeError("Error, debe completar ambos campos para continuar..");
                this.DarFocoAlFaltante();
            }
        }

        private void MensajeError(String error)
        {
            if( !(String.IsNullOrEmpty(error)) )
            {
                MessageBox.Show(error, "Error" , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }
        }

        private void DarFocoAlFaltante()
        {
            if(String.IsNullOrEmpty(this.txtBxApellido.Text))
            {
                this.txtBxApellido.Focus();
            }
            else
            {
                this.txtBxNombre.Focus();
            }
        }
    }
}
