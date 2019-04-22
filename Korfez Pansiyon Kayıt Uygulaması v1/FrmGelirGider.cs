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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LENOVA_G50;Initial Catalog=Korfez_Pansiyon_v3;Integrated Security=True");

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(TxtPersonelMaas.Text);
            LblPersonelMaas.Text = (personel * 1200).ToString();


            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblAlinanUrunler1.Text) + Convert.ToInt32(LblAlinanUrunler2.Text) + Convert.ToInt32(LblAlinanUrunler3.Text) + Convert.ToInt32(LblFaturalar1.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            baglanti.Open(); //Kasadaki toplam tutar.
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            

            baglanti.Open();//Stok.Gıda giderleri.
            SqlCommand komut1 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
               LblAlinanUrunler1.Text = oku1["toplam1"].ToString();
            }
            baglanti.Close();

            baglanti.Open();//Stok.icecek giderleri.
            SqlCommand komut2 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                LblAlinanUrunler2.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();

            baglanti.Open();//Stok.Cerez giderleri.
            SqlCommand komut3 = new SqlCommand("Select sum(Cerez) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                LblAlinanUrunler3.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();


            baglanti.Open();//Stok.Elektrik giderleri.
            SqlCommand komut4 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                LblFaturalar1.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();


            baglanti.Open();//Stok.Su giderleri.
            SqlCommand komut5 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                LblFaturalar2.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();


            baglanti.Open();//Stok.İnternet giderleri.
            SqlCommand komut6 = new SqlCommand("Select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                LblFaturalar3.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();
            
        }
        


    }
}
