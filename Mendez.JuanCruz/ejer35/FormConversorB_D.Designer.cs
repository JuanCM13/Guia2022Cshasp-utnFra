
namespace ejer35
{
    partial class FormConversorB_D
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
            this.txtBxSetBinario = new System.Windows.Forms.TextBox();
            this.txtBxSetDecimal = new System.Windows.Forms.TextBox();
            this.txtBx_B_D = new System.Windows.Forms.TextBox();
            this.txtBx_D_B = new System.Windows.Forms.TextBox();
            this.lblBinAdec = new System.Windows.Forms.Label();
            this.lblDecimalAbinario = new System.Windows.Forms.Label();
            this.btnB_D = new System.Windows.Forms.Button();
            this.btnD_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxSetBinario
            // 
            this.txtBxSetBinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxSetBinario.Location = new System.Drawing.Point(243, 12);
            this.txtBxSetBinario.Name = "txtBxSetBinario";
            this.txtBxSetBinario.Size = new System.Drawing.Size(228, 39);
            this.txtBxSetBinario.TabIndex = 0;
            // 
            // txtBxSetDecimal
            // 
            this.txtBxSetDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxSetDecimal.Location = new System.Drawing.Point(243, 81);
            this.txtBxSetDecimal.Name = "txtBxSetDecimal";
            this.txtBxSetDecimal.Size = new System.Drawing.Size(228, 39);
            this.txtBxSetDecimal.TabIndex = 1;
            // 
            // txtBx_B_D
            // 
            this.txtBx_B_D.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBx_B_D.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBx_B_D.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBx_B_D.Location = new System.Drawing.Point(690, 12);
            this.txtBx_B_D.Name = "txtBx_B_D";
            this.txtBx_B_D.ReadOnly = true;
            this.txtBx_B_D.Size = new System.Drawing.Size(228, 39);
            this.txtBx_B_D.TabIndex = 2;
            // 
            // txtBx_D_B
            // 
            this.txtBx_D_B.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBx_D_B.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBx_D_B.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBx_D_B.Location = new System.Drawing.Point(690, 85);
            this.txtBx_D_B.Name = "txtBx_D_B";
            this.txtBx_D_B.ReadOnly = true;
            this.txtBx_D_B.Size = new System.Drawing.Size(228, 39);
            this.txtBx_D_B.TabIndex = 3;
            // 
            // lblBinAdec
            // 
            this.lblBinAdec.AutoSize = true;
            this.lblBinAdec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBinAdec.Location = new System.Drawing.Point(22, 15);
            this.lblBinAdec.Name = "lblBinAdec";
            this.lblBinAdec.Size = new System.Drawing.Size(215, 32);
            this.lblBinAdec.TabIndex = 4;
            this.lblBinAdec.Text = "Binario a Decimal";
            // 
            // lblDecimalAbinario
            // 
            this.lblDecimalAbinario.AutoSize = true;
            this.lblDecimalAbinario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDecimalAbinario.Location = new System.Drawing.Point(22, 88);
            this.lblDecimalAbinario.Name = "lblDecimalAbinario";
            this.lblDecimalAbinario.Size = new System.Drawing.Size(215, 32);
            this.lblDecimalAbinario.TabIndex = 5;
            this.lblDecimalAbinario.Text = "Decimal a Binario";
            // 
            // btnB_D
            // 
            this.btnB_D.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnB_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB_D.Location = new System.Drawing.Point(492, 12);
            this.btnB_D.Name = "btnB_D";
            this.btnB_D.Size = new System.Drawing.Size(173, 39);
            this.btnB_D.TabIndex = 6;
            this.btnB_D.Text = "->";
            this.btnB_D.UseVisualStyleBackColor = false;
            this.btnB_D.Click += new System.EventHandler(this.btnB_D_Click);
            // 
            // btnD_B
            // 
            this.btnD_B.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnD_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD_B.Location = new System.Drawing.Point(492, 83);
            this.btnD_B.Name = "btnD_B";
            this.btnD_B.Size = new System.Drawing.Size(173, 39);
            this.btnD_B.TabIndex = 7;
            this.btnD_B.Text = "->";
            this.btnD_B.UseVisualStyleBackColor = false;
            this.btnD_B.Click += new System.EventHandler(this.btnD_B_Click);
            // 
            // FormConversorB_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 142);
            this.Controls.Add(this.btnD_B);
            this.Controls.Add(this.btnB_D);
            this.Controls.Add(this.lblDecimalAbinario);
            this.Controls.Add(this.lblBinAdec);
            this.Controls.Add(this.txtBx_D_B);
            this.Controls.Add(this.txtBx_B_D);
            this.Controls.Add(this.txtBxSetDecimal);
            this.Controls.Add(this.txtBxSetBinario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConversorB_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Binario/Decimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConversorB_D_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxSetBinario;
        private System.Windows.Forms.TextBox txtBxSetDecimal;
        private System.Windows.Forms.TextBox txtBx_B_D;
        private System.Windows.Forms.TextBox txtBx_D_B;
        private System.Windows.Forms.Label lblBinAdec;
        private System.Windows.Forms.Label lblDecimalAbinario;
        private System.Windows.Forms.Button btnB_D;
        private System.Windows.Forms.Button btnD_B;
    }
}

