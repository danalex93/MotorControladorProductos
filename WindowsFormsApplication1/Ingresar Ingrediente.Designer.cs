namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idIngrediente = new NumericTextBox();
            this.nomIngrediente = new System.Windows.Forms.TextBox();
            this.cantIngrediente = new NumericTextBox();
            this.inIngrediente = new NumericTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese ID de ingrediente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese nombre de ingrediente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese cantidad máxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese cantidad inicial:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idIngrediente
            // 
            this.idIngrediente.AllowSpace = false;
            this.idIngrediente.Location = new System.Drawing.Point(65, 30);
            this.idIngrediente.Name = "idIngrediente";
            this.idIngrediente.Size = new System.Drawing.Size(156, 20);
            this.idIngrediente.TabIndex = 6;
            // 
            // nomIngrediente
            // 
            this.nomIngrediente.Location = new System.Drawing.Point(65, 78);
            this.nomIngrediente.Name = "nomIngrediente";
            this.nomIngrediente.Size = new System.Drawing.Size(156, 20);
            this.nomIngrediente.TabIndex = 7;
            // 
            // cantIngrediente
            // 
            this.cantIngrediente.AllowSpace = false;
            this.cantIngrediente.Location = new System.Drawing.Point(65, 126);
            this.cantIngrediente.Name = "cantIngrediente";
            this.cantIngrediente.Size = new System.Drawing.Size(156, 20);
            this.cantIngrediente.TabIndex = 8;
            // 
            // inIngrediente
            // 
            this.inIngrediente.AllowSpace = false;
            this.inIngrediente.Location = new System.Drawing.Point(65, 175);
            this.inIngrediente.Name = "inIngrediente";
            this.inIngrediente.Size = new System.Drawing.Size(156, 20);
            this.inIngrediente.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.inIngrediente);
            this.Controls.Add(this.cantIngrediente);
            this.Controls.Add(this.nomIngrediente);
            this.Controls.Add(this.idIngrediente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Ingrediente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private NumericTextBox idIngrediente;
        private System.Windows.Forms.TextBox nomIngrediente;
        private NumericTextBox cantIngrediente;
        private NumericTextBox inIngrediente;
    }
}