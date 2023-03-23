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
    public partial class Form1 : Form
    {
        private string _openFile;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }
        private void обАвтореToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(); newForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(); newForm.Show();
        }
        private void матрицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5(); newForm.Show();
        }
    }
}
