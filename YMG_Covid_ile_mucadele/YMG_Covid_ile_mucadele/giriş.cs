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
    public partial class giriş : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        string sqlcon = @"Data Source=DESKTOP-2FALI47\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
        public giriş()
        {
            InitializeComponent();
        }

        bool personel_login_fonk(string kıd, string sifre)
        {
            string sorgu = "select * from personel_login where kıd=@user and sifre=@pass";
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user",kıd);
            cmd.Parameters.AddWithValue("@pass", sifre);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
       
        bool hasta_login_fonk(string kıd)
        {
            string sorgu = "select * from hasta_bilgi where TC=@user";
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kıd);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        int denemesayisi = 3;
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (personel_login_fonk(textBox2.Text,  textBox1.Text))
            {
                MessageBox.Show("başarılı giriş..");
                this.Hide();
                veritabani_baglama.kullanici= textBox2.Text;
               Personel_Giriş pg = new Personel_Giriş();
                pg.Show();
            }
            else
            {
                denemesayisi--;
                MessageBox.Show("hatalı giriş.." + denemesayisi + " deneme hakkınız kaldı");
                if (denemesayisi == 0)
                {
                    MessageBox.Show("fazla hatalı giriş yaptınız. Tekrardan giriş yapabilmek için 444 1 444 bloke şifrenizi yeniletiniz");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (hasta_login_fonk(textBox3.Text))
            {
                MessageBox.Show("başarılı giriş..");
                veritabani_baglama.hasta = textBox3.Text;
                this.Hide();
                hasta_penceresi hp = new hasta_penceresi();
                hp.Show();
            }
            else
            {
                MessageBox.Show("hatalı giriş.."); 
            }

        }

        private void giriş_Load(object sender, EventArgs e)
        {
            textBox3.Focus();
        }
    }
            
    
}
