using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sosialisasi_Pemilukada.Forms
{
    public partial class sosialisasi_form : Form
    {
        public sosialisasi_form()
        {
            InitializeComponent();
            
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
    }
}
