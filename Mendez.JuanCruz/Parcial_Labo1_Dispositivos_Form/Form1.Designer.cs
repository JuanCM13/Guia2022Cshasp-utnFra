
namespace Parcial_Labo1_Dispositivos_Form
{
    partial class Form1
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
            this.rtbAppInstaladas = new System.Windows.Forms.RichTextBox();
            this.rtbAppNoInstaladas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAppInstaladas
            // 
            this.rtbAppInstaladas.BackColor = System.Drawing.Color.Black;
            this.rtbAppInstaladas.ForeColor = System.Drawing.Color.White;
            this.rtbAppInstaladas.Location = new System.Drawing.Point(13, 13);
            this.rtbAppInstaladas.Name = "rtbAppInstaladas";
            this.rtbAppInstaladas.Size = new System.Drawing.Size(331, 624);
            this.rtbAppInstaladas.TabIndex = 0;
            this.rtbAppInstaladas.Text = "";
            // 
            // rtbAppNoInstaladas
            // 
            this.rtbAppNoInstaladas.BackColor = System.Drawing.Color.Black;
            this.rtbAppNoInstaladas.ForeColor = System.Drawing.Color.White;
            this.rtbAppNoInstaladas.Location = new System.Drawing.Point(376, 12);
            this.rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            this.rtbAppNoInstaladas.Size = new System.Drawing.Size(331, 624);
            this.rtbAppNoInstaladas.TabIndex = 1;
            this.rtbAppNoInstaladas.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(719, 649);
            this.Controls.Add(this.rtbAppNoInstaladas);
            this.Controls.Add(this.rtbAppInstaladas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPP_MendezJuanCruz_2ºC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAppInstaladas;
        private System.Windows.Forms.RichTextBox rtbAppNoInstaladas;
    }
}

