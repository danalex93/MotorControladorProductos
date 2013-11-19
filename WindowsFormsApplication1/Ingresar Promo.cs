using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private bool anadirPromo()
        {
            try
            {
                #region Archivo existe
                if (File.Exists("promociones.xml"))
                {
                    XmlTextWriter temp = new XmlTextWriter("promociones.temp", null);
                    temp.Formatting = Formatting.Indented;
                    temp.WriteStartDocument();
                    temp.WriteStartElement("promociones");
                    XmlTextReader original = new XmlTextReader("promociones.xml");
                    int cont = 0;
                    string descuento,id,idPlato;
                    while (original.ReadToFollowing("promocion"))
                    {
                        id = original.GetAttribute(0);
                        if (id == this.idPromo.Text)
                        {
                            MessageBox.Show("ID de Promocion ya existente!\nIntente con otro!", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            temp.Close();
                            File.Delete("promociones.temp");
                            original.Close();
                            return false;
                        }
                        original.ReadToFollowing("descuento");
                        descuento = original.ReadString();
                        original.ReadToFollowing("id_plato_prom");
                        idPlato = original.ReadString();
                        //escribir temporal
                        temp.WriteStartElement("promocion");
                        temp.WriteAttributeString("id", id);
                        temp.WriteElementString("id_plato_prom", idPlato);
                        temp.WriteElementString("descuento", descuento);
                        temp.WriteEndElement();
                        cont++;
                    }
                    temp.WriteStartElement("promocion");
                    temp.WriteAttributeString("id", this.idPromo.Text);
                    temp.WriteElementString("id_plato_prom", this.id_plato_prom.Text);
                    temp.WriteElementString("descuento", this.descuento.Text);
                    temp.WriteEndElement();
                    temp.WriteEndElement();
                    temp.WriteEndDocument();
                    temp.Flush();
                    temp.Close();
                    original.Close();
                    File.Delete("promociones.xml");
                    File.Move("promociones.temp", "promociones.xml");
                }
                #endregion
                #region Archivo no existe
                else
                {
                    XmlTextWriter original = new XmlTextWriter("promociones.xml", null);
                    original.Formatting = Formatting.Indented;
                    original.WriteStartDocument();
                    original.WriteStartElement("promociones");
                    original.WriteStartElement("promocion");
                    original.WriteAttributeString("id", idPromo.Text);
                    original.WriteElementString("descuento", descuento.Text);
                    original.WriteElementString("id_plato_prom", id_plato_prom.Text);
                    original.WriteEndElement();
                    original.WriteEndElement();
                    original.WriteEndDocument();
                    original.Flush();
                    original.Close();
                }
                #endregion
            }
            catch
            {
                return false;
            }
            finally
            {
                MessageBox.Show("Promocion anadida correctamente!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return true;
        }
        private void Form12_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (anadirPromo())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error añadiendo promoción a sistema!", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
