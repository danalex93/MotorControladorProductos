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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
        private bool borrarIngrediente()
        {
            try { 
                #region Archivo existe
                if (File.Exists("ingredientes.xml"))
                {
                    XmlTextWriter temp = new XmlTextWriter("ingredientes.temp", null); //Crear el fichero
                    temp.Formatting = Formatting.Indented; // darle formato
                    temp.WriteStartDocument(); // se abre el documento
                    temp.WriteStartElement("ingredientes"); // se aabre o inicia alumnos donde estan todos los alumnos
                    XmlTextReader original = new XmlTextReader("ingredientes.xml"); //lector seria como el puntero al fichero
                    string nombre, id, maxima, actual;
                    while (original.ReadToFollowing("ingrediente"))
                    {
                        id = original.GetAttribute(0);
                        if (id == this.textBox1.Text)
                        {
                            continue;
                        }
                        original.ReadToFollowing("nombre");
                        nombre = original.ReadString();
                        original.ReadToFollowing("cantidad_maxima");
                        maxima = original.ReadString();
                        original.ReadToFollowing("cantidad_actual");
                        actual = original.ReadString();

                        //escribir temporal
                        temp.WriteStartElement("ingrediente");
                        temp.WriteAttributeString("id", id);
                        temp.WriteElementString("nombre", nombre);
                        temp.WriteElementString("cantidad_maxima", maxima);
                        temp.WriteElementString("cantidad_actual", actual);
                        temp.WriteEndElement();
                    }
                    temp.WriteEndElement();
                    temp.WriteEndDocument();
                    temp.Flush();
                    temp.Close();
                    original.Close();
                    File.Delete("ingredientes.xml");
                    File.Move("ingredientes.temp", "ingredientes.xml");
                }
                #endregion
                #region Archivo no existe
                else
                {
                    MessageBox.Show("No existe inventario de ingredientes!", "Alerta",
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
                MessageBox.Show("Ingrediente borrado correctamente!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                borrarIngrediente();
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
