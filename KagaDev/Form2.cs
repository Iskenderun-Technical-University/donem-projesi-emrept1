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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            conn.Open();
            cmd = new MySqlCommand("Insert into oda1 (Adi,Soyadi) values ('" + textBox1.Text + "','"+textBox2.Text+"')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "201";
            conn.Open();
            cmd = new MySqlCommand("Insert into oda2 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = "202";
            conn.Open();
            cmd = new MySqlCommand("Insert into oda3 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Text = "203";
            conn.Open();
            cmd = new MySqlCommand("Insert into oda4 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = "204";
            conn.Open();
            cmd = new MySqlCommand("Insert into oda5 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "205";
            conn.Open();
            cmd = new MySqlCommand("Insert into oda6 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "206";
            conn.Open();
            cmd = new MySqlCommand("Insert into oda7 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox7.Text = "207";
            conn.Open();
            cmd = new MySqlCommand("insert into oda8 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Text = "208";
            conn.Open();
            cmd = new MySqlCommand("insert into oda9 (Adi,Soyadi) values ('" + textBox1.Text + "','" + textBox2.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into dataadd (Ad,Soyad,Cinsiyet,Telefon,Kan,tc,oda,giris,cikis) values (@ad,@soyad,@cinsiyet,@telefon,@kan,@tc,@oda,@giris,@cikis)";
            cmd = new MySqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox4.Text);
            cmd.Parameters.AddWithValue("@kan", textBox5.Text);
            cmd.Parameters.AddWithValue("@tc", textBox6.Text);
            cmd.Parameters.AddWithValue("@oda", textBox7.Text);
            cmd.Parameters.AddWithValue("@giris", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@cikis",dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("select * from oda1", conn);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                button2.Text = rd["Adi"].ToString() + "" + rd["Soyadi"].ToString();
            }
            conn.Close();
            if (button2.Text != "200")
            {
                button2.BackColor = Color.Red;
                button2.Enabled= false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda2", conn);
            MySqlDataReader rd1 = cmd.ExecuteReader();

            while (rd1.Read())
            {
                button3.Text = rd1["Adi"].ToString() + "" + rd1["Soyadi"].ToString();
            }
            conn.Close();
            if (button3.Text != "201")
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda3", conn);
            MySqlDataReader rd2 = cmd.ExecuteReader();

            while (rd2.Read())
            {
                button4.Text = rd2["Adi"].ToString() + "" + rd2["Soyadi"].ToString();
            }
            conn.Close();
            if (button4.Text != "202")
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda4", conn);
            MySqlDataReader rd3 = cmd.ExecuteReader();

            while (rd3.Read())
            {
                button5.Text = rd3["Adi"].ToString() + "" + rd3["Soyadi"].ToString();
            }
            conn.Close();
            if (button5.Text != "203")
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda5", conn);
            MySqlDataReader rd4 = cmd.ExecuteReader();

            while (rd4.Read())
            {
                button6.Text = rd4["Adi"].ToString() + "" + rd4["Soyadi"].ToString();
            }
            conn.Close();
            if (button6.Text != "204")
            {
                button6.BackColor = Color.Red;
                button6.Enabled = false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda6", conn);
            MySqlDataReader rd5 = cmd.ExecuteReader();

            while (rd5.Read())
            {
                button7.Text = rd5["Adi"].ToString() + "" + rd5["Soyadi"].ToString();
            }
            conn.Close();
            if (button7.Text != "205")
            {
                button7.BackColor = Color.Red;
                button7.Enabled = false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda7", conn);
            MySqlDataReader rd6 = cmd.ExecuteReader();

            while (rd6.Read())
            {
                button8.Text = rd6["Adi"].ToString() + "" + rd6["Soyadi"].ToString();
            }
            conn.Close();
            if (button8.Text != "206")
            {
                button8.BackColor = Color.Red;
                button8.Enabled = false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda8", conn);
            MySqlDataReader rd7 = cmd.ExecuteReader();

            while (rd7.Read())
            {
                button9.Text = rd7["Adi"].ToString() + "" + rd7["Soyadi"].ToString();
            }
            conn.Close();
            if (button9.Text != "207")
            {
                button9.BackColor = Color.Red;
                button9.Enabled = false;
            }
            conn.Open();
            cmd = new MySqlCommand("select * from oda9", conn);
            MySqlDataReader rd8 = cmd.ExecuteReader();

            while (rd8.Read())
            {
                button10.Text = rd8["Adi"].ToString() + "" + rd8["Soyadi"].ToString();
                
            }
            conn.Close();
            if (button10.Text != "208")
            {
                button10.BackColor = Color.Red;
                button10.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt edeceğiniz kişinin bilgilerini girerek ve oda numarasını seçerek kayıt yapınız.Lütfen alanları boş bırakmayınız.");
        }
    }
}
