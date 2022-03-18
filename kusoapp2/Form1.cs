using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kusoapp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Tashi(int x,int y)
        {
            int kotae1;
            kotae1 = x + y;
            return kotae1;
        }
        public int Hiki(int x, int y)
        {
            int kotae2;
            kotae2 = x - y;
            return kotae2;

        }
        public int Kake(int x, int y)
        {
            int kotae3;
            kotae3 = x * y;
            return kotae3;
        }

        public int Wari(int x,int y)
        {
            int kotae4;
            kotae4 = x / y;
            return kotae4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int ancer = Hiki(x, y);
            label1.Text = ancer.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int ancer = Tashi(x, y);
            label1.Text = ancer.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int ancer = Kake(x, y);
            label1.Text = ancer.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int ancer = Wari(x, y);
            label1.Text = ancer.ToString();
        }


    }
}
