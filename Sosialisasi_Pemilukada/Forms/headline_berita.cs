using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sosialisasi_Pemilukada.Source;
using Sosialisasi_Pemilukada.Process;

namespace Sosialisasi_Pemilukada.Forms
{
    public partial class headline_berita : Form
    {
        public headline_berita()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form main = new main_form();
            main.Show();
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)movBerita.Ctlcontrols;

            // Check first to be sure the operation is valid. 
            if (controls.get_isAvailable("stop"))
            {
                controls.stop();
            }
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnBack_Hover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnBack;
        }

        //========================================================================================================

        json_berita online = new json_berita();


        private void button1_Click(object sender, EventArgs e)
        {
            online.generate_berita(0);
          //  listBox1.Items.Add();
        }

        private void btnTampil_MouseHover(object sender, EventArgs e)
        {
            btnTampil.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.tampil_data_hover;
        }

        private void btnTampil_MouseLeave(object sender, EventArgs e)
        {
            btnTampil.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.tampil_data;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
