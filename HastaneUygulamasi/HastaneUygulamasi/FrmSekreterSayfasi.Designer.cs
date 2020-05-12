namespace HastaneUygulamasi
{
    partial class FrmSekreterSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterSayfasi));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gBoxDoktorlar = new System.Windows.Forms.GroupBox();
            this.gBoxBranslar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.LbAdSoyad = new System.Windows.Forms.Label();
            this.LbTc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CbxDoktor = new System.Windows.Forms.ComboBox();
            this.CbxBrans = new System.Windows.Forms.ComboBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.ChxDurum = new System.Windows.Forms.CheckBox();
            this.MTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.MTxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.MTxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnRandevuListe = new System.Windows.Forms.Button();
            this.BtnBransPaneli = new System.Windows.Forms.Button();
            this.BtnDoktorPaneli = new System.Windows.Forms.Button();
            this.BtnDuyurular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gBoxDoktorlar.SuspendLayout();
            this.gBoxBranslar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(393, 322);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // gBoxDoktorlar
            // 
            this.gBoxDoktorlar.Controls.Add(this.dataGridView2);
            this.gBoxDoktorlar.Location = new System.Drawing.Point(591, 275);
            this.gBoxDoktorlar.Name = "gBoxDoktorlar";
            this.gBoxDoktorlar.Size = new System.Drawing.Size(399, 352);
            this.gBoxDoktorlar.TabIndex = 7;
            this.gBoxDoktorlar.TabStop = false;
            this.gBoxDoktorlar.Text = "Doktorlar";
            // 
            // gBoxBranslar
            // 
            this.gBoxBranslar.Controls.Add(this.dataGridView1);
            this.gBoxBranslar.Location = new System.Drawing.Point(588, 26);
            this.gBoxBranslar.Name = "gBoxBranslar";
            this.gBoxBranslar.Size = new System.Drawing.Size(399, 246);
            this.gBoxBranslar.TabIndex = 6;
            this.gBoxBranslar.TabStop = false;
            this.gBoxBranslar.Text = "Branşlar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "TC No:";
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(6, 30);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(261, 178);
            this.RchDuyuru.TabIndex = 2;
            this.RchDuyuru.Text = "";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(71, 214);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(130, 37);
            this.BtnOlustur.TabIndex = 0;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // LbAdSoyad
            // 
            this.LbAdSoyad.AutoSize = true;
            this.LbAdSoyad.Location = new System.Drawing.Point(113, 85);
            this.LbAdSoyad.Name = "LbAdSoyad";
            this.LbAdSoyad.Size = new System.Drawing.Size(16, 23);
            this.LbAdSoyad.TabIndex = 20;
            this.LbAdSoyad.Text = "-";
            // 
            // LbTc
            // 
            this.LbTc.AutoSize = true;
            this.LbTc.Location = new System.Drawing.Point(85, 36);
            this.LbTc.Name = "LbTc";
            this.LbTc.Size = new System.Drawing.Size(120, 23);
            this.LbTc.TabIndex = 16;
            this.LbTc.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Controls.Add(this.BtnOlustur);
            this.groupBox2.Location = new System.Drawing.Point(16, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 283);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.LbAdSoyad);
            this.groupBox1.Controls.Add(this.LbTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(277, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 183);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sekreter Bilgi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ad Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "TC No:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CbxDoktor);
            this.groupBox6.Controls.Add(this.CbxBrans);
            this.groupBox6.Controls.Add(this.BtnKaydet);
            this.groupBox6.Controls.Add(this.ChxDurum);
            this.groupBox6.Controls.Add(this.MTxtTc);
            this.groupBox6.Controls.Add(this.MTxtSaat);
            this.groupBox6.Controls.Add(this.MTxtTarih);
            this.groupBox6.Controls.Add(this.Txtid);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(308, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(277, 472);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Randevu Paneli";
            // 
            // CbxDoktor
            // 
            this.CbxDoktor.FormattingEnabled = true;
            this.CbxDoktor.Location = new System.Drawing.Point(93, 249);
            this.CbxDoktor.Name = "CbxDoktor";
            this.CbxDoktor.Size = new System.Drawing.Size(121, 31);
            this.CbxDoktor.TabIndex = 5;
            // 
            // CbxBrans
            // 
            this.CbxBrans.FormattingEnabled = true;
            this.CbxBrans.Location = new System.Drawing.Point(93, 209);
            this.CbxBrans.Name = "CbxBrans";
            this.CbxBrans.Size = new System.Drawing.Size(121, 31);
            this.CbxBrans.TabIndex = 4;
            this.CbxBrans.SelectedIndexChanged += new System.EventHandler(this.CbxBrans_SelectedIndexChanged);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(70, 356);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(130, 46);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ChxDurum
            // 
            this.ChxDurum.AutoSize = true;
            this.ChxDurum.Location = new System.Drawing.Point(93, 323);
            this.ChxDurum.Name = "ChxDurum";
            this.ChxDurum.Size = new System.Drawing.Size(84, 27);
            this.ChxDurum.TabIndex = 7;
            this.ChxDurum.Text = "Durum";
            this.ChxDurum.UseVisualStyleBackColor = true;
            // 
            // MTxtTc
            // 
            this.MTxtTc.Location = new System.Drawing.Point(93, 286);
            this.MTxtTc.Mask = "00000000000";
            this.MTxtTc.Name = "MTxtTc";
            this.MTxtTc.Size = new System.Drawing.Size(121, 31);
            this.MTxtTc.TabIndex = 6;
            this.MTxtTc.ValidatingType = typeof(int);
            // 
            // MTxtSaat
            // 
            this.MTxtSaat.Location = new System.Drawing.Point(93, 168);
            this.MTxtSaat.Mask = "00:00";
            this.MTxtSaat.Name = "MTxtSaat";
            this.MTxtSaat.Size = new System.Drawing.Size(121, 31);
            this.MTxtSaat.TabIndex = 3;
            this.MTxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MTxtTarih
            // 
            this.MTxtTarih.Location = new System.Drawing.Point(93, 126);
            this.MTxtTarih.Mask = "00/00/0000";
            this.MTxtTarih.Name = "MTxtTarih";
            this.MTxtTarih.Size = new System.Drawing.Size(121, 31);
            this.MTxtTarih.TabIndex = 2;
            this.MTxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(93, 82);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(121, 31);
            this.Txtid.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "TC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = "Doktor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Branş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Saat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "id:";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.BtnDuyurular);
            this.groupBox3.Controls.Add(this.BtnRandevuListe);
            this.groupBox3.Controls.Add(this.BtnBransPaneli);
            this.groupBox3.Controls.Add(this.BtnDoktorPaneli);
            this.groupBox3.Location = new System.Drawing.Point(22, 504);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 123);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // BtnRandevuListe
            // 
            this.BtnRandevuListe.Location = new System.Drawing.Point(288, 49);
            this.BtnRandevuListe.Name = "BtnRandevuListe";
            this.BtnRandevuListe.Size = new System.Drawing.Size(137, 42);
            this.BtnRandevuListe.TabIndex = 2;
            this.BtnRandevuListe.Text = "Randevu Liste";
            this.BtnRandevuListe.UseVisualStyleBackColor = true;
            this.BtnRandevuListe.Click += new System.EventHandler(this.BtnRandevuListe_Click);
            // 
            // BtnBransPaneli
            // 
            this.BtnBransPaneli.Location = new System.Drawing.Point(154, 49);
            this.BtnBransPaneli.Name = "BtnBransPaneli";
            this.BtnBransPaneli.Size = new System.Drawing.Size(128, 42);
            this.BtnBransPaneli.TabIndex = 1;
            this.BtnBransPaneli.Text = "Branş Paneli";
            this.BtnBransPaneli.UseVisualStyleBackColor = true;
            this.BtnBransPaneli.Click += new System.EventHandler(this.BtnBransPaneli_Click);
            // 
            // BtnDoktorPaneli
            // 
            this.BtnDoktorPaneli.Location = new System.Drawing.Point(17, 49);
            this.BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            this.BtnDoktorPaneli.Size = new System.Drawing.Size(131, 42);
            this.BtnDoktorPaneli.TabIndex = 0;
            this.BtnDoktorPaneli.Text = "Doktor Paneli";
            this.BtnDoktorPaneli.UseVisualStyleBackColor = true;
            this.BtnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.Location = new System.Drawing.Point(431, 49);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(115, 42);
            this.BtnDuyurular.TabIndex = 3;
            this.BtnDuyurular.Text = "Duyurular";
            this.BtnDuyurular.UseVisualStyleBackColor = true;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // FrmSekreterSayfasi
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gBoxDoktorlar);
            this.Controls.Add(this.gBoxBranslar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterSayfasi";
            this.Text = "Sekreter Sayfası";
            this.Load += new System.EventHandler(this.FrmSekreterSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gBoxDoktorlar.ResumeLayout(false);
            this.gBoxBranslar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gBoxDoktorlar;
        private System.Windows.Forms.GroupBox gBoxBranslar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Label LbAdSoyad;
        private System.Windows.Forms.Label LbTc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox CbxDoktor;
        private System.Windows.Forms.ComboBox CbxBrans;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.CheckBox ChxDurum;
        private System.Windows.Forms.MaskedTextBox MTxtTc;
        private System.Windows.Forms.MaskedTextBox MTxtSaat;
        private System.Windows.Forms.MaskedTextBox MTxtTarih;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnRandevuListe;
        private System.Windows.Forms.Button BtnBransPaneli;
        private System.Windows.Forms.Button BtnDoktorPaneli;
        private System.Windows.Forms.Button BtnDuyurular;
    }
}