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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void bntLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadData(filePath);
            }
        }
        private void LoadData(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    DataTable dataTable = new DataTable();
                    string[] headers = reader.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    int rowCount = 1;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] rows = line.Split(',');
                            dataTable.Rows.Add(rows);
                            rowCount++;
                        }
                    }

                    dtgvpedidos.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.regreso.Show();
            this.Hide();
        }
    }
}
