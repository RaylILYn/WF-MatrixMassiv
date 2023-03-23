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
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Drawing2D;

namespace Lab1
{
    public partial class Form2 : Form
    {
        int[] mas;
        int n, xi, xj, mi, mj;
        Random ran = new Random();

        public Form2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.dataGridViewMas.RowCount = 1;
        }

        private void CreateMassive_Click(object sender, EventArgs e)
        {
            n = (int)this.numericUpDown1.Value;
            this.dataGridViewMas.ColumnCount = n;
            mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = ran.Next(-100, 100);
                this.dataGridViewMas.Rows[0].Cells[i].Value = mas[i];
            }
        }

        private void dataGridViewMas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            int summa = 0;
            this.richTextBox1.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                    summa += mas[i];
            }
            this.richTextBox1.Text += "Сумма элементов: " + summa + Environment.NewLine;
        }

        private void radioButtonPr_CheckedChanged(object sender, EventArgs e)
        {
            int pr = 1;
            xi = (int)this.numericUpDown2.Value;
            xj = (int)this.numericUpDown3.Value;
            this.richTextBox1.Clear();
            for (int i = 0; i < mas.Length; i++)
                if (mas[i] > xi & mas[i] < xj)
                {
                    pr *= mas[i];
                }
            this.richTextBox1.Text += "Произведение элементов: " + pr + Environment.NewLine;
        }

        private void radioButtonMax_CheckedChanged(object sender, EventArgs e)
        {
            int max = mas [0];
            mi = (int)this.numericUpDown4.Value;
            mj = (int)this.numericUpDown5.Value;
            this.richTextBox1.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > mi & mas[i] < mj)
                    if (max < mas[i])
                    {
                    max = mas[i];
                    }
            }
            this.richTextBox1.Text += "Максимальный элемент: " + max + Environment.NewLine;
        }

        private void radioButtonMin_CheckedChanged(object sender, EventArgs e)
        {
            int min = mas[0];
            this.richTextBox1.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                    if (min > mas[i])
                    {
                    min = mas[i];
                    }
            }
            this.richTextBox1.Text += "Минимальный элемент: " + min + Environment.NewLine;
        }

        private void radioButtonSort_CheckedChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            int index;
            int currentNumber;
            this.richTextBox1.Text += "Сортировка массива: " + Environment.NewLine;
            for (int i = 0; i < mas.Length; i++)
            {
                index = i;
                currentNumber = mas[i];
                while (index > 0 && currentNumber < mas[index - 1])
                {
                    mas[index] = mas[index - 1];
                    index--;
                }
                mas[index] = currentNumber;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                this.richTextBox1.Text += i + "-й [" + mas[i] + "]" + Environment.NewLine;
            }
        }

        private void AllOperations_Click(object sender, EventArgs e)
        {
            int summa = 0;
            this.richTextBox1.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                summa += mas[i];
            }
            this.richTextBox1.Text += "Сумма элементов: " + summa + Environment.NewLine;
            this.richTextBox1.Text += Environment.NewLine;

            int pr = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > xi & mas[i] < xj)
                {
                    pr *= mas[i];
                }
            }
            this.richTextBox1.Text += "Произведение элементов: " + pr + Environment.NewLine;
            this.richTextBox1.Text += Environment.NewLine;

            int max = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > mi & mas[i] < mj)
                    if (max < mas[i])
                    {
                        max = mas[i];
                    }
            }
            this.richTextBox1.Text += "Максимальный элемент: " + max + Environment.NewLine;
            this.richTextBox1.Text += Environment.NewLine;

            int min = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                    if (min > mas[i])
                    {
                        min = mas[i];
                    }
            }
            this.richTextBox1.Text += "Минимальный элемент: " + min + Environment.NewLine;
            this.richTextBox1.Text += Environment.NewLine;

            int index;
            int currentNumber;
            this.richTextBox1.Text += "Сортировка массива: " + Environment.NewLine;
            for (int i = 0; i < mas.Length; i++)
            {
                index = i;
                currentNumber = mas[i];
                while (index > 0 && currentNumber < mas[index - 1])
                {
                    mas[index] = mas[index - 1];
                    index--;
                }
                mas[index] = currentNumber;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                
                this.richTextBox1.Text += i+ "-й [" + mas[i] + "]" + Environment.NewLine;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.ShowDialog();
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }


    }
}
