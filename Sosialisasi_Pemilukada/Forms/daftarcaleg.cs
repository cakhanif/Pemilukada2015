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
    public partial class daftarcaleg : Form
    {
        public daftarcaleg()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            candidat_form calon = new candidat_form();
            calon.Show();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnBack_Hover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnBack;
        }

        //=======================================================================================================

        json_candidat online1 = new json_candidat();
        json_candidat online2 = new json_candidat();
        json_candidat online3 = new json_candidat();
        candidat offline1 = new candidat();
        candidat offline2 = new candidat();
        candidat offline3 = new candidat();
        gambar_load gambar1 = new gambar_load();
        gambar_load gambar2 = new gambar_load();
        gambar_load gambar3 = new gambar_load();
        private void daftarcaleg_Load(object sender, EventArgs e)
        {
            if (transfer == "Bengkulu")
            {
                label5.Hide();
                label6.Hide();
                calon_box3.Hide();
                wakil_box3.Hide();
            }
            else if (transfer == "Jambi")
            {
                label5.Hide();
                label6.Hide();
                calon_box3.Hide();
                wakil_box3.Hide();
            }
            else if (transfer == "Kab. Pelalawan")
            {
                label5.Hide();
                label6.Hide();
                calon_box3.Hide();
                wakil_box3.Hide();
            }

        }

        private string transfer;
        public void data_transfer(string x)
        {
            this.transfer = x;
        }
        private void Load_Data_Click(object sender, EventArgs e)
        {
            
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (transfer == "Bengkulu")
            {
                if (online1.error != 1)
                {
                    online1.generate_candidat(0);
                    calon_box1.Text = online1.calon;
                    wakil_box1.Text = online1.wakil;
                    online2.generate_candidat(1);
                    calon_box2.Text = online2.calon;
                    wakil_box2.Text = online2.wakil;
                }
                else
                {
                    offline1.Showcandidat(0);
                    calon_box1.Text = offline1.calon;
                    wakil_box1.Text = offline1.wakil;
                    offline2.Showcandidat(1);
                    calon_box2.Text = offline2.calon;
                    wakil_box2.Text = offline2.wakil;
                }

                gambar1.ShowImage(0);
                gambarcalon_1.Image = gambar1.gambar;
                gambar2.ShowImage(1);
                gambarcalon_2.Image = gambar2.gambar;

            }
            else if (transfer == "Jambi")
            {
                if (online1.error != 1)
                {
                    online1.generate_candidat(2);
                    calon_box1.Text = online1.calon;
                    wakil_box1.Text = online1.wakil;
                    online2.generate_candidat(3);
                    calon_box2.Text = online2.calon;
                    wakil_box2.Text = online2.wakil;
                }
                else
                {
                    offline1.Showcandidat(2);
                    calon_box1.Text = offline1.calon;
                    wakil_box1.Text = offline1.wakil;
                    offline2.Showcandidat(3);
                    calon_box2.Text = offline2.calon;
                    wakil_box2.Text = offline2.wakil;
                }

                gambar1.ShowImage(2);
                gambarcalon_1.Image = gambar1.gambar;
                gambar2.ShowImage(3);
                gambarcalon_2.Image = gambar2.gambar;
            }
            else if (transfer == "Kab. Pelalawan")
            {
                if (online1.error != 1)
                {
                    online1.generate_candidat(4);
                    calon_box1.Text = online1.calon;
                    wakil_box1.Text = online1.wakil;
                    online2.generate_candidat(5);
                    calon_box2.Text = online2.calon;
                    wakil_box2.Text = online2.wakil;
                }
                else
                {
                    offline1.Showcandidat(4);
                    calon_box1.Text = offline1.calon;
                    wakil_box1.Text = offline1.wakil;
                    offline2.Showcandidat(5);
                    calon_box2.Text = offline2.calon;
                    wakil_box2.Text = offline2.wakil;
                }
                gambar1.ShowImage(4);
                gambarcalon_1.Image = gambar1.gambar;
                gambar2.ShowImage(5);
                gambarcalon_2.Image = gambar2.gambar;
            }
            else if (transfer == "Kab. Rokan Hilir")
            {
                if (online1.error != 1)
                {
                    online1.generate_candidat(7);
                    calon_box1.Text = online1.calon;
                    wakil_box1.Text = online1.wakil;
                    online2.generate_candidat(8);
                    calon_box2.Text = online2.calon;
                    wakil_box2.Text = online2.wakil;
                    online3.generate_candidat(9);
                    calon_box3.Text = online3.calon;
                    wakil_box3.Text = online3.wakil;
                }
                else
                {
                    offline1.Showcandidat(7);
                    calon_box1.Text = offline1.calon;
                    wakil_box1.Text = offline1.wakil;
                    offline2.Showcandidat(8);
                    calon_box2.Text = offline2.calon;
                    wakil_box2.Text = offline2.wakil;
                    offline3.Showcandidat(9);
                    calon_box3.Text = offline3.calon;
                    wakil_box3.Text = offline3.wakil;
                }
                gambar1.ShowImage(7);
                gambarcalon_1.Image = gambar1.gambar;
                gambar2.ShowImage(8);
                gambarcalon_2.Image = gambar2.gambar;
                gambar3.ShowImage(9);
                gambarcalon_3.Image = gambar3.gambar;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.tampil_data_hover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.tampil_data;
        }
    }
    }
