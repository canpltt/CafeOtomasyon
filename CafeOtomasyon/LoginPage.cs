using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class LoginPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=192.168.1.103,1433;Network Library=DBMSSOCN; initial catalog=CafeOtomasyon; User Id =ADMIN; Password=1;");
        public LoginPage()
        {
            InitializeComponent();
        }
        public static string Sicil, Ad, Soyad;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Şifre Göster")
            {
                linkLabel1.Text = "Şifre Gizle";
                textBox2.UseSystemPasswordChar = false;
            }
            else if (linkLabel1.Text == "Şifre Gizle")
            {
                linkLabel1.Text = "Şifre Göster";
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanici_Adi = textBox1.Text;
            string Sifre = textBox2.Text;
            bool kayitlimi = false;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Personel_Tablosu", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Kullanici_Adi == dr["Sicil"].ToString() && Sifre == dr["Sifre"].ToString())
                {
                    kayitlimi = true;
                    Ad = dr["Ad"].ToString();
                    Soyad = dr["Soyad"].ToString();
                    Sicil = dr["Sicil"].ToString();
                    break;
                }
            }
            con.Close();
            if (kayitlimi == true)
            {
                MainPage main = new MainPage();
                main.Show();
                this.Hide();
            }
            else MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır!");
        }
    }
}
