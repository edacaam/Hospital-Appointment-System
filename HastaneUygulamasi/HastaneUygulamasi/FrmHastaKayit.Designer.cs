namespace HastaneUygulamasi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.LbSifre = new System.Windows.Forms.Label();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.LbTc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbSifre
            // 
            this.LbSifre.AutoSize = true;
            this.LbSifre.Location = new System.Drawing.Point(66, 217);
            this.LbSifre.Name = "LbSifre";
            this.LbSifre.Size = new System.Drawing.Size(50, 23);
            this.LbSifre.TabIndex = 12;
            this.LbSifre.Text = "Şifre:";
            // 
            // BtnKayit
            // 
            this.BtnKayit.BackColor = System.Drawing.Color.Thistle;
            this.BtnKayit.Location = new System.Drawing.Point(99, 264);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(124, 33);
            this.BtnKayit.TabIndex = 11;
            this.BtnKayit.Text = "Kayıt Yap";
            this.BtnKayit.UseVisualStyleBackColor = false;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(122, 30);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(124, 30);
            this.TxtAd.TabIndex = 1;
            // 
            // MTxtTc
            // 
            this.MTxtTc.Location = new System.Drawing.Point(122, 105);
            this.MTxtTc.Mask = "00000000000";
            this.MTxtTc.Name = "MTxtTc";
            this.MTxtTc.Size = new System.Drawing.Size(124, 30);
            this.MTxtTc.TabIndex = 3;
            this.MTxtTc.ValidatingType = typeof(int);
            // 
            // LbTc
            // 
            this.LbTc.AutoSize = true;
            this.LbTc.Location = new System.Drawing.Point(-1, 108);
            this.LbTc.Name = "LbTc";
            this.LbTc.Size = new System.Drawing.Size(117, 23);
            this.LbTc.TabIndex = 7;
            this.LbTc.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefon:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(122, 66);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(124, 30);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Soyad:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(122, 214);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(124, 30);
            this.TxtSifre.TabIndex = 6;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MTxtTelefon
            // 
            this.MTxtTelefon.Location = new System.Drawing.Point(122, 141);
            this.MTxtTelefon.Mask = "(999) 000-0000";
            this.MTxtTelefon.Name = "MTxtTelefon";
            this.MTxtTelefon.Size = new System.Drawing.Size(124, 30);
            this.MTxtTelefon.TabIndex = 4;
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CbCinsiyet.Location = new System.Drawing.Point(122, 177);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.Size = new System.Drawing.Size(124, 31);
            this.CbCinsiyet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cinsiyet:";
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(301, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbCinsiyet);
            this.Controls.Add(this.MTxtTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbSifre);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MTxtTc);
            this.Controls.Add(this.LbTc);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbSifre;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MTxtTc;
        private System.Windows.Forms.Label LbTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MTxtTelefon;
        private System.Windows.Forms.ComboBox CbCinsiyet;
        private System.Windows.Forms.Label label4;
    }
}