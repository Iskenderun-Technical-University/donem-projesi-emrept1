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
        // veri tabanı bağlantısı ve parametrelerin tanımlanması
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kaga;Uid=root;Pwd='';Persist Security Info=True;Convert Zero Datetime=True;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        private void veriGetir()
        {
            listView1.Items.Clear();
            conn.Open();
            cmd = new MySqlCommand("select * from dataadd", conn);
            MySqlDataReader dr = cmd.ExecuteReader();// değişiklikleri uygulamak için executeReader fonksiyonu kullanılır.

            while(dr.Read())
            { 

            ListViewItem ekle = new ListViewItem();
                // verilerimizi data table aracılığı ile listwievimize çekiyoruz..
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
            // verileri listwieve çekiyoruz
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
            cmd = new MySqlCommand("delete from dataadd where id=("+id+")",conn); // silme sql sorgusu
            cmd.ExecuteNonQuery();
            conn.Close();
            veriGetir();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // kayıt eklemek için veri tabanındaki eklenecek alanlara textboxtaki verileri gönderdik.
            conn.Open();
            cmd = new MySqlCommand("update dataadd set Ad='"+textBox1.Text+"',Soyad='"+textBox2.Text+"',Cinsiyet='"+comboBox1.Text+"',Telefon='"+textBox4.Text+"',Kan='"+textBox5.Text+"',tc='"+textBox6.Text+"',oda='"+textBox7.Text+"'where ID="+id+"",conn);
            cmd.ExecuteNonQuery(); //komutları önizledik,başarıyla gerçekleştirip bağlantıyı kapattık ve verileri veri tabanından tekrar çektik yeni kayıt gelmesi için
            conn.Close(); 
            veriGetir();
            MessageBox.Show("Kayıt Eklendi.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            cmd = new MySqlCommand("select * from dataadd where Ad like '%"+textBox3.Text+"%'", conn);// textboxtaki veriyi veri tabanında aratma sorgusu yazdık eşleşirse;
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // yazdığımız sorguyu okurken eşleşme olursa listwieve parametre parametre dataları çekiyoruz..
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("delete from dataadd where id=(" + id + ")", conn); // silme sql sorgusu
            cmd.ExecuteNonQuery();
            conn.Close();
            veriGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // verileri temizlemek için
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            //
            //
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // kayıt eklemek için veri tabanındaki eklenecek alanlara textboxtaki verileri gönderdik.
            conn.Open();
            cmd = new MySqlCommand("update dataadd set Ad='" + textBox1.Text + "',Soyad='" + textBox2.Text + "',Cinsiyet='" + comboBox1.Text + "',Telefon='" + textBox4.Text + "',Kan='" + textBox5.Text + "',tc='" + textBox6.Text + "',oda='" + textBox7.Text + "'where ID=" + id + "", conn);
            cmd.ExecuteNonQuery(); //komutları önizledik,başarıyla gerçekleştirip bağlantıyı kapattık ve verileri veri tabanından tekrar çektik yeni kayıt gelmesi için
            conn.Close();
            veriGetir();
            MessageBox.Show("Kayıt Güncellendi.");
        }
    }
}
