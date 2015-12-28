using System;
using System.Windows.Forms;
using Sosialisasi_Pemilukada.Source;

namespace Sosialisasi_Pemilukada.Forms
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
         //   main_form main = new main_form();
         //   main.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.mainform;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            const string message = "Apakah Anda Yakin Ingin Keluar?";
            const string caption = "Keluar Aplikasi";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCaleg_Click(object sender, EventArgs e)
        {
            candidat_form caleg = new candidat_form();
            caleg.Show();
            this.Hide();
            caleg.FormClosing += Caleg_FormClosing;
        }
        private void Caleg_FormClosing(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnSosialisasi_Click(object sender, EventArgs e)
        {
            sosialisasi_form sos = new sosialisasi_form();
            sos.Show();
            this.Hide();
            sos.FormClosing += Sos_FormClosing;
        }
        private void Sos_FormClosing(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnFaq_Click(object sender, EventArgs e)
        {
            faq_form faq = new faq_form();
            faq.Show();
            this.Hide();
            faq.FormClosing += Faq_FormClosing;
        }
        private void Faq_FormClosing(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnBerita_Click(object sender, EventArgs e)
        {
            headline_berita news = new headline_berita();
            news.Show();
            this.Hide();
            news.FormClosing += News_FormClosing;
        }
        private void News_FormClosing(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnCaleg_MouseHover(object sender, EventArgs e)
        {
            btnCaleg.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Caleg_Clicked;
        }

        private void btnCaleg_MouseLeave(object sender, EventArgs e)
        {
            btnCaleg.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Caleg;
        }

        private void btnSosialisasi_MouseHover(object sender, EventArgs e)
        {
            btnSosialisasi.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Sosialisasi_Clicked;
        }

        private void btnSosialisasi_MouseLeave(object sender, EventArgs e)
        {
            btnSosialisasi.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Sosialisasi;
        }

        private void btnFaq_MouseHover(object sender, EventArgs e)
        {
            btnFaq.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Pertanyaan_clicked;
        }

        private void btnFaq_MouseLeave(object sender, EventArgs e)
        {
            btnFaq.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Pertanyaan;
        }

        private void btnBerita_MouseHover(object sender, EventArgs e)
        {
            btnBerita.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Berita_Clicked;
        }

        private void btnBerita_MouseLeave(object sender, EventArgs e)
        {
            btnBerita.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Berita;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnClose_Hover;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnClose;
        }

        private void btnMinimized_MouseHover(object sender, EventArgs e)
        {
            btnMinimized.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnMinimize_Hover;
        }

        private void btnMinimized_MouseLeave(object sender, EventArgs e)
        {
            btnMinimized.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnMinimize;
        }
    }
}
