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
    public partial class PaginaClientes : Form
    {
        string[] producto1 = Directory.GetFiles(@"C:\Users\Saulm\Desktop\Productos\1.Audifonos");
        string[] producto2 = Directory.GetFiles(@"C:\Users\Saulm\Desktop\Productos\2.AudifonosSony");
        int nump1 = 0, indice = 0, nump2 = 0, indice2 = 0;
        public PaginaClientes()
        {
            InitializeComponent();
            this.KeyPreview = true;
            pictureBox1.TabStop = false;
            pictureBox2.TabStop = false;
            pictureBox1.Image = new System.Drawing.Bitmap(producto1[nump1]);
            pictureBox2.Image = new System.Drawing.Bitmap(producto2[nump2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Global.prod1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.prod2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.regreso.Show();
            this.Hide();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Parent = this;
            pictureBox2.BringToFront();
            pictureBox2.SetBounds(0, 0, this.Width, this.Height);
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Parent = this;
            pictureBox1.BringToFront();
            pictureBox1.SetBounds(0, 0, this.Width, this.Height);
        }

        private void PaginaClientes_KeyDown(object sender, KeyEventArgs e)
        {
            int ultimo = producto1.Length-1;
            int ultimo2 = producto2.Length - 1;
            switch (e.KeyCode)
            {
                case Keys.D:
                    indice++;
                    indice2++;
                    if (indice > ultimo)
                    { indice = 0; }
                    if (indice2 > ultimo2)
                    { indice2 = 0; }
                    pictureBox1.Image = new System.Drawing.Bitmap(producto1[indice]);
                    pictureBox2.Image = new System.Drawing.Bitmap(producto2[indice2]);
                    break;
                case Keys.A:
                    indice--;
                    indice2--;
                    if (indice < 0)
                    { indice = ultimo; }
                    if (indice2 < 0)
                    { indice2 = ultimo2; }
                    pictureBox1.Image = new System.Drawing.Bitmap(producto1[indice]);
                    pictureBox2.Image = new System.Drawing.Bitmap(producto2[indice2]);
                    break;
                case Keys.Q:
                    pictureBox1_DoubleClick(null, null);
                    break;
                case Keys.Escape:
                    pictureBox1.Dock = DockStyle.None;
                    pictureBox1.Parent = this;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Location = new Point(137, 137);
                    pictureBox1.Size = new Size(200, 158);
                    pictureBox2.Dock = DockStyle.None;
                    pictureBox2.Parent = this;
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Location = new Point(467, 137);
                    pictureBox2.Size = new Size(200, 158);
                    break;
            }
        }
    }

}
