
namespace ejer31
{
    partial class FormSaludador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblImprimirSaludo = new System.Windows.Forms.Label();
            this.lblImprimirNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImprimirSaludo
            // 
            this.lblImprimirSaludo.AutoSize = true;
            this.lblImprimirSaludo.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImprimirSaludo.Location = new System.Drawing.Point(38, 32);
            this.lblImprimirSaludo.Name = "lblImprimirSaludo";
            this.lblImprimirSaludo.Size = new System.Drawing.Size(0, 32);
            this.lblImprimirSaludo.TabIndex = 0;
            // 
            // lblImprimirNombre
            // 
            this.lblImprimirNombre.AutoSize = true;
            this.lblImprimirNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImprimirNombre.Location = new System.Drawing.Point(38, 107);
            this.lblImprimirNombre.Name = "lblImprimirNombre";
            this.lblImprimirNombre.Size = new System.Drawing.Size(0, 29);
            this.lblImprimirNombre.TabIndex = 1;
            // 
            // FormSaludador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 229);
            this.Controls.Add(this.lblImprimirNombre);
            this.Controls.Add(this.lblImprimirSaludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaludador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImprimirSaludo;
        private System.Windows.Forms.Label lblImprimirNombre;
    }
}