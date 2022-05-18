using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace YMG_Covid_ile_mucadele
{
    class veritabani_baglama
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static DataSet ds;
        static SqlDataReader dr;
        public static string sqlcon = @"Data Source=DESKTOP-2FALI47\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True";
        public static string kullanici="";
        public static string hasta = "";
        public static bool baglanti_kontrol()
        {
            using (con = new SqlConnection(sqlcon))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;
                }
            }
        }
        //*************************************************************************************
        //datagridviewlerimizi doldurmak için kullandığımız fonk
        public static DataGridView griddoldurma(DataGridView data, string istenentablo)
        {
            con = new SqlConnection(sqlcon);
            da = new SqlDataAdapter(istenentablo, con);
            ds = new DataSet();
            da.Fill(ds, istenentablo);
            data.DataSource = ds.Tables[istenentablo];
            con.Close();
            return data;
            //.Rows.Count
        }

        //*************************************************************************************
        //Sayilar
        public static int Sayigetir(string istenentablo)
        {
            con = new SqlConnection(sqlcon);
            da = new SqlDataAdapter(istenentablo, con);
            ds = new DataSet();
            da.Fill(ds, istenentablo);
            con.Close();
            return ds.Tables[istenentablo].Rows.Count;
            //.Rows.Count
        }
        //**************************************************************************************
        //veritabanına ekleme çıkarma yapmak için gönderdiğimiz komut fonk
        public static void komutyolla(string sql)
        {
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //**************************************************************************************
        public static string MD5şifreleme(string şifrelenecekmetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(şifrelenecekmetin);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte İtem in dizi)
                sb.Append(İtem.ToString("x2").ToLower());
            return sb.ToString();
        }
        
    }
}
