namespace WindowsFormsApplication1
{
    partial class Form12
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idPromo = new NumericTextBox();
            this.descuento = new NumericTextBox();
            this.id_plato_prom = new NumericTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese ID de Promoción:";
            //
            // label 2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 70);
            this.label2.Name = "label1";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese ID de plato:";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese descuento:";
            //
            //IdPromo
            //
            this.idPromo.Location = new System.Drawing.Point(152, 30);
            this.idPromo.Name = "idPromo";
            this.idPromo.Size = new System.Drawing.Size(156, 20);
            this.idPromo.TabIndex = 6;
            //
            //IdPlato
            this.id_plato_prom.Location = new System.Drawing.Point(152,100);
            this.id_plato_prom.Name = "idPromo";
            this.id_plato_prom.Size = new System.Drawing.Size(156, 20);
            this.id_plato_prom.TabIndex = 6;
            //
            //Descuento
            //
            this.descuento.Location = new System.Drawing.Point(152, 160);
            this.descuento.Name = "idPromo";
            this.descuento.Size = new System.Drawing.Size(156, 20);
            this.descuento.TabIndex = 6;
            //
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idPromo);
            this.Controls.Add(this.id_plato_prom);
            this.Controls.Add(this.descuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form12";
            this.Text = "Ingresar Promoción";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private NumericTextBox idPromo;
        private NumericTextBox id_plato_prom;
        private NumericTextBox descuento;
    }
}