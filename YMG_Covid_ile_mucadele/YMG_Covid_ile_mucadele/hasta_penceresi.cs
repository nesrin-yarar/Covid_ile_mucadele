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
namespace YMG_Covid_ile_mucadele
{
    public partial class hasta_penceresi : Form
    {
        public hasta_penceresi()
        {
            InitializeComponent();
        }
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataSet ds;
        public static string sqlcon = @"Data Source=DESKTOP-2FALI47\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
       /*
         void griddoldur()
        {
            con = new SqlConnection(sqlcon);
            da = new SqlDataAdapter("select *from hasta_bilgisi",con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta_bilgisi");
            dataGridView1.DataSource = ds.Tables["hasta_bilgisi"];
            con.Close();
        }
       */
        public static string sqlsorgu;
        private void hasta_penceresi_Load(object sender, EventArgs e)
        {
            sqlsorgu = "select *from hasta_bilgi where TC like '"+veritabani_baglama.hasta+"'";
            veritabani_baglama.griddoldurma(dataGridView1,sqlsorgu);
            textBox1.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            label13.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (label13.Text == "+")
            {
                richTextBox1.Text = "Sayın hastamız, " + textBox3.Text + "\n Sağlık bakanlığı ekibimiz olarak geçmiş olsun dileklerimizi diliyoruz..\n " +
                    "Daha sağlıklı bir yaşam için lütfen test sonucunuz negatif olana kadar kendinizi izole ediniz. \n KULLANMANIZ GEREKEN İLAÇ= Favipiravir \n" +
                    "KULLANIM ŞEKLİ=Broşürlerde yer alan biliye göre, Favipiravir'in ilk gün sabah ve akşam 8'er tane, devamında ise 4 gün boyunca yine sabah ve akşam 3'er tane içilmesi gerekiyor. \n " +
                    "Hidroksiklorokinin ise sabah ve akşam 1'er tane olmak üzere 5. günün sonunda toplam 10 tablet alınması öneriliyor.\n " +
                    "KULLANMAMASI GEREKEN KİŞİLER= Favipiravir Gebelerde ve emziren annelerde kullanılmıyor \n" +
                    "Hidroksiklorokini; kalp rahatsızlığı ya da ritim bozukluğu olanlarda kullanılmıyor";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update hasta_bilgi set kronik_hastalik='" + textBox1.Text + "',boy='" + textBox4.Text + "',kilo='" + textBox5.Text + "',kan_grubu='" + textBox6.Text + "',dogum_tarih='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' where TC="+textBox2.Text+"";
            veritabani_baglama.komutyolla(sql);
            veritabani_baglama.griddoldurma(dataGridView1,sqlsorgu);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
             giriş grs = new giriş();
            this.Hide();
            grs.Show();
        }
    }
}
