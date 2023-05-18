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
    public partial class ContraseñaAdmin : Form
    {
        public ContraseñaAdmin()
        {
            InitializeComponent();
        }
        string contraseña;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            contraseña = textBox1.Text;
            if (contraseña != "0000")
            {
                MessageBox.Show("CONTRASEÑA INCORRECTA, INTENTALO DE NUEVO O REGRESA AL MENÚ PRINCIPAL");
            }
            if(contraseña == "0000")
            {
                
                Global.PaginaAdmin.Show();
                this.Hide();
            }
        }
    }
}
