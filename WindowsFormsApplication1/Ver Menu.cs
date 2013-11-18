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
                this.listBox1.Items.Add("(" + id + ") - " + nombre);
            }
            original.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
