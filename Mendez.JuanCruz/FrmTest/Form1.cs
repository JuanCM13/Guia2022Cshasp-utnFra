using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcialLibreria;

namespace FrmTest
{
    public partial class Form1 : Form
    {
        private Vendedor vendedor;

        public Form1()
        {
            InitializeComponent();
            vendedor = new Vendedor("Saramarai");    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);
            
            this.lstStock.Items.Add(p1); //Almacena el objeto e imprime el nombre por que implicitamente llama al toString el listbox
            this.lstStock.Items.Add(p2);
            this.lstStock.Items.Add(p3);
            this.lstStock.Items.Add(p4);
            this.lstStock.Items.Add(p5);   
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(!(this.lstStock.SelectedItem is null))
            {
                Publicacion aux = (Publicacion)this.lstStock.SelectedItem; //si llamo por selectedValue no funca, usar selectedItem!!!!
                if (this.vendedor + aux)
                {
                    MessageBox.Show("La venta pudo concretarse!", "Alerta" , MessageBoxButtons.OK);   
                }
                else
                {
                    MessageBox.Show("La venta no pudo llevarse a cabo, no hay mas stock!", "Alerta", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Error, seleccione un elemento de la lista..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            this.rtbInforme.Clear();
            this.rtbInforme.Text = Vendedor.ObtenerInformeDeVentas(this.vendedor);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?","Confirmacion",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
