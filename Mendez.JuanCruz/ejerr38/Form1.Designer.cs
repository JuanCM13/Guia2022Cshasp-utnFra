
namespace ejerr38
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
            this.richTxBx_Palabras = new System.Windows.Forms.RichTextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxBx_Palabras
            // 
            this.richTxBx_Palabras.Location = new System.Drawing.Point(13, 13);
            this.richTxBx_Palabras.Name = "richTxBx_Palabras";
            this.richTxBx_Palabras.Size = new System.Drawing.Size(473, 530);
            this.richTxBx_Palabras.TabIndex = 0;
            this.richTxBx_Palabras.Text = "";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(363, 559);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(112, 34);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convert";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 605);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.richTxBx_Palabras);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContadorPalabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxBx_Palabras;
        private System.Windows.Forms.Button btnConvertir;
    }
}

