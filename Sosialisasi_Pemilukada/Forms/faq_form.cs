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
using System.Net.Mail;
using System.Web;

namespace Sosialisasi_Pemilukada.Forms
{
    public partial class faq_form : Form
    {
        public faq_form()
        {
            InitializeComponent();
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new System.Net.Mail.MailMessage();

                mail.From = new MailAddress("nichazah@gmail.com");
                mail.To.Add("cakhanif@outlook.com");
                mail.Subject = txtEmail.Text;
                mail.Body = txtPertanyaan.Text;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;


                using (SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587))
                {
                    // SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("nichazah@gmail.com", "inipasswd");

                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail.From.ToString(), mail.To.ToString(), mail.Subject, mail.Body);
                    MessageBox.Show("Terima Kasih, Pertannyaan Anda akan segera kami jawab");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtEmail.Clear();
            txtPertanyaan.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form main = new main_form();
            main.Show();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnBack_Hover;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnBack;
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.next_hover;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Next;
        }

        //=================================================================================================
        json_faq online = new json_faq();
        faq offline = new faq();
        private int indeks = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (online.error != 1)
            {
                online.generate_faq(indeks);
                pertanyaan_box.Text = online.pertanyaan;
                jawaban_box.Text = online.jawab;
                indeks++;
            }
            else
            {
                offline.Showfaq(indeks);
                pertanyaan_box.Text = offline.pertanyaan;
                jawaban_box.Text = offline.jawab;
                indeks++;
            }
                
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (online.error != 1)
            {
                online.generate_faq(indeks);
                pertanyaan_box.Text = online.pertanyaan;
                jawaban_box.Text = online.jawab;
                indeks--;
            }
            else
            {
                offline.Showfaq(indeks);
                pertanyaan_box.Text = offline.pertanyaan;
                jawaban_box.Text = offline.jawab;
                indeks--;
            }
        }

        private void btnPrev_MouseHover(object sender, EventArgs e)
        {
            btnPrev.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.prev_hover;
        }

        private void btnPrev_MouseLeave(object sender, EventArgs e)
        {
            btnPrev.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.prev;
        }

        private void btnKirim_MouseHover(object sender, EventArgs e)
        {
            btnKirim.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.kirim_faq_hover;
        }

        private void btnKirim_MouseLeave(object sender, EventArgs e)
        {
            btnKirim.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.kirim_faq;
        }
    }
}
