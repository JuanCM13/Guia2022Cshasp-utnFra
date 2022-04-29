using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer26
{
    public partial class Saludador : Form
    {
        private String saludo;
        private String nombre;
        public Saludador(String saludo , String nombre)
        {
            InitializeComponent();
            this.saludo = saludo;
            this.nombre = nombre;
            this.Saludar();
        }

        private void Saludar()
        {
            this.lblImprimirNombre.Text = nombre;
            this.lbIImprimirSaludo.Text = saludo;
        }
    }
}
