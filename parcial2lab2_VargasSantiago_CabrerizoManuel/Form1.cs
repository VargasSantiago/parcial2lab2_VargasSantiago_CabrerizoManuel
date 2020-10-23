using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2lab2_VargasSantiago_CabrerizoManuel
{
    public partial class Form1 : Form
    {
        Prenda p1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadProducto = 0;
            float precioProducto = 0;
            String calidadProducto;

            try
            {
                cantidadProducto = Convert.ToInt32(textBox2.Text);
                precioProducto = (float)Convert.ToDouble(textBox1.Text);
            }catch(System.FormatException er)
            {
                MessageBox.Show("Error: " + er);
            }
            
            if ((cantidadProducto >= 0) && (precioProducto >= 0))
            {
                if (opcionPremium.Checked)
                {
                    calidadProducto = "Premium";
                }
                else
                {
                    calidadProducto = "Standar";
                }

                if (opcionCamisa.Checked)
                {
                    p1 = new Camisa(cantidadProducto, precioProducto, calidadProducto, checkBox1.Checked);
                }
                else
                {
                    p1 = new Pantalon(cantidadProducto, precioProducto, calidadProducto, checkBox2.Checked);
                }

                p1.calcularPrecio();

                MessageBox.Show("El precio final es $" + p1.Precio);
            }
            else
            {
                MessageBox.Show("El precio y la cantidad deben ser positivos");
            }   
        }

        private void opcionCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (opcionCamisa.Checked)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
            }
        }

        private void opcionPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (opcionPantalon.Checked)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = true;
                checkBox1.Checked = false;
            }
        }
    }
}
