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

namespace Proyecto_pruebas1
{
    public partial class Producto2 : Form
    {
        string[] producto2 = Directory.GetFiles(@"C:\Users\Saulm\Desktop\Productos\2.AudifonosSony");
        public Producto2()
        {
            InitializeComponent();
            pictureBox1.TabStop = false;
            pictureBox1.Image = new System.Drawing.Bitmap(producto2[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.pedidos.Show();
            Global.america = false;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.regreso.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.productos.Show();
            this.Hide();
        }
    }
}
