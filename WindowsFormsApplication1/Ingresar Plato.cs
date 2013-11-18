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
    public partial class Form7 : Form
    {
        public Form7()
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
            string nombre, id;
            while (original.ReadToFollowing("ingrediente"))
            {
                id = original.GetAttribute(0);
                original.ReadToFollowing("nombre");
                nombre = original.ReadString();
                this.comboBox2.Items.Add(nombre);
                this.comboBox3.Items.Add(nombre);
                this.comboBox4.Items.Add(nombre);
            }
            original.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool anadirPlato()
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
                        if (nombre == this.textBox2.Text)
                        {
                            MessageBox.Show("Nombre de Plato ya existente!\nIntente con otro!", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            temp.Close();
                            File.Delete("platos.temp");
                            original.Close();
                            return false;
                        }
                        if (String.Compare(nombre, this.textBox2.Text) == 0)
                        {
                            MessageBox.Show("ID de Plato ya existente!\nIntente con otro!", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            temp.Close();
                            File.Delete("platos.temp");
                            original.Close();
                            return false;
                        }


                        //escribir temporal
                        if (check == false)
                        {
                            if (String.Compare(this.textBox2.Text,nombre) > 0)
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
                            else
                            {
                                // escribir primero nuevo
                                temp.WriteStartElement("plato");
                                temp.WriteAttributeString("nombre", this.textBox2.Text);
                                temp.WriteElementString("id", this.numericTextBox1.Text);
                                temp.WriteElementString("precio", this.numericTextBox2.Text);
                                temp.WriteElementString("tipo", this.comboBox1.Text);
                                temp.WriteElementString("ingrediente1", this.comboBox2.Text);
                                temp.WriteElementString("ingrediente2", this.comboBox3.Text);
                                temp.WriteElementString("ingrediente3", this.comboBox4.Text);
                                temp.WriteElementString("cantidad1", this.numericUpDown1.Text);
                                temp.WriteElementString("cantidad2", this.numericUpDown2.Text);
                                temp.WriteElementString("cantidad3", this.numericUpDown3.Text);
                                temp.WriteEndElement();
                                // escribir el siguiente
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
                                check = true;
                            }
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
                }
                #endregion
                #region Archivo no existe
                else
                {
                    XmlTextWriter temp = new XmlTextWriter("platos.xml", null);
                    temp.Formatting = Formatting.Indented;
                    temp.WriteStartDocument();
                    temp.WriteStartElement("platos");
                    temp.WriteStartElement("plato");
                    temp.WriteAttributeString("nombre", this.textBox2.Text);
                    temp.WriteElementString("id", this.numericTextBox1.Text);
                    temp.WriteElementString("precio", this.numericTextBox2.Text);
                    temp.WriteElementString("tipo", this.comboBox1.Text);
                    temp.WriteElementString("ingrediente1", this.comboBox2.Text);
                    temp.WriteElementString("ingrediente2", this.comboBox3.Text);
                    temp.WriteElementString("ingrediente3", this.comboBox4.Text);
                    temp.WriteElementString("cantidad1", this.numericUpDown1.Text);
                    temp.WriteElementString("cantidad2", this.numericUpDown2.Text);
                    temp.WriteElementString("cantidad3", this.numericUpDown3.Text);
                    temp.WriteEndElement();
                    temp.WriteEndElement();
                    temp.Flush();
                    temp.Close();
                }
                #endregion
            }
            catch
            {
                return false;
            }
            finally
            {
                MessageBox.Show("Plato añadido correctamente!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (anadirPlato())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error añadiendo plato a sistema!", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

    }
}
