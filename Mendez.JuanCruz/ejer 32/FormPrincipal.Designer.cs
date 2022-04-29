
namespace ejer_32
{
    partial class FormPrincipal
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
            this.groupBx_Usuario = new System.Windows.Forms.GroupBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.numericUd_Edad = new System.Windows.Forms.NumericUpDown();
            this.txtBx_Direccion = new System.Windows.Forms.TextBox();
            this.txtBx_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.listBx_Pais = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbx_Genero = new System.Windows.Forms.GroupBox();
            this.rb_NoBinario = new System.Windows.Forms.RadioButton();
            this.rb_Femenino = new System.Windows.Forms.RadioButton();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.groupBx_Cursos = new System.Windows.Forms.GroupBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.chB_Csharp = new System.Windows.Forms.CheckBox();
            this.chB_Cplus = new System.Windows.Forms.CheckBox();
            this.chB_JavaScript = new System.Windows.Forms.CheckBox();
            this.groupBx_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUd_Edad)).BeginInit();
            this.groupbx_Genero.SuspendLayout();
            this.groupBx_Cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBx_Usuario
            // 
            this.groupBx_Usuario.Controls.Add(this.lbl_Edad);
            this.groupBx_Usuario.Controls.Add(this.numericUd_Edad);
            this.groupBx_Usuario.Controls.Add(this.txtBx_Direccion);
            this.groupBx_Usuario.Controls.Add(this.txtBx_Nombre);
            this.groupBx_Usuario.Controls.Add(this.lbl_Direccion);
            this.groupBx_Usuario.Controls.Add(this.lblNombre);
            this.groupBx_Usuario.Location = new System.Drawing.Point(23, 23);
            this.groupBx_Usuario.Name = "groupBx_Usuario";
            this.groupBx_Usuario.Size = new System.Drawing.Size(329, 236);
            this.groupBx_Usuario.TabIndex = 0;
            this.groupBx_Usuario.TabStop = false;
            this.groupBx_Usuario.Text = "Detalles del Usuario";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(6, 176);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(56, 25);
            this.lbl_Edad.TabIndex = 5;
            this.lbl_Edad.Text = "Edad:";
            // 
            // numericUd_Edad
            // 
            this.numericUd_Edad.Location = new System.Drawing.Point(105, 174);
            this.numericUd_Edad.Name = "numericUd_Edad";
            this.numericUd_Edad.Size = new System.Drawing.Size(180, 31);
            this.numericUd_Edad.TabIndex = 4;
            // 
            // txtBx_Direccion
            // 
            this.txtBx_Direccion.Location = new System.Drawing.Point(105, 118);
            this.txtBx_Direccion.Name = "txtBx_Direccion";
            this.txtBx_Direccion.Size = new System.Drawing.Size(191, 31);
            this.txtBx_Direccion.TabIndex = 3;
            // 
            // txtBx_Nombre
            // 
            this.txtBx_Nombre.Location = new System.Drawing.Point(105, 58);
            this.txtBx_Nombre.Name = "txtBx_Nombre";
            this.txtBx_Nombre.Size = new System.Drawing.Size(191, 31);
            this.txtBx_Nombre.TabIndex = 2;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(6, 124);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(89, 25);
            this.lbl_Direccion.TabIndex = 1;
            this.lbl_Direccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // listBx_Pais
            // 
            this.listBx_Pais.FormattingEnabled = true;
            this.listBx_Pais.ItemHeight = 25;
            this.listBx_Pais.Location = new System.Drawing.Point(29, 321);
            this.listBx_Pais.Name = "listBx_Pais";
            this.listBx_Pais.Size = new System.Drawing.Size(323, 104);
            this.listBx_Pais.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pais:";
            // 
            // groupbx_Genero
            // 
            this.groupbx_Genero.Controls.Add(this.rb_NoBinario);
            this.groupbx_Genero.Controls.Add(this.rb_Femenino);
            this.groupbx_Genero.Controls.Add(this.rb_Masculino);
            this.groupbx_Genero.Location = new System.Drawing.Point(405, 35);
            this.groupbx_Genero.Name = "groupbx_Genero";
            this.groupbx_Genero.Size = new System.Drawing.Size(181, 147);
            this.groupbx_Genero.TabIndex = 7;
            this.groupbx_Genero.TabStop = false;
            this.groupbx_Genero.Text = "Genero";
            // 
            // rb_NoBinario
            // 
            this.rb_NoBinario.AutoSize = true;
            this.rb_NoBinario.Location = new System.Drawing.Point(6, 100);
            this.rb_NoBinario.Name = "rb_NoBinario";
            this.rb_NoBinario.Size = new System.Drawing.Size(120, 29);
            this.rb_NoBinario.TabIndex = 2;
            this.rb_NoBinario.TabStop = true;
            this.rb_NoBinario.Text = "No Binario";
            this.rb_NoBinario.UseVisualStyleBackColor = true;
            // 
            // rb_Femenino
            // 
            this.rb_Femenino.AutoSize = true;
            this.rb_Femenino.Location = new System.Drawing.Point(6, 65);
            this.rb_Femenino.Name = "rb_Femenino";
            this.rb_Femenino.Size = new System.Drawing.Size(115, 29);
            this.rb_Femenino.TabIndex = 1;
            this.rb_Femenino.TabStop = true;
            this.rb_Femenino.Text = "Femenino";
            this.rb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(6, 30);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(117, 29);
            this.rb_Masculino.TabIndex = 0;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.Text = "Masculino";
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // groupBx_Cursos
            // 
            this.groupBx_Cursos.Controls.Add(this.chB_JavaScript);
            this.groupBx_Cursos.Controls.Add(this.chB_Cplus);
            this.groupBx_Cursos.Controls.Add(this.chB_Csharp);
            this.groupBx_Cursos.Location = new System.Drawing.Point(411, 220);
            this.groupBx_Cursos.Name = "groupBx_Cursos";
            this.groupBx_Cursos.Size = new System.Drawing.Size(181, 147);
            this.groupBx_Cursos.TabIndex = 8;
            this.groupBx_Cursos.TabStop = false;
            this.groupBx_Cursos.Text = "Cursos";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Location = new System.Drawing.Point(411, 389);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(175, 36);
            this.btn_Ingresar.TabIndex = 9;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // chB_Csharp
            // 
            this.chB_Csharp.AutoSize = true;
            this.chB_Csharp.Location = new System.Drawing.Point(7, 31);
            this.chB_Csharp.Name = "chB_Csharp";
            this.chB_Csharp.Size = new System.Drawing.Size(60, 29);
            this.chB_Csharp.TabIndex = 0;
            this.chB_Csharp.Text = "C#";
            this.chB_Csharp.UseVisualStyleBackColor = true;
            // 
            // chB_Cplus
            // 
            this.chB_Cplus.AutoSize = true;
            this.chB_Cplus.Location = new System.Drawing.Point(7, 66);
            this.chB_Cplus.Name = "chB_Cplus";
            this.chB_Cplus.Size = new System.Drawing.Size(73, 29);
            this.chB_Cplus.TabIndex = 1;
            this.chB_Cplus.Text = "C++";
            this.chB_Cplus.UseVisualStyleBackColor = true;
            // 
            // chB_JavaScript
            // 
            this.chB_JavaScript.AutoSize = true;
            this.chB_JavaScript.Location = new System.Drawing.Point(7, 101);
            this.chB_JavaScript.Name = "chB_JavaScript";
            this.chB_JavaScript.Size = new System.Drawing.Size(121, 29);
            this.chB_JavaScript.TabIndex = 2;
            this.chB_JavaScript.Text = "Java Script";
            this.chB_JavaScript.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 448);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.groupBx_Cursos);
            this.Controls.Add(this.groupbx_Genero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBx_Pais);
            this.Controls.Add(this.groupBx_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBx_Usuario.ResumeLayout(false);
            this.groupBx_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUd_Edad)).EndInit();
            this.groupbx_Genero.ResumeLayout(false);
            this.groupbx_Genero.PerformLayout();
            this.groupBx_Cursos.ResumeLayout(false);
            this.groupBx_Cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBx_Usuario;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.NumericUpDown numericUd_Edad;
        private System.Windows.Forms.TextBox txtBx_Direccion;
        private System.Windows.Forms.TextBox txtBx_Nombre;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox listBx_Pais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbx_Genero;
        private System.Windows.Forms.RadioButton rb_NoBinario;
        private System.Windows.Forms.RadioButton rb_Femenino;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.GroupBox groupBx_Cursos;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.CheckBox chB_JavaScript;
        private System.Windows.Forms.CheckBox chB_Cplus;
        private System.Windows.Forms.CheckBox chB_Csharp;
    }
}