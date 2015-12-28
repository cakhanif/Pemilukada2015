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
    public partial class candidat_form : Form
    {
        public candidat_form()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form main = new main_form();
            main.Show();
        }

        private void btnCari_MouseHover(object sender, EventArgs e)
        {
            btnCari.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnSearch_Hover;
        }

        private void btnCari_MouseLeave(object sender, EventArgs e)
        {
            btnCari.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnSearch;
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
        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKab.Items.Clear();
            if (cmbProv.SelectedItem == "Bengkulu")
            {
                cmbKab.Items.Add("Bengkulu");
            }
            else if (cmbProv.SelectedItem == "Jambi")
            {
                cmbKab.Items.Add("Jambi");
            }
            else if (cmbProv.SelectedItem == "Riau")
            {
                cmbKab.Items.Add("Kab. Pelalawan");
                cmbKab.Items.Add("Kab. Rokan Hilir");
            }
        }

        private void candidat_form_Load(object sender, EventArgs e)
        {
            cmbProv.Items.Add("Bengkulu");
            cmbProv.Items.Add("Jambi");
            cmbProv.Items.Add("Riau");
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            daftarcaleg caleg = new daftarcaleg();

            if (cmbKab.Text=="Bengkulu")
            {
                caleg.data_transfer("Bengkulu");
            }
            else if (cmbKab.Text == "Jambi")
            {
                caleg.data_transfer("Jambi");
            }
            else if (cmbKab.Text == "Kab. Pelalawan")
            {
                caleg.data_transfer("Kab. Pelalawan");
            }
            else if (cmbKab.Text == "Kab. Rokan Hilir")
            {
                caleg.data_transfer("Kab. Rokan Hilir");
            }

            this.Hide();
            caleg.Show();
        }

    }
}
