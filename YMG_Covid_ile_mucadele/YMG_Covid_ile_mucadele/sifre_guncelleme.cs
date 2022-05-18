using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace YMG_Covid_ile_mucadele
{
    public partial class sifre_guncelleme : Form
    {
        public sifre_guncelleme()
        {
            InitializeComponent();
        }

        private void sifre_guncelleme_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int ilk = r.Next(0, 50);
            int ikinci = r.Next(0, 50);
            sonuç = ilk + ikinci;
            label4.Text = ilk.ToString() + " + " + ikinci.ToString() + " =";
            label5.Text = veritabani_baglama.kullanici +" 'numaralı ID personelin şifresi değiştirelecek.. ";

        }
        public  int sonuç = 0;
       
        static SqlConnection con; //bağlantı kurmak için
        static SqlCommand cmd; //komutlandırmak için
        static SqlDataAdapter da; //verileri bağdaştırmak için
        static DataSet ds; //veri ayarları için
        static SqlDataReader dr;
        public static string sqlcon = @"Data Source=DESKTOP-2FALI47\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
     
        public void eskisifrekontrol()
        {
            string sorgu = "select sifre from personel_login where kıd=@user and sifre=@pass";
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", veritabani_baglama.kullanici) ;
            cmd.Parameters.AddWithValue("@pass", veritabani_baglama.MD5şifreleme(textBox_eskişifre.Text));
            con.Open();
            dr = cmd.ExecuteReader(); //eğer veri geldiyse 
            if (dr.Read())
            {
                // eski şifre doğruysa yapılacaklar
                string sql = "update personel_login set sifre= '" + veritabani_baglama.MD5şifreleme (textBox_yenişfre.Text) + "'";
                veritabani_baglama.komutyolla(sql);
                MessageBox.Show("şifre değiştirme işlemi başarılı");
                label5.Text = "şifreniz başarıyla değiştirildi";
            }
            else
            {
                label5.Text = "Eski şifre hatalı..";
            }
            con.Close();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                if (textBox4.Text == sonuç.ToString())
                {
                    if (textBox_yenişfre.Text == textBox_yenişifretekrar.Text)
                    {
                        eskisifrekontrol();

                    }
                    else
                    {
                        label5.Text = "yeni şifreler birbiriyle uyuşmuyor";
                    }

                }
                else
                {
                    label5.Text = "sayısal işlem hatalı..";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Personel_Giriş ps = new Personel_Giriş();
            this.Hide();
            ps.Show();
        }
    }
}
