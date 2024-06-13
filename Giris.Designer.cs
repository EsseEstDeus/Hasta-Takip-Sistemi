namespace Bil102_Grup1_FinalProject
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.groupBox_GirisBilgileri = new System.Windows.Forms.GroupBox();
            this.checkBox_SifreGoster = new System.Windows.Forms.CheckBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_kullanici = new System.Windows.Forms.TextBox();
            this.groupBox_GirisBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_GirisBilgileri
            // 
            this.groupBox_GirisBilgileri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_GirisBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_GirisBilgileri.Controls.Add(this.checkBox_SifreGoster);
            this.groupBox_GirisBilgileri.Controls.Add(this.pictureBox_logo);
            this.groupBox_GirisBilgileri.Controls.Add(this.btn_cikis);
            this.groupBox_GirisBilgileri.Controls.Add(this.btn_giris);
            this.groupBox_GirisBilgileri.Controls.Add(this.textBox_sifre);
            this.groupBox_GirisBilgileri.Controls.Add(this.textBox_kullanici);
            this.groupBox_GirisBilgileri.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox_GirisBilgileri.Location = new System.Drawing.Point(169, 44);
            this.groupBox_GirisBilgileri.Name = "groupBox_GirisBilgileri";
            this.groupBox_GirisBilgileri.Size = new System.Drawing.Size(366, 324);
            this.groupBox_GirisBilgileri.TabIndex = 8;
            this.groupBox_GirisBilgileri.TabStop = false;
            // 
            // checkBox_SifreGoster
            // 
            this.checkBox_SifreGoster.AutoSize = true;
            this.checkBox_SifreGoster.Location = new System.Drawing.Point(265, 201);
            this.checkBox_SifreGoster.Name = "checkBox_SifreGoster";
            this.checkBox_SifreGoster.Size = new System.Drawing.Size(88, 17);
            this.checkBox_SifreGoster.TabIndex = 3;
            this.checkBox_SifreGoster.Text = "Şifreyi Göster";
            this.checkBox_SifreGoster.UseVisualStyleBackColor = true;
            this.checkBox_SifreGoster.CheckedChanged += new System.EventHandler(this.SifreGoster);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(42, 19);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(272, 96);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 2;
            this.pictureBox_logo.TabStop = false;
            this.pictureBox_logo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoyaSolTik);
            this.pictureBox_logo.MouseLeave += new System.EventHandler(this.LogoUstundenCikinca);
            this.pictureBox_logo.MouseHover += new System.EventHandler(this.LogoUstuneGelince);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(189, 245);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(125, 33);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "ÇIKIŞ YAP";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.CikisYapButon);
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(42, 245);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(125, 33);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ YAP";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.GirisYapButonTik);
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(122, 199);
            this.textBox_sifre.MaxLength = 50;
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.PasswordChar = '*';
            this.textBox_sifre.Size = new System.Drawing.Size(125, 20);
            this.textBox_sifre.TabIndex = 2;
            this.textBox_sifre.Text = "Şifre";
            this.textBox_sifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SifreGoster);
            this.textBox_sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SifreEnter);
            this.textBox_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SifreAlaniGiris);
            // 
            // textBox_kullanici
            // 
            this.textBox_kullanici.Location = new System.Drawing.Point(122, 152);
            this.textBox_kullanici.MaxLength = 50;
            this.textBox_kullanici.Name = "textBox_kullanici";
            this.textBox_kullanici.Size = new System.Drawing.Size(125, 20);
            this.textBox_kullanici.TabIndex = 1;
            this.textBox_kullanici.Text = "Kullanıcı Adı";
            this.textBox_kullanici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciAdiEnter);
            this.textBox_kullanici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KullaniciAlaniGiris);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.groupBox_GirisBilgileri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 39);
            this.Name = "Giris";
            this.Text = "İstinye Üniversitesi Hasta Takip Sistemi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CikisYapSagUst);
            this.groupBox_GirisBilgileri.ResumeLayout(false);
            this.groupBox_GirisBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_GirisBilgileri;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.TextBox textBox_kullanici;
        private System.Windows.Forms.CheckBox checkBox_SifreGoster;
    }
}