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
namespace YMG_Covid_ile_mucadele
{
    public partial class hasta_bul : Form
    {
        public hasta_bul()
        {
            InitializeComponent();
        }
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataSet ds;
        static SqlDataReader dr;
        public static string sqlcon = @"Data Source=DESKTOP-2FALI47\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e) //- sonuçluları göster
        {
            veritabani_baglama.griddoldurma(dataGridView1, "select *from hasta_bilgi where test_sonucu='-'");
        }
        private void button1_Click(object sender, EventArgs e)//+ sonuçluları göster
        {
            veritabani_baglama.griddoldurma(dataGridView1, "select *from hasta_bilgi where test_sonucu='+'");
        }
        private void button4_Click(object sender, EventArgs e)//vefat edenleri göster
        {
            veritabani_baglama.griddoldurma(dataGridView1, "select *from vefat_giris");
        }
        private void hasta_bul_Load(object sender, EventArgs e)
        {
            veritabani_baglama.griddoldurma(dataGridView1, "select *from covid_test_giris");
            //toplam test sayısı
            sayı_bulma("select count(*) from hasta_bilgi");
            SqlDataReader dr1 = cmd.ExecuteReader();
            
            while (dr1.Read())
            {
                label15.Text = dr1[0].ToString();
            }
            con.Close();
            
            //negatif hasta sayısı
            sayı_bulma("select count(*) from hasta_bilgi where test_sonucu='-'");
            SqlDataReader dr2 = cmd.ExecuteReader();
            while (dr2.Read())
            {
                label14.Text = dr2[0].ToString();
            }
            con.Close();

            //pozitif hasta sayısı
            sayı_bulma("select count(*) from hasta_bilgi where test_sonucu='+'");
            SqlDataReader dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                label10.Text = dr3[0].ToString();
            }
            con.Close();

            //0-2 (BEBEK) Yaş Arası Covid Hasta
            sayı_bulma("select count(*) from covid_test_giris where dogum_tarihi between '01/01/2020' and '12/31/2022' ");
            SqlDataReader dr4 = cmd.ExecuteReader();
            while (dr4.Read())
            {
                label11.Text = dr4[0].ToString();
            }
            con.Close();

            //2-11(ÇOCUK) Yaş Arası Covid Hasta:
            sayı_bulma("select count(*) from covid_test_giris where dogum_tarihi between '01/01/2009' and '12/31/2020'  ");
            SqlDataReader dr5 = cmd.ExecuteReader();
            while (dr5.Read())
            {
                label12.Text = dr5[0].ToString();
            }
            con.Close();

            //12-24 (GENÇ) Yaş Arası Covid Hasta:
            sayı_bulma("select count(*) from covid_test_giris where dogum_tarihi between '01/01/1997' and '12/31/2009'  ");
            SqlDataReader dr6 = cmd.ExecuteReader();
            while (dr6.Read())
            {
                label17.Text = dr6[0].ToString();
            }
            con.Close();

            //24-65 (YETİŞKİN) Yaş Arası Covid Hasta:
            sayı_bulma("select count(*) from covid_test_giris where dogum_tarihi between '01/01/1990' and '12/31/1997' ");
            SqlDataReader dr7 = cmd.ExecuteReader();
            while (dr7.Read())
            {
                label13.Text = dr7[0].ToString();
            }
            con.Close();

            //65- üzeri(YAŞLI) Yaş Arası Covid Hasta:
            sayı_bulma("select count(*) from covid_test_giris where dogum_tarihi between '01/01/1900' and '12/31/1990'  ");
            SqlDataReader dr8 = cmd.ExecuteReader();
            while (dr8.Read())
            {
                label18.Text = dr8[0].ToString();
            }
            con.Close();

            //Covid Vefat Sayısı:
            sayı_bulma("select count(*) from vefat_giris");
            SqlDataReader dr9 = cmd.ExecuteReader();
            while (dr9.Read())
            {
                label16.Text = dr9[0].ToString();
            }
            con.Close();

        }
      
        public void sayı_bulma(string istenentablo)
        {
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = istenentablo;
                cmd.ExecuteNonQuery();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Personel_Giriş ps = new Personel_Giriş();
            this.Hide();
            ps.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select *from covid_test_giris where TC like '"+textBox1.Text+"'";
            veritabani_baglama.komutyolla(sql);
            veritabani_baglama.griddoldurma(dataGridView1, sql);
        }
    }
}