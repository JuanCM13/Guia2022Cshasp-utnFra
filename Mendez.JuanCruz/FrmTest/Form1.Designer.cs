
namespace FrmTest
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
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(416, 12);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(484, 575);
            this.rtbInforme.TabIndex = 0;
            this.rtbInforme.Text = "";
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 25;
            this.lstStock.Location = new System.Drawing.Point(12, 12);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(373, 379);
            this.lstStock.TabIndex = 1;
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(12, 417);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(373, 42);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 545);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(373, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Tag = "";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(12, 481);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(373, 42);
            this.btnInforme.TabIndex = 4;
            this.btnInforme.Text = "Ver Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 610);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.rtbInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester App de Mendez Juan Cruz (2ºA)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInforme;
        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInforme;
    }
}

