namespace Bil102_Grup1_FinalProject
{
    partial class OdemeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdemeIslemleri));
            this.btn_geriOdeme = new System.Windows.Forms.Button();
            this.lbl_aranan = new System.Windows.Forms.Label();
            this.lbl_hastaTC = new System.Windows.Forms.Label();
            this.lbl_teshis = new System.Windows.Forms.Label();
            this.lbl_odemeDurumu = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.lbl_ucret = new System.Windows.Forms.Label();
            this.lbl_tcDB = new System.Windows.Forms.Label();
            this.lbl_teshisDB = new System.Windows.Forms.Label();
            this.lbl_sonucDB = new System.Windows.Forms.Label();
            this.lbl_ucretDB = new System.Windows.Forms.Label();
            this.txt_aranacakTC = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.combo_odemeDurumu = new System.Windows.Forms.ComboBox();
            this.btn_islemTamamla = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_geriOdeme
            // 
            this.btn_geriOdeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_geriOdeme.Location = new System.Drawing.Point(520, 307);
            this.btn_geriOdeme.Name = "btn_geriOdeme";
            this.btn_geriOdeme.Size = new System.Drawing.Size(118, 58);
            this.btn_geriOdeme.TabIndex = 6;
            this.btn_geriOdeme.Text = "Geri Dön";
            this.btn_geriOdeme.UseVisualStyleBackColor = true;
            this.btn_geriOdeme.Click += new System.EventHandler(this.AnaEkranaDon);
            // 
            // lbl_aranan
            // 
            this.lbl_aranan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_aranan.AutoSize = true;
            this.lbl_aranan.Location = new System.Drawing.Point(166, 49);
            this.lbl_aranan.Name = "lbl_aranan";
            this.lbl_aranan.Size = new System.Drawing.Size(107, 13);
            this.lbl_aranan.TabIndex = 2;
            this.lbl_aranan.Text = "Aranacak Hasta TC: ";
            // 
            // lbl_hastaTC
            // 
            this.lbl_hastaTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hastaTC.AutoSize = true;
            this.lbl_hastaTC.Location = new System.Drawing.Point(94, 117);
            this.lbl_hastaTC.Name = "lbl_hastaTC";
            this.lbl_hastaTC.Size = new System.Drawing.Size(61, 13);
            this.lbl_hastaTC.TabIndex = 3;
            this.lbl_hastaTC.Text = "Hasta TC : ";
            // 
            // lbl_teshis
            // 
            this.lbl_teshis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_teshis.AutoSize = true;
            this.lbl_teshis.Location = new System.Drawing.Point(94, 163);
            this.lbl_teshis.Name = "lbl_teshis";
            this.lbl_teshis.Size = new System.Drawing.Size(47, 13);
            this.lbl_teshis.TabIndex = 4;
            this.lbl_teshis.Text = "Teşhis : ";
            // 
            // lbl_odemeDurumu
            // 
            this.lbl_odemeDurumu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_odemeDurumu.AutoSize = true;
            this.lbl_odemeDurumu.Location = new System.Drawing.Point(98, 255);
            this.lbl_odemeDurumu.Name = "lbl_odemeDurumu";
            this.lbl_odemeDurumu.Size = new System.Drawing.Size(87, 13);
            this.lbl_odemeDurumu.TabIndex = 6;
            this.lbl_odemeDurumu.Text = "Ödeme Durumu: ";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(388, 117);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(44, 13);
            this.lbl_sonuc.TabIndex = 7;
            this.lbl_sonuc.Text = "Sonuç :";
            // 
            // lbl_ucret
            // 
            this.lbl_ucret.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ucret.AutoSize = true;
            this.lbl_ucret.Location = new System.Drawing.Point(388, 163);
            this.lbl_ucret.Name = "lbl_ucret";
            this.lbl_ucret.Size = new System.Drawing.Size(44, 13);
            this.lbl_ucret.TabIndex = 8;
            this.lbl_ucret.Text = "Ücreti : ";
            // 
            // lbl_tcDB
            // 
            this.lbl_tcDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tcDB.AutoSize = true;
            this.lbl_tcDB.Location = new System.Drawing.Point(169, 117);
            this.lbl_tcDB.Name = "lbl_tcDB";
            this.lbl_tcDB.Size = new System.Drawing.Size(0, 13);
            this.lbl_tcDB.TabIndex = 9;
            // 
            // lbl_teshisDB
            // 
            this.lbl_teshisDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_teshisDB.AutoSize = true;
            this.lbl_teshisDB.Location = new System.Drawing.Point(166, 163);
            this.lbl_teshisDB.Name = "lbl_teshisDB";
            this.lbl_teshisDB.Size = new System.Drawing.Size(0, 13);
            this.lbl_teshisDB.TabIndex = 10;
            // 
            // lbl_sonucDB
            // 
            this.lbl_sonucDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sonucDB.AutoSize = true;
            this.lbl_sonucDB.Location = new System.Drawing.Point(465, 117);
            this.lbl_sonucDB.Name = "lbl_sonucDB";
            this.lbl_sonucDB.Size = new System.Drawing.Size(0, 13);
            this.lbl_sonucDB.TabIndex = 11;
            // 
            // lbl_ucretDB
            // 
            this.lbl_ucretDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ucretDB.AutoSize = true;
            this.lbl_ucretDB.Location = new System.Drawing.Point(465, 163);
            this.lbl_ucretDB.Name = "lbl_ucretDB";
            this.lbl_ucretDB.Size = new System.Drawing.Size(0, 13);
            this.lbl_ucretDB.TabIndex = 12;
            // 
            // txt_aranacakTC
            // 
            this.txt_aranacakTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_aranacakTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aranacakTC.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_aranacakTC.Location = new System.Drawing.Point(279, 46);
            this.txt_aranacakTC.MaxLength = 11;
            this.txt_aranacakTC.Name = "txt_aranacakTC";
            this.txt_aranacakTC.Size = new System.Drawing.Size(100, 20);
            this.txt_aranacakTC.TabIndex = 1;
            this.txt_aranacakTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCKimlikNoAra);
            // 
            // btn_ara
            // 
            this.btn_ara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ara.Location = new System.Drawing.Point(410, 46);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.AraButonTik);
            // 
            // combo_odemeDurumu
            // 
            this.combo_odemeDurumu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combo_odemeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_odemeDurumu.FormattingEnabled = true;
            this.combo_odemeDurumu.Items.AddRange(new object[] {
            "Bekliyor",
            "Ödendi",
            "Ödenmedi"});
            this.combo_odemeDurumu.Location = new System.Drawing.Point(191, 252);
            this.combo_odemeDurumu.Name = "combo_odemeDurumu";
            this.combo_odemeDurumu.Size = new System.Drawing.Size(121, 21);
            this.combo_odemeDurumu.TabIndex = 4;
            // 
            // btn_islemTamamla
            // 
            this.btn_islemTamamla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_islemTamamla.Location = new System.Drawing.Point(360, 247);
            this.btn_islemTamamla.Name = "btn_islemTamamla";
            this.btn_islemTamamla.Size = new System.Drawing.Size(162, 29);
            this.btn_islemTamamla.TabIndex = 5;
            this.btn_islemTamamla.Text = "İşlemi Tamamla";
            this.btn_islemTamamla.UseVisualStyleBackColor = true;
            this.btn_islemTamamla.Click += new System.EventHandler(this.IslemEkleButonTik);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(491, 46);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_Temizle.TabIndex = 13;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Visible = false;
            this.btn_Temizle.Click += new System.EventHandler(this.TemizleButonTik);
            // 
            // OdemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 392);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_islemTamamla);
            this.Controls.Add(this.combo_odemeDurumu);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.txt_aranacakTC);
            this.Controls.Add(this.lbl_ucretDB);
            this.Controls.Add(this.lbl_sonucDB);
            this.Controls.Add(this.lbl_teshisDB);
            this.Controls.Add(this.lbl_tcDB);
            this.Controls.Add(this.lbl_ucret);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_odemeDurumu);
            this.Controls.Add(this.lbl_teshis);
            this.Controls.Add(this.lbl_hastaTC);
            this.Controls.Add(this.lbl_aranan);
            this.Controls.Add(this.btn_geriOdeme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OdemeIslemleri";
            this.Text = "İstinye Üniversitesi Hasta Takip Sistemi - Ödeme İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CikisYap);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_geriOdeme;
        private System.Windows.Forms.Label lbl_aranan;
        private System.Windows.Forms.Label lbl_hastaTC;
        private System.Windows.Forms.Label lbl_teshis;
        private System.Windows.Forms.Label lbl_odemeDurumu;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label lbl_ucret;
        private System.Windows.Forms.Label lbl_tcDB;
        private System.Windows.Forms.Label lbl_teshisDB;
        private System.Windows.Forms.Label lbl_sonucDB;
        private System.Windows.Forms.Label lbl_ucretDB;
        private System.Windows.Forms.TextBox txt_aranacakTC;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ComboBox combo_odemeDurumu;
        private System.Windows.Forms.Button btn_islemTamamla;
        private System.Windows.Forms.Button btn_Temizle;
    }
}