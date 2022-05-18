using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMG_Covid_ile_mucadele
{
    public partial class Personel_Giriş : Form
    {
        public Personel_Giriş()
        {
            InitializeComponent();
        }

        private void Personel_Giriş_Load(object sender, EventArgs e)
        {
            veritabani_baglama.griddoldurma(dataGridView1, "select *from covid_test_giris");
            veritabani_baglama.griddoldurma(dataGridView2, "select *from vefat_giris");
            textBox1.Focus();
            label9.Text = veritabani_baglama.kullanici + " KID personel tarafından giriş yapıldı..";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker3.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker2.Value = DateTime.Now;
            textBox5.Focus();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //test girişi eklemek için
            string sql = "insert into covid_test_giris (TC,ad_soyad,test_sonuc,tarih,dogum_tarihi) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','"+ dateTimePicker3.Value.ToString("yyyy-MM-dd") + "')";
            veritabani_baglama.komutyolla(sql);
            veritabani_baglama.griddoldurma(dataGridView1, "select *from covid_test_giris");
            string sql2 = "insert into hasta_bilgi (TC,ad_soyad,test_sonucu,dogum_tarih) values('" + textBox1.Text + "','"+textBox2.Text+"','" + textBox3.Text + "','" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "')";
            veritabani_baglama.komutyolla(sql2);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //vefat girişi eklemek için
            string sql = "insert into vefat_giris (TC,ad_soyad,vefat_tarih,acıklama) values('" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "','" + textBox6.Text + "')";
            veritabani_baglama.komutyolla(sql);
            veritabani_baglama.griddoldurma(dataGridView2, "select *from vefat_giris");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hata durumunda test girişini silmek için
            string sql = "delete from covid_test_giris where TC='" + textBox1.Text + "' and ad_soyad='" + textBox2.Text + "' and test_sonuc='" + textBox3.Text + "'and tarih='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and dogum_tarihi= '" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'";
            veritabani_baglama.komutyolla(sql);
            veritabani_baglama.griddoldurma(dataGridView1, "select *from covid_test_giris");
            string sql2 = "delete from hasta_bilgi where TC like '"+ textBox1.Text+ "'";
            veritabani_baglama.komutyolla(sql2);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //hata durumunda vefat girişini silmek için
            string sql = "delete from vefat_giris where TC='" + textBox4.Text + "' and ad_soyad='" + textBox5.Text+"' and vefat_tarih='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and acıklama='"+textBox6.Text+"'";
            veritabani_baglama.komutyolla(sql);
            veritabani_baglama.griddoldurma(dataGridView2, "select *from vefat_giris");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //covid test sonucunu güncellemek için
            String sql = "update covid_test_giris set test_sonuc='"+textBox3.Text+ "' where  TC='" + textBox1.Text + "' and ad_soyad='" + textBox2.Text + "' and tarih='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and dogum_tarihi='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'";
            veritabani_baglama.komutyolla(sql);
            veritabani_baglama.griddoldurma(dataGridView1, "select *from covid_test_giris");
            String sql2 = "update hasta_bilgi set test_sonucu='" + textBox3.Text + "' where  TC='" + textBox1.Text + "' and ad_soyad='" + textBox2.Text + "' and dogum_tarih='" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'"; 
            veritabani_baglama.komutyolla(sql2);

        }


        private void hastaBulToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hasta_bul hb = new hasta_bul();
            this.Hide();
            hb.Show();
        }

        private void şifreGüncellemeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            sifre_guncelleme sifre_guncelleme = new sifre_guncelleme();
            this.Hide();
            sifre_guncelleme.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            giriş grs = new giriş();
            this.Hide();
            grs.Show();
        }
    }
}
