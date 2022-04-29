using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Billetes;
namespace ejer33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtBx_DolarCoti.Text = "1";
            this.txtBx_EuroCoti.Text = "1,17";
            this.txtBx_PesoCoti.Text = "102,65";

        }

        private void btn_Cotizacion_Click(object sender, EventArgs e)
        {
            if(this.btn_Cotizacion.ImageIndex == 1)
            {
                this.btn_Cotizacion.ImageIndex = 0;
                this.txtBx_EuroCoti.Enabled = false;
                this.txtBx_EuroCoti.Text = "1,17";
                this.txtBx_PesoCoti.Enabled = false;
                this.txtBx_PesoCoti.Text = "102,65";
                this.txtBx_DolarCoti.Enabled = false;
            }
            else
            {
                this.btn_Cotizacion.ImageIndex = 1;
                this.txtBx_EuroCoti.Enabled = true; 
                this.txtBx_PesoCoti.Enabled = true;
                this.txtBx_DolarCoti.Enabled = true;
            }
        }

        //--------------------------------BOTONES CONVERSION---------------------------------------------

        private void btn_ConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidad;
            if(this.txtBx_SetEuro.Text != "" && double.TryParse(this.txtBx_SetEuro.Text , out cantidad))
            {
                double cotizacion = double.Parse(this.txtBx_EuroCoti.Text);

                Euro eur = new Euro(cantidad, cotizacion);
                Dolar dol = (Dolar) eur;
                Peso pes = (Peso) eur;

                this.txtBx_EuroAeuro.Text = cantidad.ToString("#,##.00");
                this.txtBx_EuroAdolar.Text = dol.GetCantidad().ToString("#,##.00");
                this.txtBx_EuroApeso.Text = pes.GetCantidad().ToString("#,##.00");
                this.txtBx_SetEuro.BackColor = Color.White;          
            }
            else
            {
                this.MensajeError("Maquina completate el cuadro de cuanto queres convertir, solo con letras duh");
                this.txtBx_SetEuro.Focus();
                this.txtBx_SetEuro.BackColor = Color.FromArgb(255 , 145 , 111);
            }
        }

        private void btn_ConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidad;
            if (this.txtBx_SetDolar.Text != "" && double.TryParse(this.txtBx_SetDolar.Text, out cantidad))
            {
                Dolar dol = new Dolar(cantidad);
                Euro eur = (Euro)dol;
                Peso pes = (Peso)dol;

                this.txtBx_DolarAeuro.Text = eur.GetCantidad().ToString("#,##.00");
                this.txtBx_DolarAdolar.Text = cantidad.ToString("#,##.00");
                this.txtBx_DolarApeso.Text = pes.GetCantidad().ToString("#,##.00");
                this.txtBx_SetDolar.BackColor = Color.White;
            }
            else
            {
                this.MensajeError("Maquina completate el cuadro de cuanto queres convertir, solo con letras duh");
                this.txtBx_SetDolar.Focus();
                this.txtBx_SetDolar.BackColor = Color.FromArgb(255, 145, 111);
            }
        }

        private void btn_ConvertPeso_Click(object sender, EventArgs e)
        {
            double cantidad;
            if (this.txtBx_SetPeso.Text != "" && double.TryParse(this.txtBx_SetPeso.Text, out cantidad))
            {
                double cotizacion = double.Parse(this.txtBx_PesoCoti.Text);

                Peso pes = new Peso(cantidad, cotizacion);
                Dolar dol = (Dolar)pes;
                Euro eur = (Euro)pes;

                this.txtBx_PesoAeuro.Text = eur.GetCantidad().ToString("#,##.00");
                this.txtBx_PesoAdolar.Text = dol.GetCantidad().ToString("#,##.00");
                this.txtBx_PesoApeso.Text = cantidad.ToString("#,##.00");
                this.txtBx_SetPeso.BackColor = Color.White;
            }
            else
            {
                this.MensajeError("Maquina completate el cuadro de cuanto queres convertir, solo con letras duh");
                this.txtBx_SetPeso.Focus();
                this.txtBx_SetPeso.BackColor = Color.FromArgb(255, 145, 111);
            }
         }

        //------------------------------------------------------------------------------------------------------

        private void txtBx_DolarCoti_Leave(object sender, EventArgs e)
        {
            Int32 coti;
            if (int.TryParse(this.txtBx_DolarCoti.Text, out coti) == false || coti != 1)
            {
                this.txtBx_DolarCoti.Text = "1";
            }
        }

        private void txtBx_EuroCoti_Leave(object sender, EventArgs e)
        {
            Int32 coti;
            if (int.TryParse(this.txtBx_EuroCoti.Text, out coti) == false)
            {
                this.MensajeError("Maquina tiene que estar si o si completo por un numero..");
                this.txtBx_EuroCoti.Focus();
                this.txtBx_EuroCoti.BackColor = Color.FromArgb(255, 145, 111);
            }
            else
            {
                //si esta vacio o no es numero mando mensaje de error, sino seteo el nuevo valor de conversion 
                //a la clase Euro
                Euro.SetCotizacion(double.Parse(this.txtBx_EuroCoti.Text));
                this.txtBx_EuroCoti.BackColor = Color.White;
            }
            
        }

        private void txtBx_PesoCoti_Leave(object sender, EventArgs e)
        {
            Int32 coti;
            if (int.TryParse(this.txtBx_PesoCoti.Text, out coti) == false)
            {    
                this.MensajeError("Maquina tiene que estar si o si completo por un numero..");
                this.txtBx_PesoCoti.Focus();
                this.txtBx_PesoCoti.BackColor = Color.FromArgb(255, 145, 111);
            }
            else
            {
                //si esta vacio o no es numero mando mensaje de error, sino seteo el nuevo valor de conversion 
                //a la clase Peso
                Peso.SetCotizacion(double.Parse(this.txtBx_PesoCoti.Text));
                this.txtBx_PesoCoti.BackColor = Color.White;
            }
        }

        private void MensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
