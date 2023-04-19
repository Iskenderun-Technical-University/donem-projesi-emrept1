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
            cmd = new MySqlCommand("select * from 201", conn);
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

        }
    }
}
