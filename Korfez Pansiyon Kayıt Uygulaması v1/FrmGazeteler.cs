using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korfez_Pansiyon_Kayıt_Uygulaması_v1
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
        }
                      
      
        private void button3_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.milliyet.com.tr/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.hurriyet.com.tr/");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.haberler.com/");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.sabah.com.tr/");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.star.com.tr/");
        }

    }
}
