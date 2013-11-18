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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            leerIngredientes();
        }

        private void leerIngredientes()
        {
            XmlTextReader original = new XmlTextReader("ingredientes.xml"); //lector seria como el puntero al fichero
            string nombre, id, maxima, actual;
            while (original.ReadToFollowing("ingrediente"))
            {
                id = original.GetAttribute(0);
                original.ReadToFollowing("nombre");
                nombre = original.ReadString();
                original.ReadToFollowing("cantidad_maxima");
                maxima = original.ReadString();
                original.ReadToFollowing("cantidad_actual");
                actual = original.ReadString();
                this.listBox1.Items.Add("("+id+") - "+nombre + " - Cantidad actual: "+actual);
            }
            original.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
