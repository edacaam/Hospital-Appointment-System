namespace HastaneUygulamasi
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.LbSifre = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.LbTc = new System.Windows.Forms.Label();
            this.LbLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbSifre
            // 
            this.LbSifre.AutoSize = true;
            this.LbSifre.Location = new System.Drawing.Point(86, 166);
            this.LbSifre.Name = "LbSifre";
            this.LbSifre.Size = new System.Drawing.Size(50, 23);
            this.LbSifre.TabIndex = 13;
            this.LbSifre.Text = "Şifre:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(112, 228);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(115, 33);
            this.BtnGiris.TabIndex = 3;
            this.BtnGiris.Text = "Giriş Yap";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(103, 192);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(124, 31);
            this.TxtSifre.TabIndex = 3;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MTxtTc
            // 
            this.MTxtTc.Location = new System.Drawing.Point(103, 133);
            this.MTxtTc.Mask = "00000000000";
            this.MTxtTc.Name = "MTxtTc";
            this.MTxtTc.Size = new System.Drawing.Size(124, 31);
            this.MTxtTc.TabIndex = 1;
            this.MTxtTc.ValidatingType = typeof(int);
            // 
            // LbTc
            // 
            this.LbTc.AutoSize = true;
            this.LbTc.Location = new System.Drawing.Point(86, 107);
            this.LbTc.Name = "LbTc";
            this.LbTc.Size = new System.Drawing.Size(117, 23);
            this.LbTc.TabIndex = 8;
            this.LbTc.Text = "TC Kimlik No:";
            // 
            // LbLogo
            // 
            this.LbLogo.AutoSize = true;
            this.LbLogo.Font = new System.Drawing.Font("Book Antiqua", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogo.Location = new System.Drawing.Point(34, 28);
            this.LbLogo.Name = "LbLogo";
            this.LbLogo.Size = new System.Drawing.Size(257, 32);
            this.LbLogo.TabIndex = 7;
            this.LbLogo.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(303, 390);
            this.Controls.Add(this.LbSifre);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MTxtTc);
            this.Controls.Add(this.LbTc);
            this.Controls.Add(this.LbLogo);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.Text = "Doktor Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MTxtTc;
        private System.Windows.Forms.Label LbTc;
        private System.Windows.Forms.Label LbLogo;
    }
}