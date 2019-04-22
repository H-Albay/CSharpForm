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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVA_G50;Initial Catalog=Korfez_Pansiyon_v3;Integrated Security=True");

        private void veriler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Stoklar ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["Cerez"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            veriler();
            
            MessageBox.Show("Kayıt işlemi yapıldı.");

        }
    }
}
