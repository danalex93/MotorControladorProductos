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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
        private bool anadirBoleta()
        {
            try
            {
                #region Archivo existe
                if (File.Exists("boletas.xml"))
                {
                    XmlTextWriter temp = new XmlTextWriter("boletas.temp", null);
                    temp.Formatting = Formatting.Indented;
                    temp.WriteStartDocument();
                    temp.WriteStartElement("boletas");
                    XmlTextReader original = new XmlTextReader("boletas.xml");
                    string idBol, edad, sexo, numero_acomp, hora, idGarzon, precioPre, precioFinal, idPromo;
                    string idPlato, precioDetalle;
                    Array  platos;
                    while (original.ReadToFollowing("boleta"))
                    {
                        idBol = original.GetAttribute(0);
                        if (idBol == this.idBoleta.Text)
                        {
                            MessageBox.Show("ID de Boleta ya existente!\nIntente con otro!", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            temp.Close();
                            File.Delete("boletas.temp");
                            original.Close();
                            return false;
                        }
                        original.ReadToFollowing("edad_cliente");
                        edad = original.ReadString();
                        original.ReadToFollowing("sexo");
                        sexo = original.ReadString();
                        original.ReadToFollowing("numero_acomp");
                        numero_acomp = original.ReadString();
                        original.ReadToFollowing("hora");
                        hora = original.ReadString();
                        original.ReadToFollowing("id_garzon");
                        idGarzon = original.ReadString();
                        original.ReadToFollowing("id_promocion");
                        idPromo = original.ReadString();
                        original.ReadToFollowing("precio_pre");
                        precioPre = original.ReadString();
                        original.ReadToFollowing("precio_final");
                        precioFinal = original.ReadString();
                        //escribir temporal
                        temp.WriteStartElement("boleta");
                        temp.WriteAttributeString("id_boleta", idBol);
                        temp.WriteElementString("edad_cliente", edad);
                        temp.WriteElementString("sexo", sexo);
                        temp.WriteElementString("numero_acomp", numero_acomp);
                        temp.WriteElementString("hora", hora);
                        temp.WriteElementString("id_garzon", idGarzon);
                        temp.WriteElementString("id_promocion", idPromo);
                        temp.WriteElementString("precio_pre", precioPre);
                        temp.WriteElementString("precio_final", precioFinal);
                        while (original.ReadToFollowing("id_platos")) {
                            temp.WriteStartElement("id_platos");
                            original.ReadToFollowing("id_plato");
                            idPlato = original.ReadString();
                            temp.WriteElementString("id_plato",idPlato);
                            original.ReadToFollowing("precio_detalle");
                            precioDetalle = original.ReadString();
                            temp.WriteElementString("precio_detalle", precioDetalle);
                            temp.WriteEndElement();
                        }
                        temp.WriteEndElement();
                    }
                    temp.WriteStartElement("boleta");
                    temp.WriteAttributeString("id_boleta", this.idBoleta.Text);
                    temp.WriteElementString("edad_cliente", this.edad.Text);
                    if (this.F.Checked)
                    {
                        temp.WriteElementString("sexo", "F");
                    }
                    if (this.M.Checked)
                    {
                        temp.WriteElementString("sexo", "M");
                    }
                    temp.WriteElementString("numero_acomp", this.acomp.Text);
                    temp.WriteElementString("hora", this.hora.Text);
                    temp.WriteElementString("id_garzon", this.garzon.Text);
                    temp.WriteElementString("id_promocion", "-1");
                    temp.WriteElementString("precio_pre", "-1");
                    temp.WriteElementString("precio_final", "-1");
                    platos = this.platos.Text.Split('/');
                    foreach (string idP in platos) {
                        temp.WriteStartElement("id_platos");
                        temp.WriteElementString("id_plato", idP);
                        temp.WriteElementString("precio_detalle", "-1");
                        temp.WriteEndElement();
                    }
                    temp.WriteEndElement();
                    temp.WriteEndElement();
                    temp.WriteEndDocument();
                    temp.Flush();
                    temp.Close();
                    original.Close();
                    File.Delete("boletas.xml");
                    File.Move("boletas.temp", "boletas.xml");
                }
                #endregion
                #region Archivo no existe
                else
                {
                    Array platos;
                    XmlTextWriter original = new XmlTextWriter("boletas.xml", null);
                    original.Formatting = Formatting.Indented;
                    original.WriteStartDocument();
                    original.WriteStartElement("boletas");
                    original.WriteStartElement("boleta");
                    original.WriteAttributeString("id_boleta", this.idBoleta.Text);
                    original.WriteElementString("edad_cliente", this.edad.Text);
                    if (this.F.Checked)
                    {
                        original.WriteElementString("sexo", "F");
                    }
                    if (this.M.Checked)
                    {
                        original.WriteElementString("sexo", "M");
                    }
                    original.WriteElementString("numero_acomp", this.acomp.Text);
                    original.WriteElementString("hora", this.hora.Text);
                    original.WriteElementString("id_garzon", this.garzon.Text);
                    original.WriteElementString("id_promocion", "-1");
                    original.WriteElementString("precio_pre", "-1");
                    original.WriteElementString("precio_final", "-1");
                    platos = this.platos.Text.Split('/');
                    foreach (string idP in platos)
                    {
                        original.WriteStartElement("id_platos");
                        original.WriteElementString("id_plato", idP);
                        original.WriteElementString("precio_detalle", "-1");
                        original.WriteEndElement();
                    }
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
                MessageBox.Show("Boleta añadida correctamente!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (anadirBoleta())
            {
                this.Close();
            }
            else {
                MessageBox.Show("Error al agregar boleta!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void idBoleta_TextChanged(object sender, EventArgs e)
        {

        }

        private void platos_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
