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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private bool anadirIngrediente()
        {
            try { 
                #region Archivo existe
                if (File.Exists("ingredientes.xml"))
                {
                    XmlTextWriter temp = new XmlTextWriter("ingredientes.temp", null);
                    temp.Formatting = Formatting.Indented;
                    temp.WriteStartDocument();
                    temp.WriteStartElement("ingredientes");
                    XmlTextReader original = new XmlTextReader("ingredientes.xml");
                    int cont = 0;
                    string nombre, id, maxima, actual;
                    while (original.ReadToFollowing("ingrediente"))
                    {
                        id = original.GetAttribute(0);
                        if (id == this.idIngrediente.Text)
                        {
                            MessageBox.Show("ID de Ingrediente ya existente!\nIntente con otro!", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            temp.Close();
                            File.Delete("ingredientes.temp");
                            original.Close();
                            return false;
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
                        cont++;
                    }
                    temp.WriteStartElement("ingrediente");
                    temp.WriteAttributeString("id", this.idIngrediente.Text);
                    temp.WriteElementString("nombre", this.nomIngrediente.Text);
                    temp.WriteElementString("cantidad_maxima", this.cantIngrediente.Text);
                    temp.WriteElementString("cantidad_actual", this.inIngrediente.Text);
                    temp.WriteEndElement();
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
                    XmlTextWriter original = new XmlTextWriter("ingredientes.xml", null);
                    original.Formatting = Formatting.Indented;
                    original.WriteStartDocument();
                    original.WriteStartElement("ingredientes");
                    original.WriteStartElement("ingrediente");
                    original.WriteAttributeString("id", idIngrediente.Text);
                    original.WriteElementString("nombre", nomIngrediente.Text);
                    original.WriteElementString("cantidad_maxima", cantIngrediente.Text);
                    original.WriteElementString("cantidad_actual", inIngrediente.Text);
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
                MessageBox.Show("Ingrediente añadido correctamente!", "OK",
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
            if (Convert.ToInt32(this.inIngrediente.Text) > Convert.ToInt32(this.cantIngrediente.Text))
            {
                MessageBox.Show("La cantidad inicial es mayor a la cantidad máxima!", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (anadirIngrediente())
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
