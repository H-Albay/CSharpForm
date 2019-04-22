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
using System.Data.Sql;



namespace Korfez_Pansiyon_Kayıt_Uygulaması_v1
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LENOVA_G50;Initial Catalog=Korfez_Pansiyon_v3;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@kullaniciadi AND Sifre=@Sifresi";
                SqlParameter pm1 = new SqlParameter("kullaniciadi", TxtKullaniciAdi.Text.Trim());
                SqlParameter pm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(pm1);
                komut.Parameters.Add(pm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    FrmAnaform fr = new FrmAnaform();
                    fr.Show();
                    this.Hide();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
