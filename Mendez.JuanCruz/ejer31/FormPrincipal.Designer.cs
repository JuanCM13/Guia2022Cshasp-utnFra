
namespace ejer31
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBxNombre = new System.Windows.Forms.TextBox();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.lblMateriaFav = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(13, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 38);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(254, 39);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(156, 38);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // txtBxNombre
            // 
            this.txtBxNombre.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBxNombre.Location = new System.Drawing.Point(13, 80);
            this.txtBxNombre.Name = "txtBxNombre";
            this.txtBxNombre.Size = new System.Drawing.Size(165, 31);
            this.txtBxNombre.TabIndex = 2;
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBxApellido.Location = new System.Drawing.Point(245, 80);
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.Size = new System.Drawing.Size(165, 31);
            this.txtBxApellido.TabIndex = 3;
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaludar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaludar.Location = new System.Drawing.Point(254, 195);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(165, 47);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "SALUDAR!";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.BtnSaludar_Click);
            this.btnSaludar.MouseEnter += new System.EventHandler(this.BtnSaludar_enterColor);
            this.btnSaludar.MouseLeave += new System.EventHandler(this.BtnSaludar_LeaveColor);
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(12, 209);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(182, 33);
            this.cmbMaterias.TabIndex = 5;
            // 
            // lblMateriaFav
            // 
            this.lblMateriaFav.AutoSize = true;
            this.lblMateriaFav.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateriaFav.Location = new System.Drawing.Point(12, 155);
            this.lblMateriaFav.Name = "lblMateriaFav";
            this.lblMateriaFav.Size = new System.Drawing.Size(205, 38);
            this.lblMateriaFav.TabIndex = 6;
            this.lblMateriaFav.Text = "MATERIA FAV:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(506, 284);
            this.Controls.Add(this.lblMateriaFav);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtBxApellido);
            this.Controls.Add(this.txtBxNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Load_Event);
            this.MouseLeave += new System.EventHandler(this.BtnSaludar_mouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBxNombre;
        private System.Windows.Forms.TextBox txtBxApellido;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Label lblMateriaFav;
    }
}

