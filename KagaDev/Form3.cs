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
    public partial class Form3 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Form3()
        {
            // veri tabanı bağlantısı yapıldı.
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=kaga;Uid=root;Pwd='';");
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textboxtaki veriler veri tabanındaki admin kullanıcı adı ve şifresi ile eşleşmesi durumunda işlem yap.
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admingiris where usr='" + textBox1.Text + "' AND pwd='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //okuma işlemi başarılı ve eşleşirse giriş yap yoksa else durumunu döndür.
                MessageBox.Show("Giriş Başarılı.");
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girdiniz.");
            }
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KAGA Kayıt Sistemleri | Geliştirici: Samed Emre Kayaalp | İskenderun Teknik Üniversitesi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Iskenderun-Technical-University/donem-projesi-emrept1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
