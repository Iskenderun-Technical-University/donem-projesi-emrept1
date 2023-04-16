using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAGA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = "200";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "201";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "202";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "203";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "204";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text = "205";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "206";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.Text = "207";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "208";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mevcut durumdaki odalar müsaittir.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mevcut odalar kullanılmaktadır.");
        }
    }
}
