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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            verBoletas();
        }
        private void verBoletas()
        {
            #region Archivo existe
            if (File.Exists("boletas.xml"))
            {
                XmlTextReader original = new XmlTextReader("boletas.xml");
                string idBol, edad, sexo, numero_acomp, hora, idGarzon, precioPre, precioFinal, idPromo;
                string idPlato, precioDetalle;
                while (original.ReadToFollowing("boleta"))
                {
                    idBol = original.GetAttribute(0);
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
                    this.listBox1.Items.Add("Boleta N°" + idBol + 
                    ":\n   Edad Cliente: " + edad + "   Sexo: " + sexo + "\n   Numero de acompañantes: " + numero_acomp + 
                    "\n   Hora: " + hora + "\n Atendido por: " + idGarzon + "\n Precio previo: $"+ precioPre + 
                    "-- Promociones: " + idPromo  + "Precio Final: $ " + precioFinal );
                    this.listBox1.Items.Add("Detalle: ");
                    while (original.ReadToNextSibling("id_platos"))
                    {
                        original.ReadToFollowing("id_plato");
                        idPlato = original.ReadString();
                        original.ReadToFollowing("precio_detalle");
                        precioDetalle = original.ReadString();
                        this.listBox1.Items.Add("--- Plato: " + idPlato + "-> $"+ precioDetalle );
                        original.ReadToNextSibling("id_platos","boleta");


                    }
                }
                
                original.Close();
            }
            #endregion
            #region Archivo no existe
            else
            {
                MessageBox.Show("Archivo boletas no existe!", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
