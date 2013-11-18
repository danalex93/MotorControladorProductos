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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private bool modificarIngrediente()
        {
            bool check = false;
            try
            {
                #region Archivo existe
                if (File.Exists("ingredientes.xml"))
                {
                    XmlTextWriter temp = new XmlTextWriter("ingredientes.temp", null);
                    temp.Formatting = Formatting.Indented;
                    temp.WriteStartDocument();
                    temp.WriteStartElement("ingredientes");
                    XmlTextReader original = new XmlTextReader("ingredientes.xml");
                    int cont = 0, signo, nuevaCant;
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

                        //cambiar cantidad
                        if (id == this.textBox1.Text)
                        {
                            check = true;
                            if (radioButton1.Checked)
                                signo = 1;
                            else
                                signo = -1;
                            nuevaCant = Convert.ToInt32(actual) + Convert.ToInt32(this.textBox2.Text) * signo;
                            if (nuevaCant < 0)
                            {
                                MessageBox.Show("Cantidad retirada es mayor que la cantidad actual!", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                temp.Close();
                                File.Delete("ingredientes.temp");
                                original.Close();
                                return false;
                            }
                            else if (nuevaCant > Convert.ToInt32(maxima))
                            {
                                MessageBox.Show("Nueva cantidad es mayor que la máxima permitida!", "Alerta",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                temp.Close();
                                File.Delete("ingredientes.temp");
                                original.Close();
                                return false;
                            }
                            else
                                actual = nuevaCant.ToString();
                        }

                        //escribir temporal
                        temp.WriteStartElement("ingrediente");
                        temp.WriteAttributeString("id", id);
                        temp.WriteElementString("nombre", nombre);
                        temp.WriteElementString("cantidad_maxima", maxima);
                        temp.WriteElementString("cantidad_actual", actual);
                        temp.WriteEndElement();
                        cont++;
                    }
                    temp.WriteEndElement();
                    temp.WriteEndDocument();
                    temp.Flush();
                    temp.Close();
                    original.Close();
                    File.Delete("ingredientes.xml");
                    File.Move("ingredientes.temp", "ingredientes.xml");
                    if (check == false)
                    {
                        MessageBox.Show("No se modificó el inventario!\nEl ingrediente a modificar no existe!", "Notificación",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
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
                if (check)
                    MessageBox.Show("Ingrediente modificado correctamente!", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return check;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modificarIngrediente())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Error modificando Stock a sistema!", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
