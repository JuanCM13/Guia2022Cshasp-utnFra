using System;
using System.Windows.Forms;
using System.Drawing;
using ConversorBinarioDecimalRecargado;

namespace ejer35
{
    public partial class FormConversorB_D : Form
    {
        public FormConversorB_D()
        {
            InitializeComponent();
        }

        private void btnB_D_Click(object sender, EventArgs e)
        {
            Binario bin;
            Double aux;
            if(Binario.EsBinario(this.txtBxSetBinario.Text))
            {
                this.txtBxSetBinario.BackColor = Color.White;
                bin = this.txtBxSetBinario.Text;
                aux = (Double)(Deecimal)bin;
                this.txtBx_B_D.Text = aux.ToString("#,#.00");
            }
            else
            {
                this.MensajeError("Error, el campo debe estar completo y compuesto de 1 o 0s");
                this.txtBxSetBinario.Focus();
                this.txtBxSetBinario.BackColor = Color.Coral;
            }
        }

        private void MensajeError(String dato)
        {
            MessageBox.Show(dato, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnD_B_Click(object sender, EventArgs e)
        {
            Deecimal dec;
            if (double.TryParse(this.txtBxSetDecimal.Text , out double aux))            
            {
                this.txtBxSetDecimal.BackColor = Color.White;
                dec = aux;
                this.txtBx_D_B.Text = (String)(Binario)dec;
            }
            else
            {
                this.MensajeError("Error, el campo debe estar completo y solo admite numeros..");
                this.txtBxSetDecimal.Focus();
                this.txtBxSetDecimal.BackColor = Color.Coral;
            }
        }

        private void FormConversorB_D_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
