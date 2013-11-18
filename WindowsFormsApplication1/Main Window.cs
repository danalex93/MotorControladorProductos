using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            InitializeComponent();
            label1.Text = "Bienvenido! Por favor seleccione una opción en la izquierda.";
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Button 1!!
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            button7.Show();
            button7.Click -= button7_pClick;
            button7.Click -= button7_gClick;
            button7.Click -= button7_xClick;
            button7.Click -= button7_bClick;
            button7.Click -= button7_fClick;
            button7.Click += button7_iClick;
            button8.Show();
            button8.Click -= button8_pClick;
            button8.Click -= button8_gClick;
            button8.Click -= button8_xClick;
            button8.Click -= button8_bClick;
            button8.Click += button8_iClick;
            button9.Show();
            button9.Click -= button9_pClick;
            button9.Click -= button9_xClick;
            button9.Click += button9_iClick;
            button10.Show();
            button10.Click += button10_iClick;
            label1.Text = "Seleccione una opción correspondiente a ingredientes:";
            button7.Text = "Ver Inventario";
            button8.Text = "Ingresar Ingrediente";
            button9.Text = "Borrar Ingrediente";
            button10.Text = "Modificar Stock Ingrediente";
        }

        private void button7_iClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button8_iClick(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button9_iClick(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void button10_iClick(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }
        // ...

        // Button 2
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Show();
            button7.Show();
            button7.Click -= button7_iClick;
            button7.Click -= button7_gClick;
            button7.Click -= button7_xClick;
            button7.Click -= button7_bClick;
            button7.Click -= button7_fClick;
            button7.Click += button7_pClick;
            button8.Show();
            button8.Click -= button8_iClick;
            button8.Click -= button8_gClick;
            button8.Click -= button8_xClick;
            button8.Click -= button8_bClick;
            button8.Click += button8_pClick;
            button9.Show();
            button9.Click -= button9_iClick;
            button9.Click -= button9_xClick;
            button9.Click += button9_pClick;
            button10.Hide();
            label1.Text = "Seleccione una opción correspondiente a platos:";
            button7.Text = "Ver Menu";
            button8.Text = "Ingresar Plato";
            button9.Text = "Borrar Plato";
        }

        private void button7_pClick(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

        private void button8_pClick(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void button9_pClick(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }
        // ...

        //Button 3!!
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Show();
            button7.Show();
            button7.Click -= button7_pClick;
            button7.Click -= button7_gClick;
            button7.Click -= button7_xClick;
            button7.Click -= button7_bClick;
            button7.Click -= button7_fClick;
            button7.Click += button7_gClick;
            button8.Show();
            button8.Click -= button8_pClick;
            button8.Click -= button8_gClick;
            button8.Click -= button8_xClick;
            button8.Click -= button8_bClick;
            button8.Click += button8_gClick;
            button9.Hide();
            button10.Hide();
            label1.Text = "Seleccione una opción correspondiente a garzones:";
            button7.Text = "Ingresar Garzón";
            button8.Text = "Borrar garzón";
        }

        private void button7_gClick(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
        }

        private void button8_gClick(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
        }
        // ...

        // Button 4!!
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Show();
            button7.Show();
            button7.Click -= button7_pClick;
            button7.Click -= button7_iClick;
            button7.Click -= button7_gClick;
            button7.Click += button7_xClick;
            button7.Click -= button7_bClick;
            button7.Click -= button7_fClick;
            button8.Show();
            button8.Click -= button8_pClick;
            button8.Click -= button8_gClick;
            button8.Click -= button8_xClick;
            button8.Click -= button8_bClick;
            button8.Click += button8_xClick;
            button9.Show();
            button9.Click -= button9_pClick;
            button9.Click -= button9_xClick;
            button9.Click += button9_xClick;
            button10.Hide();
            label1.Text = "Seleccione una opción correspondiente a promociones:";
            button7.Text = "Ver Promociones Activas";
            button8.Text = "Ingresar Nueva Promoción";
            button9.Text = "Borrar Promoción";
        }
        private void button7_xClick(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            frm.Show();
        }
        private void button8_xClick(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
        }
        private void button9_xClick(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
        }
        // ...

        // Button 5!!
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Show();
            button7.Show();
            button7.Click -= button7_iClick;
            button7.Click -= button7_gClick;
            button7.Click -= button7_xClick;
            button7.Click -= button7_pClick;
            button7.Click -= button7_fClick;
            button7.Click += button7_bClick;
            button8.Show();
            button8.Click -= button8_iClick;
            button8.Click -= button8_gClick;
            button8.Click -= button8_xClick;
            button8.Click -= button8_pClick;
            button8.Click += button8_bClick;
            button9.Hide();
            button10.Hide();
            label1.Text = "Seleccione una opción correspondiente a boletas:";
            button7.Text = "Ver Boletas Emitidas";
            button8.Text = "Ingresar Nueva Boleta";
        }
        private void button7_bClick(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
        }
        private void button8_bClick(object sender, EventArgs e)
        {
            this.Close();
        }
        // ...

        // Button 5!!
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Show();
            button7.Show();
            button7.Click -= button7_iClick;
            button7.Click -= button7_gClick;
            button7.Click -= button7_xClick;
            button7.Click -= button7_pClick;
            button7.Click += button7_fClick;
            button8.Hide();
            button9.Hide();
            button10.Hide();
            label1.Text = "Seleccione una opción correspondiente a informe:";
            button7.Text = "Ver Informe";
        }
        private void button7_fClick(object sender, EventArgs e)
        {
            this.Close();
        }
        // ...

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
