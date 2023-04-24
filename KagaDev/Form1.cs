using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KagaDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form5 f5 = new form5();
            f5.Show ();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KAGA Kayıt Sistemleri | Geliştirici: Samed Emre Kayaalp | İskenderun Teknik Üniversitesi");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Iskenderun-Technical-University/donem-projesi-emrept1");
        }
    }
}
