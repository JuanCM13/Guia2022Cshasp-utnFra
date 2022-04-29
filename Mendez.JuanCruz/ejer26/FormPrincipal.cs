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
    public partial class Form1 : Form
    {
        private TextBox txtBxName;
        private TextBox txtBxApellido;
        private Label lblNombre;
        private Label lblApellido;
        private Button btnSaludar;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxName
            // 
            this.txtBxName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBxName.Location = new System.Drawing.Point(23, 60);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(186, 31);
            this.txtBxName.TabIndex = 0;
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBxApellido.Location = new System.Drawing.Point(266, 60);
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.Size = new System.Drawing.Size(186, 31);
            this.txtBxApellido.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(23, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 32);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(266, 9);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(134, 32);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSaludar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaludar.Location = new System.Drawing.Point(177, 112);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(112, 40);
            this.btnSaludar.TabIndex = 5;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(487, 183);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBxApellido);
            this.Controls.Add(this.txtBxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "¡Hola, Windows Forms!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
