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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool borrarPromo()
        {
            try
            {
                #region Archivo existe
                if (File.Exists("promociones.xml"))
                {
                    XmlTextWriter temp = new XmlTextWriter("promociones.temp", null); //Crear el fichero
                    temp.Formatting = Formatting.Indented; // darle formato
                    temp.WriteStartDocument(); // se abre el documento
                    temp.WriteStartElement("promociones"); 
                    XmlTextReader original = new XmlTextReader("promociones.xml");
                    string id,idPlato,descuento;
                    while (original.ReadToFollowing("promocion"))
                    {
                        id = original.GetAttribute(0);
                        if (id == this.textBox1.Text)
                        {
                            continue;
                        }
                        original.ReadToFollowing("id_plato_prom");
                        idPlato = original.ReadString();
                        original.ReadToFollowing("descuento");
                        descuento = original.ReadString();

                        //escribir temporal
                        temp.WriteStartElement("promocion");
                        temp.WriteAttributeString("id", id);
                        temp.WriteElementString("id_plato_prom", idPlato);
                        temp.WriteElementString("descuento", descuento);
                        temp.WriteEndElement();
                    }
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
                    MessageBox.Show("No existe listado de promociones!", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                #endregion
            }
            catch
            {
                return false;
            }
            finally
            {
                MessageBox.Show("Promocion borrada correctamente!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                borrarPromo();
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha marcado el check!", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
