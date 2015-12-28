namespace Sosialisasi_Pemilukada.Forms
{
    partial class faq_form
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
            this.txtPertanyaan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnKirim = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.answer_lbl = new System.Windows.Forms.Label();
            this.question_lbl = new System.Windows.Forms.Label();
            this.jawaban_box = new System.Windows.Forms.RichTextBox();
            this.pertanyaan_box = new System.Windows.Forms.RichTextBox();
            this.btnPrev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPertanyaan
            // 
            this.txtPertanyaan.BackColor = System.Drawing.SystemColors.Info;
            this.txtPertanyaan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPertanyaan.Location = new System.Drawing.Point(154, 420);
            this.txtPertanyaan.Multiline = true;
            this.txtPertanyaan.Name = "txtPertanyaan";
            this.txtPertanyaan.Size = new System.Drawing.Size(207, 54);
            this.txtPertanyaan.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "A      :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Q     :";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(154, 385);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 23);
            this.txtEmail.TabIndex = 49;
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
            this.btnBack.TabIndex = 50;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnKirim
            // 
            this.btnKirim.BackColor = System.Drawing.Color.Transparent;
            this.btnKirim.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.kirim_faq;
            this.btnKirim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKirim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKirim.Location = new System.Drawing.Point(381, 434);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(71, 40);
            this.btnKirim.TabIndex = 51;
            this.btnKirim.TabStop = false;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            this.btnKirim.MouseLeave += new System.EventHandler(this.btnKirim_MouseLeave);
            this.btnKirim.MouseHover += new System.EventHandler(this.btnKirim_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.Next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(584, 298);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 52;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // answer_lbl
            // 
            this.answer_lbl.AutoSize = true;
            this.answer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.answer_lbl.Location = new System.Drawing.Point(88, 219);
            this.answer_lbl.Name = "answer_lbl";
            this.answer_lbl.Size = new System.Drawing.Size(0, 13);
            this.answer_lbl.TabIndex = 53;
            // 
            // question_lbl
            // 
            this.question_lbl.AutoSize = true;
            this.question_lbl.BackColor = System.Drawing.Color.Transparent;
            this.question_lbl.Location = new System.Drawing.Point(86, 152);
            this.question_lbl.Name = "question_lbl";
            this.question_lbl.Size = new System.Drawing.Size(0, 13);
            this.question_lbl.TabIndex = 54;
            // 
            // jawaban_box
            // 
            this.jawaban_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.jawaban_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jawaban_box.Font = new System.Drawing.Font("Visby Round CF Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jawaban_box.Location = new System.Drawing.Point(89, 205);
            this.jawaban_box.Name = "jawaban_box";
            this.jawaban_box.Size = new System.Drawing.Size(478, 92);
            this.jawaban_box.TabIndex = 56;
            this.jawaban_box.Text = "";
            // 
            // pertanyaan_box
            // 
            this.pertanyaan_box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pertanyaan_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pertanyaan_box.Font = new System.Drawing.Font("Visby Round CF Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertanyaan_box.Location = new System.Drawing.Point(89, 151);
            this.pertanyaan_box.Name = "pertanyaan_box";
            this.pertanyaan_box.Size = new System.Drawing.Size(478, 44);
            this.pertanyaan_box.TabIndex = 57;
            this.pertanyaan_box.Text = "";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.prev;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Location = new System.Drawing.Point(36, 298);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 30);
            this.btnPrev.TabIndex = 58;
            this.btnPrev.TabStop = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.MouseLeave += new System.EventHandler(this.btnPrev_MouseLeave);
            this.btnPrev.MouseHover += new System.EventHandler(this.btnPrev_MouseHover);
            // 
            // faq_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sosialisasi_Pemilukada.Properties.Resources.formFAQ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 484);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.pertanyaan_box);
            this.Controls.Add(this.jawaban_box);
            this.Controls.Add(this.question_lbl);
            this.Controls.Add(this.answer_lbl);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPertanyaan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "faq_form";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPertanyaan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnKirim;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.Label answer_lbl;
        private System.Windows.Forms.Label question_lbl;
        private System.Windows.Forms.RichTextBox jawaban_box;
        private System.Windows.Forms.RichTextBox pertanyaan_box;
        private System.Windows.Forms.PictureBox btnPrev;
    }
}