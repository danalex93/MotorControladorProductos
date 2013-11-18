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
    public partial class Form8 : Form
    {
        public Form8()
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
            string nombre;
            while (original.ReadToFollowing("plato"))
            {
                nombre = original.GetAttribute(0);
                this.comboBox1.Items.Add(nombre);
            }
            original.Close();
        }


        private bool borrarPlato()
        {
            try
            {
                #region Archivo existe
                if (File.Exists("platos.xml"))
                {
                    XmlTextWriter temp = new XmlTextWriter("platos.temp", null);
                    temp.Formatting = Formatting.Indented;
                    temp.WriteStartDocument();
                    temp.WriteStartElement("platos");
                    XmlTextReader original = new XmlTextReader("platos.xml");
                    string nombre, id, precio, tipo;
                    string ingrediente1, ingrediente2, ingrediente3;
                    string cantidad1, cantidad2, cantidad3;
                    bool check = false;
                    #region while
                    while (original.ReadToFollowing("plato"))
                    {
                        nombre = original.GetAttribute(0);
                        original.ReadToFollowing("id");
                        id = original.ReadString();
                        original.ReadToFollowing("precio");
                        precio = original.ReadString();
                        original.ReadToFollowing("tipo");
                        tipo = original.ReadString();
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

                        //revisar existencia
                        if (nombre == this.comboBox1.Text)
                        {
                            check = true;
                            continue;
                        }
                        else
                        {
                            temp.WriteStartElement("plato");
                            temp.WriteAttributeString("nombre", nombre);
                            temp.WriteElementString("id", id);
                            temp.WriteElementString("precio", precio);
                            temp.WriteElementString("tipo", tipo);
                            temp.WriteElementString("ingrediente1", ingrediente1);
                            temp.WriteElementString("ingrediente2", ingrediente2);
                            temp.WriteElementString("ingrediente3", ingrediente3);
                            temp.WriteElementString("cantidad1", cantidad1);
                            temp.WriteElementString("cantidad2", cantidad2);
                            temp.WriteElementString("cantidad3", cantidad3);
                            temp.WriteEndElement();
                        }
                    }
                    #endregion
                    temp.WriteEndDocument();
                    temp.Flush();
                    temp.Close();
                    original.Close();
                    File.Delete("platos.xml");
                    File.Move("platos.temp", "platos.xml");
                    if (check == false)
                    {
                        MessageBox.Show("El plato no se eliminó de sistema porque\nno estaba en el sistema!", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                #endregion
                #region Archivo no existe
                else
                {
                    MessageBox.Show("El archivo de platos no existe!", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                #endregion
            }
            catch
            {
                return false;
            }
            finally
            {
                MessageBox.Show("Plato borrado correctamente!", "OK",
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
                borrarPlato();
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
