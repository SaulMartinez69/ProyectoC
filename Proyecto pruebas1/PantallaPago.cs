using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_pruebas1
{
    public partial class PantallaPago : Form
    {
        int total = 0, cantidad;
        public PantallaPago()
        {
            InitializeComponent();
            this.KeyPreview = true;
            //Label label10 = this.Controls["label10"] as Label;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string textoIngresado = textBox8.Text;
            bool conversionExitosa = int.TryParse(textoIngresado, out cantidad);
            
            if(Global.america==true)
            {
                cantidad = cantidad * Global.precioproducto1;
            }
            if(Global.america==false)
            {
                cantidad = cantidad * Global.precioproducto2;
            }
            label10.Text = cantidad.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter pedidoss = new StreamWriter(@"C:\Users\Saulm\Desktop\Productos\Pedidos.txt", true);
            try
            {
                pedidoss.Write(textBox1.Text);//Numero de telefono
                pedidoss.Write("," + textBox2.Text);//Pais
                pedidoss.Write("," + textBox3.Text);//Estado
                pedidoss.Write("," + textBox9.Text);//Municipio
                pedidoss.Write("," + textBox4.Text);//Colonia
                pedidoss.Write("," + textBox5.Text);//Calle
                pedidoss.Write("," + textBox6.Text);//Numero casa
                pedidoss.Write("," + textBox7.Text);//Código Postal
                pedidoss.Write("," + textBox8.Text);//Cantidad
                pedidoss.Write("," + cantidad);//Total
                pedidoss.WriteLine();
                pedidoss.Close();
                MessageBox.Show("Pedido realizado, regresando al menú de productos");
                Global.productos.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.productos.Show();
            this.Hide();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
