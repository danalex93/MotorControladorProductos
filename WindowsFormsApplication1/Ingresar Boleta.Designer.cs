namespace WindowsFormsApplication1
{
    partial class Form15
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.TextBox();
            this.garzon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.platos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.RadioButton();
            this.F = new System.Windows.Forms.RadioButton();
            this.acomp = new NumericTextBox();
            this.edad = new NumericTextBox();
            this.idBoleta = new NumericTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Boleta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edad cliente: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero de Acompañantes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hora: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Garzón:";
            // 
            // hora
            // 
            this.hora.Location = new System.Drawing.Point(101, 144);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(63, 20);
            this.hora.TabIndex = 14;
            // 
            // garzon
            // 
            this.garzon.Location = new System.Drawing.Point(102, 175);
            this.garzon.Name = "garzon";
            this.garzon.Size = new System.Drawing.Size(63, 20);
            this.garzon.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Platos (separar ID\'s usando \"/\"):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // platos
            // 
            this.platos.Location = new System.Drawing.Point(55, 243);
            this.platos.Name = "platos";
            this.platos.Size = new System.Drawing.Size(175, 20);
            this.platos.TabIndex = 17;
            this.platos.TextChanged += new System.EventHandler(this.platos_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(101, 86);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(34, 17);
            this.M.TabIndex = 20;
            this.M.TabStop = true;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            this.M.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(155, 86);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(31, 17);
            this.F.TabIndex = 21;
            this.F.TabStop = true;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // acomp
            // 
            this.acomp.AllowSpace = false;
            this.acomp.Location = new System.Drawing.Point(194, 115);
            this.acomp.Name = "acomp";
            this.acomp.Size = new System.Drawing.Size(36, 20);
            this.acomp.TabIndex = 13;
            // 
            // edad
            // 
            this.edad.AllowSpace = false;
            this.edad.Location = new System.Drawing.Point(130, 52);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(100, 20);
            this.edad.TabIndex = 10;
            // 
            // idBoleta
            // 
            this.idBoleta.AllowSpace = false;
            this.idBoleta.Location = new System.Drawing.Point(130, 18);
            this.idBoleta.Name = "idBoleta";
            this.idBoleta.Size = new System.Drawing.Size(100, 20);
            this.idBoleta.TabIndex = 1;
            this.idBoleta.TextChanged += new System.EventHandler(this.idBoleta_TextChanged);
            // 
            // Form15
            // 
            this.ClientSize = new System.Drawing.Size(274, 310);
            this.Controls.Add(this.F);
            this.Controls.Add(this.M);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.platos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.garzon);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.acomp);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBoleta);
            this.Controls.Add(this.label2);
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Nueva Boleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private NumericTextBox idBoleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private NumericTextBox edad;
        private NumericTextBox acomp;
        private System.Windows.Forms.TextBox hora;
        private System.Windows.Forms.TextBox garzon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox platos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton M;
        private System.Windows.Forms.RadioButton F;
    }
}