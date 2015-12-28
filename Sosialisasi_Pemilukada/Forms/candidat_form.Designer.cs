namespace Sosialisasi_Pemilukada.Forms
{
    partial class candidat_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.cmbKab = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnCari = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProv
            // 
            this.cmbProv.Font = new System.Drawing.Font("Visby Round CF Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(323, 198);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(207, 22);
            this.cmbProv.TabIndex = 0;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            // 
            // cmbKab
            // 
            this.cmbKab.Font = new System.Drawing.Font("Visby Round CF Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKab.FormattingEnabled = true;
            this.cmbKab.Location = new System.Drawing.Point(323, 275);
            this.cmbKab.Name = "cmbKab";
            this.cmbKab.Size = new System.Drawing.Size(207, 22);
            this.cmbKab.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnBack;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(12, 43);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.Transparent;
            this.btnCari.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.BtnSearch;
            this.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCari.Location = new System.Drawing.Point(550, 209);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(47, 47);
            this.btnCari.TabIndex = 4;
            this.btnCari.TabStop = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            this.btnCari.MouseLeave += new System.EventHandler(this.btnCari_MouseLeave);
            this.btnCari.MouseHover += new System.EventHandler(this.btnCari_MouseHover);
            // 
            // candidat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.CalegCari;
            this.ClientSize = new System.Drawing.Size(648, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbKab);
            this.Controls.Add(this.cmbProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "candidat_form";
            this.Load += new System.EventHandler(this.candidat_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.ComboBox cmbKab;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnCari;
    }
}