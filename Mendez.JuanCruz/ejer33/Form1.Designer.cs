
namespace ejer33
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Cotizacion = new System.Windows.Forms.Label();
            this.btn_Cotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBx_EuroCoti = new System.Windows.Forms.TextBox();
            this.txtBx_PesoCoti = new System.Windows.Forms.TextBox();
            this.txtBx_DolarCoti = new System.Windows.Forms.TextBox();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.lbl_Dolar = new System.Windows.Forms.Label();
            this.lbl_Euro = new System.Windows.Forms.Label();
            this.txtBx_EuroApeso = new System.Windows.Forms.TextBox();
            this.txtBx_EuroAdolar = new System.Windows.Forms.TextBox();
            this.txtBx_EuroAeuro = new System.Windows.Forms.TextBox();
            this.txtBx_DolarAeuro = new System.Windows.Forms.TextBox();
            this.txtBx_DolarAdolar = new System.Windows.Forms.TextBox();
            this.txtBx_DolarApeso = new System.Windows.Forms.TextBox();
            this.txtBx_PesoAeuro = new System.Windows.Forms.TextBox();
            this.txtBx_PesoAdolar = new System.Windows.Forms.TextBox();
            this.txtBx_PesoApeso = new System.Windows.Forms.TextBox();
            this.txtBx_SetPeso = new System.Windows.Forms.TextBox();
            this.txtBx_SetDolar = new System.Windows.Forms.TextBox();
            this.txtBx_SetEuro = new System.Windows.Forms.TextBox();
            this.btn_ConvertEuro = new System.Windows.Forms.Button();
            this.btn_ConvertPeso = new System.Windows.Forms.Button();
            this.btn_ConvertDolar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Cotizacion
            // 
            this.lbl_Cotizacion.AutoSize = true;
            this.lbl_Cotizacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cotizacion.Location = new System.Drawing.Point(146, 41);
            this.lbl_Cotizacion.Name = "lbl_Cotizacion";
            this.lbl_Cotizacion.Size = new System.Drawing.Size(134, 32);
            this.lbl_Cotizacion.TabIndex = 0;
            this.lbl_Cotizacion.Text = "Cotizacion";
            // 
            // btn_Cotizacion
            // 
            this.btn_Cotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cotizacion.ImageIndex = 1;
            this.btn_Cotizacion.ImageList = this.imageList1;
            this.btn_Cotizacion.Location = new System.Drawing.Point(333, 27);
            this.btn_Cotizacion.Name = "btn_Cotizacion";
            this.btn_Cotizacion.Size = new System.Drawing.Size(78, 59);
            this.btn_Cotizacion.TabIndex = 1;
            this.btn_Cotizacion.UseVisualStyleBackColor = true;
            this.btn_Cotizacion.Click += new System.EventHandler(this.btn_Cotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "314696_lock_icon (1).png");
            this.imageList1.Images.SetKeyName(1, "314697_lock_open_icon.png");
            // 
            // txtBx_EuroCoti
            // 
            this.txtBx_EuroCoti.Location = new System.Drawing.Point(459, 41);
            this.txtBx_EuroCoti.Name = "txtBx_EuroCoti";
            this.txtBx_EuroCoti.Size = new System.Drawing.Size(166, 31);
            this.txtBx_EuroCoti.TabIndex = 2;
            this.txtBx_EuroCoti.Leave += new System.EventHandler(this.txtBx_EuroCoti_Leave);
            // 
            // txtBx_PesoCoti
            // 
            this.txtBx_PesoCoti.Location = new System.Drawing.Point(837, 41);
            this.txtBx_PesoCoti.Name = "txtBx_PesoCoti";
            this.txtBx_PesoCoti.Size = new System.Drawing.Size(166, 31);
            this.txtBx_PesoCoti.TabIndex = 3;
            this.txtBx_PesoCoti.Leave += new System.EventHandler(this.txtBx_PesoCoti_Leave);
            // 
            // txtBx_DolarCoti
            // 
            this.txtBx_DolarCoti.Location = new System.Drawing.Point(647, 41);
            this.txtBx_DolarCoti.Name = "txtBx_DolarCoti";
            this.txtBx_DolarCoti.Size = new System.Drawing.Size(166, 31);
            this.txtBx_DolarCoti.TabIndex = 4;
            this.txtBx_DolarCoti.Leave += new System.EventHandler(this.txtBx_DolarCoti_Leave);
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Peso.Location = new System.Drawing.Point(879, 95);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(67, 32);
            this.lbl_Peso.TabIndex = 5;
            this.lbl_Peso.Text = "Peso";
            // 
            // lbl_Dolar
            // 
            this.lbl_Dolar.AutoSize = true;
            this.lbl_Dolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dolar.Location = new System.Drawing.Point(682, 95);
            this.lbl_Dolar.Name = "lbl_Dolar";
            this.lbl_Dolar.Size = new System.Drawing.Size(77, 32);
            this.lbl_Dolar.TabIndex = 6;
            this.lbl_Dolar.Text = "Dolar";
            // 
            // lbl_Euro
            // 
            this.lbl_Euro.AutoSize = true;
            this.lbl_Euro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Euro.Location = new System.Drawing.Point(496, 95);
            this.lbl_Euro.Name = "lbl_Euro";
            this.lbl_Euro.Size = new System.Drawing.Size(67, 32);
            this.lbl_Euro.TabIndex = 7;
            this.lbl_Euro.Text = "Euro";
            // 
            // txtBx_EuroApeso
            // 
            this.txtBx_EuroApeso.Location = new System.Drawing.Point(837, 152);
            this.txtBx_EuroApeso.Name = "txtBx_EuroApeso";
            this.txtBx_EuroApeso.ReadOnly = true;
            this.txtBx_EuroApeso.Size = new System.Drawing.Size(166, 31);
            this.txtBx_EuroApeso.TabIndex = 8;
            // 
            // txtBx_EuroAdolar
            // 
            this.txtBx_EuroAdolar.Location = new System.Drawing.Point(647, 152);
            this.txtBx_EuroAdolar.Name = "txtBx_EuroAdolar";
            this.txtBx_EuroAdolar.ReadOnly = true;
            this.txtBx_EuroAdolar.Size = new System.Drawing.Size(166, 31);
            this.txtBx_EuroAdolar.TabIndex = 9;
            // 
            // txtBx_EuroAeuro
            // 
            this.txtBx_EuroAeuro.Location = new System.Drawing.Point(459, 152);
            this.txtBx_EuroAeuro.Name = "txtBx_EuroAeuro";
            this.txtBx_EuroAeuro.ReadOnly = true;
            this.txtBx_EuroAeuro.Size = new System.Drawing.Size(166, 31);
            this.txtBx_EuroAeuro.TabIndex = 10;
            // 
            // txtBx_DolarAeuro
            // 
            this.txtBx_DolarAeuro.Location = new System.Drawing.Point(459, 229);
            this.txtBx_DolarAeuro.Name = "txtBx_DolarAeuro";
            this.txtBx_DolarAeuro.ReadOnly = true;
            this.txtBx_DolarAeuro.Size = new System.Drawing.Size(166, 31);
            this.txtBx_DolarAeuro.TabIndex = 13;
            // 
            // txtBx_DolarAdolar
            // 
            this.txtBx_DolarAdolar.Location = new System.Drawing.Point(647, 229);
            this.txtBx_DolarAdolar.Name = "txtBx_DolarAdolar";
            this.txtBx_DolarAdolar.ReadOnly = true;
            this.txtBx_DolarAdolar.Size = new System.Drawing.Size(166, 31);
            this.txtBx_DolarAdolar.TabIndex = 12;
            // 
            // txtBx_DolarApeso
            // 
            this.txtBx_DolarApeso.Location = new System.Drawing.Point(837, 229);
            this.txtBx_DolarApeso.Name = "txtBx_DolarApeso";
            this.txtBx_DolarApeso.ReadOnly = true;
            this.txtBx_DolarApeso.Size = new System.Drawing.Size(166, 31);
            this.txtBx_DolarApeso.TabIndex = 11;
            // 
            // txtBx_PesoAeuro
            // 
            this.txtBx_PesoAeuro.Location = new System.Drawing.Point(459, 305);
            this.txtBx_PesoAeuro.Name = "txtBx_PesoAeuro";
            this.txtBx_PesoAeuro.ReadOnly = true;
            this.txtBx_PesoAeuro.Size = new System.Drawing.Size(166, 31);
            this.txtBx_PesoAeuro.TabIndex = 16;
            // 
            // txtBx_PesoAdolar
            // 
            this.txtBx_PesoAdolar.Location = new System.Drawing.Point(647, 305);
            this.txtBx_PesoAdolar.Name = "txtBx_PesoAdolar";
            this.txtBx_PesoAdolar.ReadOnly = true;
            this.txtBx_PesoAdolar.Size = new System.Drawing.Size(166, 31);
            this.txtBx_PesoAdolar.TabIndex = 15;
            // 
            // txtBx_PesoApeso
            // 
            this.txtBx_PesoApeso.Location = new System.Drawing.Point(837, 305);
            this.txtBx_PesoApeso.Name = "txtBx_PesoApeso";
            this.txtBx_PesoApeso.ReadOnly = true;
            this.txtBx_PesoApeso.Size = new System.Drawing.Size(166, 31);
            this.txtBx_PesoApeso.TabIndex = 14;
            // 
            // txtBx_SetPeso
            // 
            this.txtBx_SetPeso.Location = new System.Drawing.Point(128, 305);
            this.txtBx_SetPeso.Name = "txtBx_SetPeso";
            this.txtBx_SetPeso.Size = new System.Drawing.Size(166, 31);
            this.txtBx_SetPeso.TabIndex = 19;
            // 
            // txtBx_SetDolar
            // 
            this.txtBx_SetDolar.Location = new System.Drawing.Point(128, 229);
            this.txtBx_SetDolar.Name = "txtBx_SetDolar";
            this.txtBx_SetDolar.Size = new System.Drawing.Size(166, 31);
            this.txtBx_SetDolar.TabIndex = 18;
            // 
            // txtBx_SetEuro
            // 
            this.txtBx_SetEuro.Location = new System.Drawing.Point(128, 152);
            this.txtBx_SetEuro.Name = "txtBx_SetEuro";
            this.txtBx_SetEuro.Size = new System.Drawing.Size(166, 31);
            this.txtBx_SetEuro.TabIndex = 17;
            // 
            // btn_ConvertEuro
            // 
            this.btn_ConvertEuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConvertEuro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ConvertEuro.Location = new System.Drawing.Point(321, 152);
            this.btn_ConvertEuro.Name = "btn_ConvertEuro";
            this.btn_ConvertEuro.Size = new System.Drawing.Size(112, 34);
            this.btn_ConvertEuro.TabIndex = 20;
            this.btn_ConvertEuro.Text = "->";
            this.btn_ConvertEuro.UseVisualStyleBackColor = true;
            this.btn_ConvertEuro.Click += new System.EventHandler(this.btn_ConvertEuro_Click);
            // 
            // btn_ConvertPeso
            // 
            this.btn_ConvertPeso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConvertPeso.Location = new System.Drawing.Point(321, 302);
            this.btn_ConvertPeso.Name = "btn_ConvertPeso";
            this.btn_ConvertPeso.Size = new System.Drawing.Size(112, 34);
            this.btn_ConvertPeso.TabIndex = 21;
            this.btn_ConvertPeso.Text = "->";
            this.btn_ConvertPeso.UseVisualStyleBackColor = true;
            this.btn_ConvertPeso.Click += new System.EventHandler(this.btn_ConvertPeso_Click);
            // 
            // btn_ConvertDolar
            // 
            this.btn_ConvertDolar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConvertDolar.Location = new System.Drawing.Point(321, 227);
            this.btn_ConvertDolar.Name = "btn_ConvertDolar";
            this.btn_ConvertDolar.Size = new System.Drawing.Size(112, 34);
            this.btn_ConvertDolar.TabIndex = 22;
            this.btn_ConvertDolar.Text = "->";
            this.btn_ConvertDolar.UseVisualStyleBackColor = true;
            this.btn_ConvertDolar.Click += new System.EventHandler(this.btn_ConvertDolar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConvertDolar);
            this.Controls.Add(this.btn_ConvertPeso);
            this.Controls.Add(this.btn_ConvertEuro);
            this.Controls.Add(this.txtBx_SetPeso);
            this.Controls.Add(this.txtBx_SetDolar);
            this.Controls.Add(this.txtBx_SetEuro);
            this.Controls.Add(this.txtBx_PesoAeuro);
            this.Controls.Add(this.txtBx_PesoAdolar);
            this.Controls.Add(this.txtBx_PesoApeso);
            this.Controls.Add(this.txtBx_DolarAeuro);
            this.Controls.Add(this.txtBx_DolarAdolar);
            this.Controls.Add(this.txtBx_DolarApeso);
            this.Controls.Add(this.txtBx_EuroAeuro);
            this.Controls.Add(this.txtBx_EuroAdolar);
            this.Controls.Add(this.txtBx_EuroApeso);
            this.Controls.Add(this.lbl_Euro);
            this.Controls.Add(this.lbl_Dolar);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.txtBx_DolarCoti);
            this.Controls.Add(this.txtBx_PesoCoti);
            this.Controls.Add(this.txtBx_EuroCoti);
            this.Controls.Add(this.btn_Cotizacion);
            this.Controls.Add(this.lbl_Cotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cotizacion;
        private System.Windows.Forms.Button btn_Cotizacion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtBx_EuroCoti;
        private System.Windows.Forms.TextBox txtBx_PesoCoti;
        private System.Windows.Forms.TextBox txtBx_DolarCoti;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.Label lbl_Dolar;
        private System.Windows.Forms.Label lbl_Euro;
        private System.Windows.Forms.TextBox txtBx_EuroApeso;
        private System.Windows.Forms.TextBox txtBx_EuroAdolar;
        private System.Windows.Forms.TextBox txtBx_EuroAeuro;
        private System.Windows.Forms.TextBox txtBx_DolarAeuro;
        private System.Windows.Forms.TextBox txtBx_DolarAdolar;
        private System.Windows.Forms.TextBox txtBx_DolarApeso;
        private System.Windows.Forms.TextBox txtBx_PesoAeuro;
        private System.Windows.Forms.TextBox txtBx_PesoAdolar;
        private System.Windows.Forms.TextBox txtBx_PesoApeso;
        private System.Windows.Forms.TextBox txtBx_SetPeso;
        private System.Windows.Forms.TextBox txtBx_SetDolar;
        private System.Windows.Forms.TextBox txtBx_SetEuro;
        private System.Windows.Forms.Button btn_ConvertEuro;
        private System.Windows.Forms.Button btn_ConvertPeso;
        private System.Windows.Forms.Button btn_ConvertDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

