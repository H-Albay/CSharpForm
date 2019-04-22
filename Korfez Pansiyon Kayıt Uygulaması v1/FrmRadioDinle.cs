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
    public partial class FrmRadioDinle : Form
    {
        public FrmRadioDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://17703.live.streamtheworld.com/JOY_TURK_SC";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://195.142.3.35/power/PowerJazz_mpeg_128_home/icecast.audio?/listen.pls";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://195.142.3.35/power/PowerGymTonic_mpeg_128_home/icecast.audio?/listen.pls ";
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.100/stream/170/;stream";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/hitplay?/listen.pls";
        }
    }
}
