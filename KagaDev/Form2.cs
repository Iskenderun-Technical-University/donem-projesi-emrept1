using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace KagaDev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kaga;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Text = "200";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "201";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = "202";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text = "203";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = "204";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "205";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "206";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox7.Text = "207";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Text = "208";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into ekle (Ad,Soyad,Cinsiyet,Telefon,Kan,tc,oda,giris,cikis) values (@ad,@soyad,@cinsiyet,@telefon,@kan,@tc,@oda,@giris,@cikis)";
            cmd = new MySqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox4.Text);
            cmd.Parameters.AddWithValue("@kan", textBox5.Text);
            cmd.Parameters.AddWithValue("@tc", textBox6.Text);
            cmd.Parameters.AddWithValue("@oda", textBox7.Text);
            cmd.Parameters.AddWithValue("@cikis", Convert.ToString(dateTimePicker1));
            cmd.Parameters.AddWithValue("@cikis", Convert.ToInt32(dateTimePicker2));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("Kayıt Eklendi.");
        }
    }
}
