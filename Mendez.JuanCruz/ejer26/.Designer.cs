
namespace ejer26
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox textBxNombre;
        private System.Windows.Forms.TextBox txtBxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnSaludar;

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
            this.textBxNombre = new System.Windows.Forms.TextBox();
            this.txtBxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBxNombre
            // 
            this.textBxNombre.Location = new System.Drawing.Point(33, 86);
            this.textBxNombre.Name = "textBxNombre";
            this.textBxNombre.Size = new System.Drawing.Size(238, 31);
            this.textBxNombre.TabIndex = 0;
            // 
            // txtBxApellido
            // 
            this.txtBxApellido.Location = new System.Drawing.Point(325, 86);
            this.txtBxApellido.Name = "txtBxApellido";
            this.txtBxApellido.Size = new System.Drawing.Size(238, 31);
            this.txtBxApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(33, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 32);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(325, 43);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(134, 32);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaludar.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaludar.Location = new System.Drawing.Point(202, 180);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(168, 47);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "SALUDAR";
            this.btnSaludar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 245);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBxApellido);
            this.Controls.Add(this.textBxNombre);
            this.Name = "Form1";
            this.Text = "Hola, windows form!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

