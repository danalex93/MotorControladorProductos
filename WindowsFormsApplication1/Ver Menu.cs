using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            leerPlatos();
        }

        private void leerPlatos()
        {
            XmlTextReader original = new XmlTextReader("platos.xml");
            string nombre, id;
            while (original.ReadToFollowing("plato"))
            {
                nombre = original.GetAttribute(0);
                original.ReadToFollowing("id");
                id = original.ReadString();
                this.listBox1.Items.Add(nombre);
            }
            original.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected;
            selected = this.listBox1.SelectedItem.ToString();
            this.listBox2.Items.Clear();
            XmlTextReader original = new XmlTextReader("platos.xml");
            string nombre, ingrediente1, ingrediente2, ingrediente3, cantidad1, cantidad2, cantidad3;
            while (original.ReadToFollowing("plato"))
            {
                nombre = original.GetAttribute(0);
                if (String.Compare(selected, nombre) == 0)
                {
                    original.ReadToFollowing("ingrediente1");
                    ingrediente1 = original.ReadString();
                    original.ReadToFollowing("ingrediente2");
                    ingrediente2 = original.ReadString();
                    original.ReadToFollowing("ingrediente3");
                    ingrediente3 = original.ReadString();
                    original.ReadToFollowing("cantidad1");
                    cantidad1 = original.ReadString();
                    original.ReadToFollowing("cantidad2");
                    cantidad2 = original.ReadString();
                    original.ReadToFollowing("cantidad3");
                    cantidad3 = original.ReadString();
                    this.listBox2.Items.Add(cantidad1 + " de " + ingrediente1);
                    this.listBox2.Items.Add(cantidad2 + " de " + ingrediente2);
                    this.listBox2.Items.Add(cantidad3 + " de " + ingrediente3);
                }
            }
            original.Close();
        }
    }
}
