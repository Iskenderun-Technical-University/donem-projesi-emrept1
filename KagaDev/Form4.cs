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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=kaga;Uid=root;Pwd='';Persist Security Info=True;Convert Zero Datetime=True;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        private void Form4_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("select * from oda1", conn);
            MySqlDataReader rd=cmd.ExecuteReader();

            while(rd.Read())
            {
                button2.Text = rd["Adi"].ToString() + ""+ rd["Soyadi"].ToString();
            }
            conn.Close();
            if(button2.Text!="200")
            {
                button2.BackColor = Color.Red;
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
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
