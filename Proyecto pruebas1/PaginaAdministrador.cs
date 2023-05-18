using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_pruebas1
{
    public partial class PaginaAdministrador : Form
    {
        public PaginaAdministrador()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Global.modprecios.Show();
            this.Hide();
        }
    }
}
