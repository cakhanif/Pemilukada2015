namespace Sosialisasi_Pemilukada.Forms
{
    partial class headline_berita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headline_berita));
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.movBerita = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTampil = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movBerita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTampil)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // movBerita
            // 
            this.movBerita.Enabled = true;
            this.movBerita.Location = new System.Drawing.Point(239, 124);
            this.movBerita.Name = "movBerita";
            this.movBerita.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("movBerita.OcxState")));
            this.movBerita.Size = new System.Drawing.Size(360, 270);
            this.movBerita.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Visby Round CF Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Items.AddRange(new object[] {
            "satu",
            "dua"});
            this.listBox1.Location = new System.Drawing.Point(24, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 214);
            this.listBox1.TabIndex = 3;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.Transparent;
            this.btnTampil.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.tampil_data;
            this.btnTampil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTampil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTampil.Location = new System.Drawing.Point(24, 376);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(159, 29);
            this.btnTampil.TabIndex = 6;
            this.btnTampil.TabStop = false;
            this.btnTampil.MouseLeave += new System.EventHandler(this.btnTampil_MouseLeave);
            this.btnTampil.MouseHover += new System.EventHandler(this.btnTampil_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Coral;
            this.textBox1.Font = new System.Drawing.Font("Visby Round CF Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 400);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 72);
            this.textBox1.TabIndex = 7;
            // 
            // headline_berita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.formBerita;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 484);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.movBerita);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "headline_berita";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movBerita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnBack;
        private AxWMPLib.AxWindowsMediaPlayer movBerita;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox btnTampil;
        private System.Windows.Forms.TextBox textBox1;
    }
}