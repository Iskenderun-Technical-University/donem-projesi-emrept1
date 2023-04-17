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
            conn.Open();
            cmd = new MySqlCommand("select * from ekle", conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            { 

            ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Ad"].ToString();
                ekle.SubItems.Add(dr["Soyad"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Kan"].ToString());
                ekle.SubItems.Add(dr["tc"].ToString());
                ekle.SubItems.Add(dr["oda"].ToString());


                listView1.Items.Add(ekle);
            }
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void form5_Load(object sender, EventArgs e)
        {
            veriGetir();
        }
    }
}
