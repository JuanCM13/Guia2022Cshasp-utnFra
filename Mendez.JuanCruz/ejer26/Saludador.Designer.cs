
namespace ejer26
{
    partial class Saludador
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
            this.lbIImprimirSaludo = new System.Windows.Forms.Label();
            this.lblImprimirNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIImprimirSaludo
            // 
            this.lbIImprimirSaludo.AutoSize = true;
            this.lbIImprimirSaludo.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIImprimirSaludo.Location = new System.Drawing.Point(60, 31);
            this.lbIImprimirSaludo.Name = "lbIImprimirSaludo";
            this.lbIImprimirSaludo.Size = new System.Drawing.Size(101, 32);
            this.lbIImprimirSaludo.TabIndex = 0;
            this.lbIImprimirSaludo.Text = "label1";
            // 
            // lblImprimirNombre
            // 
            this.lblImprimirNombre.AutoSize = true;
            this.lblImprimirNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImprimirNombre.Location = new System.Drawing.Point(60, 92);
            this.lblImprimirNombre.Name = "lblImprimirNombre";
            this.lblImprimirNombre.Size = new System.Drawing.Size(78, 32);
            this.lblImprimirNombre.TabIndex = 1;
            this.lblImprimirNombre.Text = "label2";
            // 
            // Saludador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 154);
            this.Controls.Add(this.lblImprimirNombre);
            this.Controls.Add(this.lbIImprimirSaludo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saludador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIImprimirSaludo;
        private System.Windows.Forms.Label lblImprimirNombre;
    }
}