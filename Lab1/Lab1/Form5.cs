using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form5 : Form
    {
        int[,] mas;
        int n;
        int m;
        Random ran = new Random();

        public Form5()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateMassive_Click(object sender, EventArgs e)
        {
            n = (int)this.numericUpDown1.Value;
            m = (int)this.numericUpDown2.Value;
            this.dataGridViewMas.ColumnCount = n;
            this.dataGridViewMas.RowCount = m;
            mas = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = ran.Next(-100, 100);
                    this.dataGridViewMas.Rows[j].Cells[i].Value = mas[i,j];
                }
            }
        }

        private void dataGridViewMas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
