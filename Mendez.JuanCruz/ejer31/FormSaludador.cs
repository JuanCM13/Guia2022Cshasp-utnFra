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
    public partial class FormSaludador : Form
    {
        public FormSaludador(String saludo , String nombre)
        {
            InitializeComponent();
            this.lblImprimirSaludo.Text = saludo;
            this.lblImprimirNombre.Text = nombre;    
        }
    }
}
