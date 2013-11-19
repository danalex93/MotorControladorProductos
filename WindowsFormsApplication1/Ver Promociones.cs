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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            verPromos();
        }
        private void verPromos()
        {
            XmlTextReader original = new XmlTextReader("promociones.xml"); //lector seria como el puntero al fichero
            string idPlato, descuento,id;
            while (original.ReadToFollowing("promocion"))
            {
                id = original.GetAttribute(0);
                original.ReadToFollowing("id_plato_prom");
                idPlato = original.ReadString();
                original.ReadToFollowing("descuento");
                descuento = original.ReadString();
                this.listBox1.Items.Add("(" + id + ") - ID Plato en promocion: " + idPlato + "Descuento de: $" + descuento);
            }
            original.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
