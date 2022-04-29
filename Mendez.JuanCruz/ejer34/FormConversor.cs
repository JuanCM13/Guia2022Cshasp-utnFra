using System;
using System.Drawing;
using System.Windows.Forms;
using ConversorTemperaturas;

namespace ejer34
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void btn_ConvertFah_Click(object sender, EventArgs e)
        {
            double valor;
            Fahrenheit fah;

            if (this.ControladorErrores(1))
            {
                this.txtBx_FahSet.BackColor = Color.White;
                valor = double.Parse(this.txtBx_FahSet.Text);

                fah = valor;
                this.txtBx_F_F.Text = fah;
                this.txtBx_F_C.Text = (Celsius)fah;
                this.txtBx_F_K.Text = (Kelvin)fah;
            }
            /*String data = this.txtBx_FahSet.Text;
            if(!String.IsNullOrWhiteSpace(data))
            {
                if(double.TryParse(data , out double aux))
                {
                    this.txtBx_FahSet.BackColor = Color.White;
                    Fahrenheit fah = aux;
                    this.txtBx_F_F.Text = fah;
                    this.txtBx_F_C.Text = (Celsius)fah;
                    this.txtBx_F_K.Text = (Kelvin)fah;
                }
                else
                {
                    this.MensajeError("Maquina tenes que ingresar algo en el cuadrito...");
                    this.txtBx_FahSet.Focus();
                    this.txtBx_FahSet.BackColor = Color.Coral;
                }
            }
            else
            {
                this.MensajeError("Maquina tenes que ingresar algo en el cuadrito...");
                this.txtBx_FahSet.Focus();
                this.txtBx_FahSet.BackColor = Color.Coral;
            }*/
        }

        private void btn_ConvertCel_Click(object sender, EventArgs e)
        {
            double valor;
            Celsius cel ;

            if (this.ControladorErrores(2))
            {
                this.txtBx_CelSet.BackColor = Color.White;
                valor = double.Parse(this.txtBx_CelSet.Text);

                cel = valor;
                this.txtBx_C_F.Text = (Fahrenheit)cel;
                this.txtBx_C_C.Text = cel;
                this.txtBx_C_K.Text = (Kelvin)cel;
            }
            /*String data = this.txtBx_CelSet.Text;
            if (!String.IsNullOrWhiteSpace(data))
            {
                if (double.TryParse(data, out double aux))
                {
                    this.txtBx_CelSet.BackColor = Color.White;
                    Celsius cel = aux;
                    this.txtBx_C_F.Text = (Fahrenheit)cel;
                    this.txtBx_C_C.Text = cel;
                    this.txtBx_C_K.Text = (Kelvin)cel;
                }
                else
                {
                    this.MensajeError("Maquina tenes que ingresar algo en el cuadrito...");
                    this.txtBx_CelSet.Focus();
                    this.txtBx_CelSet.BackColor = Color.Coral;
                }
            }
            else
            {
                this.MensajeError("Maquina tenes que ingresar algo en el cuadrito...");
                this.txtBx_CelSet.Focus();
                this.txtBx_CelSet.BackColor = Color.Coral;
            }*/
        }

        private void btn_ConvertKel_Click(object sender, EventArgs e)
        {
            double valor;
            Kelvin kel;

            if(this.ControladorErrores(3))
            {
                this.txtBx_KelSet.BackColor = Color.White;
                valor = double.Parse(this.txtBx_KelSet.Text);

                kel = valor;
                this.txtBx_K_F.Text = (Fahrenheit)kel;
                this.txtBx_K_C.Text = (Celsius)kel;
                this.txtBx_K_K.Text = kel;
            }
            /*String data = this.txtBx_KelSet.Text;
            if (!String.IsNullOrWhiteSpace(data))
            {
                if (double.TryParse(data, out double aux))
                {
                    this.txtBx_KelSet.BackColor = Color.White;
                    Kelvin kel = aux;
                    this.txtBx_K_F.Text = (Fahrenheit)kel;
                    this.txtBx_K_C.Text = (Celsius)kel;
                    this.txtBx_K_K.Text = kel;
                }
                else
                {
                    this.MensajeError("Maquina tenes que ingresar algo en el cuadrito...");
                    this.txtBx_KelSet.Focus();
                    this.txtBx_KelSet.BackColor = Color.Coral;
                }
            }
            else
            {
                this.MensajeError("Maquina tenes que ingresar algo en el cuadrito...");
                this.txtBx_KelSet.Focus();
                this.txtBx_KelSet.BackColor = Color.Coral;
            }*/
        }

        private void MensajeError(String mensaje)
        {
            String aux;
            if (!String.IsNullOrWhiteSpace(mensaje))
            {
                aux = mensaje.Trim();
                MessageBox.Show(aux, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool ControladorErrores(Int32 tipo)
        {
            //voy viendo con el switch, que textbox analizar, y ahi compruebo que este valido, sino guardo
            //en un auxiliar de tipo TextBox el textbox a analizar y ahi en base a ese genero la logica del error
            String dato = String.Empty;
            TextBox auxTextBox = null;

            bool ret = false;
            
            switch(tipo)
            {
                case 1:
                    auxTextBox = this.txtBx_FahSet;
                    dato = auxTextBox.Text;
                break;
                case 2:
                    auxTextBox = this.txtBx_CelSet;
                    dato = auxTextBox.Text;
                break;
                case 3:
                    auxTextBox = this.txtBx_KelSet;
                    dato = auxTextBox.Text;
                break;
            }


            if (!String.IsNullOrWhiteSpace(dato))
            {
                if (double.TryParse(dato, out double aux))
                {
                    ret = true;
                }
                else
                {
                    this.MensajeError("Maquina solo admitimos numeros..");
                    auxTextBox.Focus();
                    auxTextBox.BackColor = Color.Coral;
                }
            }
            else
            {
                this.MensajeError("Maquina tenes que ingresar algo en el cuadrito...");
                auxTextBox.Focus();
                auxTextBox.BackColor = Color.Coral;
            }

            return ret;
        }

        private void FormConversor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
