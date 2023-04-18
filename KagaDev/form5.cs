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
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kaga;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        private void veriGetir()
        {
            listView1.Items.Clear();
            conn.Open();
            cmd = new MySqlCommand("select * from dataadd", conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            { 

            ListViewItem ekle = new ListViewItem();

                ekle.Text = dr["ID"].ToString();
                ekle.SubItems.Add(dr["Ad"].ToString());
                ekle.SubItems.Add(dr["Soyad"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Kan"].ToString());
                ekle.SubItems.Add(dr["tc"].ToString());
                ekle.SubItems.Add(dr["oda"].ToString());
                ekle.SubItems.Add(dr["giris"].ToString());
                ekle.SubItems.Add(dr["cikis"].ToString());

                listView1.Items.Add(ekle);
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void form5_Load(object sender, EventArgs e)
        {
          
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[9].Text;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("delete from dataadd where id=("+id+")",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            veriGetir();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text="";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            dateTimePicker1.Text="";
            dateTimePicker2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE dataadd"+"SET Ad=@ad,Soyad=@soyad,Cinsiyet=@cinsiyet,Telefon=@telefon,Kan=@kan,tc=@tc,oda=@oda,giris=@giris,cikis=@cikis" + 
                "WHERE ID="+id+"";
            cmd = new MySqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox4.Text);
            cmd.Parameters.AddWithValue("@kan", textBox5.Text);
            cmd.Parameters.AddWithValue("@tc", textBox6.Text);
            cmd.Parameters.AddWithValue("@oda", textBox7.Text);
            cmd.Parameters.AddWithValue("@giris", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@cikis", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Eklendi.");
        }
    }
}
