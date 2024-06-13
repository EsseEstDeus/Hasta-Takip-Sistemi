namespace Bil102_Grup1_FinalProject
{
    partial class KullaniciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciIslemleri));
            this.lbl_yeniKullanici = new System.Windows.Forms.Label();
            this.lbl_islemTCNo = new System.Windows.Forms.Label();
            this.textBox_TCKimlikAra = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView_KullaniciBilgileri = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_TCTemizle = new System.Windows.Forms.Button();
            this.groupBox_KullaniciBilgileri = new System.Windows.Forms.GroupBox();
            this.checkBox_sifreTekrarGoster = new System.Windows.Forms.CheckBox();
            this.checkBox_sifreGoster = new System.Windows.Forms.CheckBox();
            this.comboBox_DoktorBolum = new System.Windows.Forms.ComboBox();
            this.lbl_DoktorBolum = new System.Windows.Forms.Label();
            this.lbl_KullaniciTuru = new System.Windows.Forms.Label();
            this.comboBox_KullaniciTuru = new System.Windows.Forms.ComboBox();
            this.textBox_SifreTekrar = new System.Windows.Forms.TextBox();
            this.lbl_SifreTekrar = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.textBox_soyadi = new System.Windows.Forms.TextBox();
            this.textBox_adi = new System.Windows.Forms.TextBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KullaniciBilgileri)).BeginInit();
            this.groupBox_KullaniciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_yeniKullanici
            // 
            this.lbl_yeniKullanici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_yeniKullanici.AutoSize = true;
            this.lbl_yeniKullanici.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yeniKullanici.Location = new System.Drawing.Point(198, 20);
            this.lbl_yeniKullanici.Name = "lbl_yeniKullanici";
            this.lbl_yeniKullanici.Size = new System.Drawing.Size(138, 15);
            this.lbl_yeniKullanici.TabIndex = 2;
            this.lbl_yeniKullanici.Text = "Yeni Kullanıcı İşlemleri";
            // 
            // lbl_islemTCNo
            // 
            this.lbl_islemTCNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_islemTCNo.AutoSize = true;
            this.lbl_islemTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_islemTCNo.Location = new System.Drawing.Point(38, 65);
            this.lbl_islemTCNo.Name = "lbl_islemTCNo";
            this.lbl_islemTCNo.Size = new System.Drawing.Size(94, 13);
            this.lbl_islemTCNo.TabIndex = 3;
            this.lbl_islemTCNo.Text = "İşlem İçin T.C. No:";
            // 
            // textBox_TCKimlikAra
            // 
            this.textBox_TCKimlikAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TCKimlikAra.Location = new System.Drawing.Point(201, 60);
            this.textBox_TCKimlikAra.MaxLength = 11;
            this.textBox_TCKimlikAra.Name = "textBox_TCKimlikAra";
            this.textBox_TCKimlikAra.Size = new System.Drawing.Size(124, 20);
            this.textBox_TCKimlikAra.TabIndex = 1;
            this.textBox_TCKimlikAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCKimlikKural);
            // 
            // btn_ara
            // 
            this.btn_ara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Location = new System.Drawing.Point(352, 60);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 2;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.AraButonTik);
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(444, 239);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(94, 41);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Kullanıcıyı Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.SilButonTik);
            // 
            // dataGridView_KullaniciBilgileri
            // 
            this.dataGridView_KullaniciBilgileri.AllowUserToAddRows = false;
            this.dataGridView_KullaniciBilgileri.AllowUserToDeleteRows = false;
            this.dataGridView_KullaniciBilgileri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_KullaniciBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KullaniciBilgileri.Location = new System.Drawing.Point(13, 435);
            this.dataGridView_KullaniciBilgileri.Name = "dataGridView_KullaniciBilgileri";
            this.dataGridView_KullaniciBilgileri.ReadOnly = true;
            this.dataGridView_KullaniciBilgileri.RowHeadersWidth = 51;
            this.dataGridView_KullaniciBilgileri.Size = new System.Drawing.Size(550, 182);
            this.dataGridView_KullaniciBilgileri.TabIndex = 17;
            this.dataGridView_KullaniciBilgileri.TabStop = false;
            // 
            // btn_geri
            // 
            this.btn_geri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(420, 362);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(118, 58);
            this.btn_geri.TabIndex = 16;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.GeriDonButonTik);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Ekle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(444, 185);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(94, 43);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Kullanıcıyı Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.EkleButonTik);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.Location = new System.Drawing.Point(444, 128);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(94, 43);
            this.btn_Listele.TabIndex = 13;
            this.btn_Listele.Text = "Kullanıcıları Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.ListeleButonTik);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(444, 292);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(94, 43);
            this.btn_Guncelle.TabIndex = 15;
            this.btn_Guncelle.Text = "Kullanıcıyı Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.GuncelleButonTık);
            // 
            // btn_TCTemizle
            // 
            this.btn_TCTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TCTemizle.Location = new System.Drawing.Point(444, 60);
            this.btn_TCTemizle.Name = "btn_TCTemizle";
            this.btn_TCTemizle.Size = new System.Drawing.Size(75, 24);
            this.btn_TCTemizle.TabIndex = 59;
            this.btn_TCTemizle.Text = "Temizle";
            this.btn_TCTemizle.UseVisualStyleBackColor = true;
            this.btn_TCTemizle.Click += new System.EventHandler(this.TemizleButonTik);
            // 
            // groupBox_KullaniciBilgileri
            // 
            this.groupBox_KullaniciBilgileri.Controls.Add(this.checkBox_sifreTekrarGoster);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.checkBox_sifreGoster);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.comboBox_DoktorBolum);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_DoktorBolum);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_KullaniciTuru);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.comboBox_KullaniciTuru);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.textBox_SifreTekrar);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_SifreTekrar);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.textBox_Sifre);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_Sifre);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.textBox_KullaniciAdi);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_kullaniciAdi);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.textBox_telefon);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.textBox_soyadi);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.textBox_adi);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_Telefon);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_Soyad);
            this.groupBox_KullaniciBilgileri.Controls.Add(this.lbl_Ad);
            this.groupBox_KullaniciBilgileri.Enabled = false;
            this.groupBox_KullaniciBilgileri.Location = new System.Drawing.Point(9, 113);
            this.groupBox_KullaniciBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_KullaniciBilgileri.Name = "groupBox_KullaniciBilgileri";
            this.groupBox_KullaniciBilgileri.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_KullaniciBilgileri.Size = new System.Drawing.Size(313, 307);
            this.groupBox_KullaniciBilgileri.TabIndex = 60;
            this.groupBox_KullaniciBilgileri.TabStop = false;
            // 
            // checkBox_sifreTekrarGoster
            // 
            this.checkBox_sifreTekrarGoster.AutoSize = true;
            this.checkBox_sifreTekrarGoster.Location = new System.Drawing.Point(266, 234);
            this.checkBox_sifreTekrarGoster.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_sifreTekrarGoster.Name = "checkBox_sifreTekrarGoster";
            this.checkBox_sifreTekrarGoster.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sifreTekrarGoster.TabIndex = 76;
            this.checkBox_sifreTekrarGoster.UseVisualStyleBackColor = true;
            this.checkBox_sifreTekrarGoster.CheckedChanged += new System.EventHandler(this.SifreTekrarGoster);
            // 
            // checkBox_sifreGoster
            // 
            this.checkBox_sifreGoster.AutoSize = true;
            this.checkBox_sifreGoster.Location = new System.Drawing.Point(266, 193);
            this.checkBox_sifreGoster.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_sifreGoster.Name = "checkBox_sifreGoster";
            this.checkBox_sifreGoster.Size = new System.Drawing.Size(15, 14);
            this.checkBox_sifreGoster.TabIndex = 75;
            this.checkBox_sifreGoster.UseVisualStyleBackColor = true;
            this.checkBox_sifreGoster.CheckedChanged += new System.EventHandler(this.SifreGoster);
            // 
            // comboBox_DoktorBolum
            // 
            this.comboBox_DoktorBolum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_DoktorBolum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_DoktorBolum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_DoktorBolum.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_DoktorBolum.FormattingEnabled = true;
            this.comboBox_DoktorBolum.Location = new System.Drawing.Point(140, 48);
            this.comboBox_DoktorBolum.Name = "comboBox_DoktorBolum";
            this.comboBox_DoktorBolum.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DoktorBolum.TabIndex = 60;
            this.comboBox_DoktorBolum.Visible = false;
            // 
            // lbl_DoktorBolum
            // 
            this.lbl_DoktorBolum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoktorBolum.AutoSize = true;
            this.lbl_DoktorBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DoktorBolum.Location = new System.Drawing.Point(26, 50);
            this.lbl_DoktorBolum.Name = "lbl_DoktorBolum";
            this.lbl_DoktorBolum.Size = new System.Drawing.Size(48, 13);
            this.lbl_DoktorBolum.TabIndex = 74;
            this.lbl_DoktorBolum.Text = "Bölümü :";
            this.lbl_DoktorBolum.Visible = false;
            // 
            // lbl_KullaniciTuru
            // 
            this.lbl_KullaniciTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KullaniciTuru.AutoSize = true;
            this.lbl_KullaniciTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciTuru.Location = new System.Drawing.Point(26, 22);
            this.lbl_KullaniciTuru.Name = "lbl_KullaniciTuru";
            this.lbl_KullaniciTuru.Size = new System.Drawing.Size(77, 13);
            this.lbl_KullaniciTuru.TabIndex = 73;
            this.lbl_KullaniciTuru.Text = "Kullanıcı Türü :";
            // 
            // comboBox_KullaniciTuru
            // 
            this.comboBox_KullaniciTuru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_KullaniciTuru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_KullaniciTuru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_KullaniciTuru.FormattingEnabled = true;
            this.comboBox_KullaniciTuru.Location = new System.Drawing.Point(140, 22);
            this.comboBox_KullaniciTuru.Name = "comboBox_KullaniciTuru";
            this.comboBox_KullaniciTuru.Size = new System.Drawing.Size(121, 21);
            this.comboBox_KullaniciTuru.TabIndex = 59;
            this.comboBox_KullaniciTuru.SelectedIndexChanged += new System.EventHandler(this.TurComboBoxIndexDegisim);
            // 
            // textBox_SifreTekrar
            // 
            this.textBox_SifreTekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SifreTekrar.Location = new System.Drawing.Point(161, 227);
            this.textBox_SifreTekrar.MaxLength = 50;
            this.textBox_SifreTekrar.Name = "textBox_SifreTekrar";
            this.textBox_SifreTekrar.PasswordChar = '*';
            this.textBox_SifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.textBox_SifreTekrar.TabIndex = 65;
            this.textBox_SifreTekrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTusBasma);
            this.textBox_SifreTekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SifreTextBoxTusBasma);
            // 
            // lbl_SifreTekrar
            // 
            this.lbl_SifreTekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SifreTekrar.AutoSize = true;
            this.lbl_SifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SifreTekrar.Location = new System.Drawing.Point(23, 232);
            this.lbl_SifreTekrar.Name = "lbl_SifreTekrar";
            this.lbl_SifreTekrar.Size = new System.Drawing.Size(68, 13);
            this.lbl_SifreTekrar.TabIndex = 72;
            this.lbl_SifreTekrar.Text = "Şifre Tekrar :";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Sifre.Location = new System.Drawing.Point(161, 193);
            this.textBox_Sifre.MaxLength = 50;
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.PasswordChar = '*';
            this.textBox_Sifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sifre.TabIndex = 64;
            this.textBox_Sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTusBasma);
            this.textBox_Sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SifreTextBoxTusBasma);
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.Location = new System.Drawing.Point(24, 197);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(34, 13);
            this.lbl_Sifre.TabIndex = 71;
            this.lbl_Sifre.Text = "Şifre :";
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(161, 162);
            this.textBox_KullaniciAdi.MaxLength = 50;
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.textBox_KullaniciAdi.TabIndex = 63;
            this.textBox_KullaniciAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTusBasma);
            this.textBox_KullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KullaniciAdiTextBoxTusBasma);
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(24, 167);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lbl_kullaniciAdi.TabIndex = 70;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_telefon.Location = new System.Drawing.Point(161, 264);
            this.textBox_telefon.MaxLength = 11;
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(100, 20);
            this.textBox_telefon.TabIndex = 66;
            this.textBox_telefon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTusBasma);
            this.textBox_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonKayit);
            // 
            // textBox_soyadi
            // 
            this.textBox_soyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_soyadi.Location = new System.Drawing.Point(161, 132);
            this.textBox_soyadi.MaxLength = 50;
            this.textBox_soyadi.Name = "textBox_soyadi";
            this.textBox_soyadi.Size = new System.Drawing.Size(100, 20);
            this.textBox_soyadi.TabIndex = 62;
            // 
            // textBox_adi
            // 
            this.textBox_adi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_adi.Location = new System.Drawing.Point(161, 101);
            this.textBox_adi.MaxLength = 50;
            this.textBox_adi.Name = "textBox_adi";
            this.textBox_adi.Size = new System.Drawing.Size(100, 20);
            this.textBox_adi.TabIndex = 61;
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Telefon.Location = new System.Drawing.Point(24, 269);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefon.TabIndex = 69;
            this.lbl_Telefon.Text = "Telefon :";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(24, 132);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(45, 13);
            this.lbl_Soyad.TabIndex = 68;
            this.lbl_Soyad.Text = "Soyadı :";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Location = new System.Drawing.Point(24, 101);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(28, 13);
            this.lbl_Ad.TabIndex = 67;
            this.lbl_Ad.Text = "Adı :";
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 629);
            this.Controls.Add(this.groupBox_KullaniciBilgileri);
            this.Controls.Add(this.btn_TCTemizle);
            this.Controls.Add(this.dataGridView_KullaniciBilgileri);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.textBox_TCKimlikAra);
            this.Controls.Add(this.lbl_islemTCNo);
            this.Controls.Add(this.lbl_yeniKullanici);
            this.Controls.Add(this.btn_geri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciIslemleri";
            this.Text = "İstinye Üniversitesi Hasta Takip Sistemi - Kullanıcı İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CikisYapSagUst);
            this.Load += new System.EventHandler(this.FormYukleniyor);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KullaniciBilgileri)).EndInit();
            this.groupBox_KullaniciBilgileri.ResumeLayout(false);
            this.groupBox_KullaniciBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_yeniKullanici;
        private System.Windows.Forms.Label lbl_islemTCNo;
        private System.Windows.Forms.TextBox textBox_TCKimlikAra;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView_KullaniciBilgileri;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_TCTemizle;
        private System.Windows.Forms.GroupBox groupBox_KullaniciBilgileri;
        private System.Windows.Forms.CheckBox checkBox_sifreTekrarGoster;
        private System.Windows.Forms.CheckBox checkBox_sifreGoster;
        private System.Windows.Forms.ComboBox comboBox_DoktorBolum;
        private System.Windows.Forms.Label lbl_DoktorBolum;
        private System.Windows.Forms.Label lbl_KullaniciTuru;
        private System.Windows.Forms.ComboBox comboBox_KullaniciTuru;
        private System.Windows.Forms.TextBox textBox_SifreTekrar;
        private System.Windows.Forms.Label lbl_SifreTekrar;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.TextBox textBox_soyadi;
        private System.Windows.Forms.TextBox textBox_adi;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Ad;
    }
}