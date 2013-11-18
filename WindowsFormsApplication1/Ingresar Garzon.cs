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
    public partial class Form9 : Form
    {
        public Form9()
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

        private bool anadirGarzon()
        {
            try { 
                #region Archivo existe
            if (File.Exists("garzones.xml"))
            {
                XmlTextWriter temp = new XmlTextWriter("garzones.temp", null); //Crear el fichero
                temp.Formatting = Formatting.Indented; // darle formato
                temp.WriteStartDocument(); // se abre el documento
                temp.WriteStartElement("garzones"); // se aabre o inicia alumnos donde estan todos los alumnos
                XmlTextReader original = new XmlTextReader("garzones.xml"); //lector seria como el puntero al fichero
                int cont = 0;
                string nombre, id, edad;
                while (original.ReadToFollowing("garzon"))
                {
                    id = original.GetAttribute(0);
                    original.ReadToFollowing("nombre");
                    nombre = original.ReadString();
                    original.ReadToFollowing("edad");
                    edad = original.ReadString();

                    //escribir temporal
                    temp.WriteStartElement("garzon");
                    temp.WriteAttributeString("id", id);
                    temp.WriteElementString("nombre", nombre);
                    temp.WriteElementString("edad", edad);
                    temp.WriteEndElement();
                    cont++;
                }
                temp.WriteStartElement("garzon");
                temp.WriteAttributeString("id", cont.ToString());
                temp.WriteElementString("nombre", textBox1.Text);
                temp.WriteElementString("edad", numericUpDown1.Text.ToString());
                temp.WriteEndElement();
                temp.WriteEndElement();
                temp.WriteEndDocument();
                temp.Flush();
                temp.Close();
                original.Close();
                File.Delete("garzones.xml");
                File.Move("garzones.temp", "garzones.xml");
            }
            #endregion
                #region Archivo no existe
            else
            {
                XmlTextWriter original = new XmlTextWriter("garzones.xml", null);
                original.Formatting = Formatting.Indented;
                original.WriteStartDocument();
                original.WriteStartElement("garzones");
                original.WriteStartElement("garzon");
                original.WriteAttributeString("id", "0");
                original.WriteElementString("nombre", textBox1.Text.ToString());
                original.WriteElementString("edad", numericUpDown1.Text.ToString());
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
                MessageBox.Show("Garzon añadido correctamente!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (anadirGarzon())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error añadiendo garzón a sistema!", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
