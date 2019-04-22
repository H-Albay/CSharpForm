using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Korfez_Pansiyon_Kayıt_Uygulaması_v1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LENOVA_G50;Initial Catalog=Korfez_Pansiyon_v3;Integrated Security=True");

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kırmızı renkli odalar doludur.");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                OdaNo101.Text = oku1["Adi"].ToString();
                

            }
            baglanti.Close();

            if (OdaNo101.Text != "101")
            {
                OdaNo101.BackColor = Color.Red;
                OdaNo101.Enabled = false;
            }
            else
            {
                OdaNo101.BackColor = Color.Green;
            }
            //Oda 101 biter.

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                OdaNo102.Text = oku2["Adi"].ToString();


            }
            baglanti.Close();

            if (OdaNo102.Text != "102")
            {
                OdaNo102.BackColor = Color.Red;
                OdaNo102.Enabled = false;
            }
            else
            {
                OdaNo102.BackColor = Color.Green;
            }
            //Oda 102 biter.


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                OdaNo103.Text = oku3["Adi"].ToString() ;


            }
            baglanti.Close();

            if (OdaNo103.Text != "103")
            {
                OdaNo103.BackColor = Color.Red;
                OdaNo103.Enabled = false;
            }
            else
            {
                OdaNo103.BackColor = Color.Green;
            }
            //Oda3 biter.


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                OdaNo104.Text = oku4["Adi"].ToString();


            }
            baglanti.Close();

            if (OdaNo104.Text != "104")
            {
                OdaNo104.BackColor = Color.Red;
                OdaNo104.Enabled = false;
            }
            else
            {
                OdaNo104.BackColor = Color.Green;
            }
            //Oda4 biter.


            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                OdaNo105.Text = oku5["Adi"].ToString() ;


            }
            baglanti.Close();

            if (OdaNo105.Text != "105")
            {
                OdaNo105.BackColor = Color.Red;
                OdaNo105.Enabled = false;
            }
            else
            {
                OdaNo105.BackColor = Color.Green;
            }
            //Oda5 biter.


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                OdaNo106.Text = oku6["Adi"].ToString() ;


            }
            baglanti.Close();

            if (OdaNo106.Text != "106")
            {
                OdaNo106.BackColor = Color.Red;
                OdaNo106.Enabled = false;
            }
            else
            {
                OdaNo106.BackColor = Color.Green;
            }
            //Oda106 biter.


            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                OdaNo107.Text = oku7["Adi"].ToString() ;


            }
            baglanti.Close();

            if (OdaNo107.Text != "107")
            {
                OdaNo107.BackColor = Color.Red;
                OdaNo107.Enabled = false;
            }
            else
            {
                OdaNo107.BackColor = Color.Green;
            }
            //Oda107 biter.


            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                OdaNo108.Text = oku8["Adi"].ToString() ;


            }
            baglanti.Close();

            if (OdaNo108.Text != "108")
            {
                OdaNo108.BackColor = Color.Red;
                OdaNo108.Enabled = false;
            }
            else
            {
                OdaNo108.BackColor = Color.Green;
            }
            //Oda108 biter.


            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                OdaNo109.Text = oku9["Adi"].ToString();


            }
            baglanti.Close();

            if (OdaNo109.Text != "109")
            {
                OdaNo109.BackColor = Color.Red;
                OdaNo109.Enabled = false;
            }
            else
            {
                OdaNo109.BackColor = Color.Green;
            }
        }

        private void OdaNo101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OdaNo102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OdaNo103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OdaNo104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OdaNo105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OdaNo106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OdaNo107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void OdaNo108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void OdaNo109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text  + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boştur.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text)*120;
            TxtUcret.Text = Ucret.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi)  values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı.");
            
            
        }
    }
}


