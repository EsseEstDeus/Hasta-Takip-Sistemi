namespace Bil102_Grup1_FinalProject
{
    partial class HastaIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaIslemleri));
            this.btn_hasta_geri = new System.Windows.Forms.Button();
            this.lbl_TCKimlik = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_DogumTarih = new System.Windows.Forms.Label();
            this.lbl_DogumYeri = new System.Windows.Forms.Label();
            this.lbl_Cinsyet = new System.Windows.Forms.Label();
            this.lbl_MedeniHal = new System.Windows.Forms.Label();
            this.lbl_KanGrubu = new System.Windows.Forms.Label();
            this.lbl_Alerji = new System.Windows.Forms.Label();
            this.lbl_HastaGirisTarih = new System.Windows.Forms.Label();
            this.lbl_HastaCikisTarih = new System.Windows.Forms.Label();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Doktor = new System.Windows.Forms.Label();
            this.lbl_Bolum = new System.Windows.Forms.Label();
            this.btn_HastaEkle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.txt_tcKimlikNo = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_dogumYeri = new System.Windows.Forms.TextBox();
            this.cb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.cb_medeniHal = new System.Windows.Forms.ComboBox();
            this.cb_kanGrubu = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_hastaGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_hastaCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txt_alerji = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.cb_doktor = new System.Windows.Forms.ComboBox();
            this.cb_bolum = new System.Windows.Forms.ComboBox();
            this.dataGridView_HastaBilgileri = new System.Windows.Forms.DataGridView();
            this.btn_Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HastaBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hasta_geri
            // 
            this.btn_hasta_geri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_hasta_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hasta_geri.Location = new System.Drawing.Point(690, 108);
            this.btn_hasta_geri.Name = "btn_hasta_geri";
            this.btn_hasta_geri.Size = new System.Drawing.Size(108, 45);
            this.btn_hasta_geri.TabIndex = 21;
            this.btn_hasta_geri.Text = "Geri Dön";
            this.btn_hasta_geri.UseVisualStyleBackColor = true;
            this.btn_hasta_geri.Click += new System.EventHandler(this.AnaEkranaDon);
            // 
            // lbl_TCKimlik
            // 
            this.lbl_TCKimlik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TCKimlik.AutoSize = true;
            this.lbl_TCKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TCKimlik.Location = new System.Drawing.Point(49, 32);
            this.lbl_TCKimlik.Name = "lbl_TCKimlik";
            this.lbl_TCKimlik.Size = new System.Drawing.Size(80, 13);
            this.lbl_TCKimlik.TabIndex = 1;
            this.lbl_TCKimlik.Text = "T.C. Kimlik No :";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Location = new System.Drawing.Point(49, 61);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(28, 13);
            this.lbl_Ad.TabIndex = 2;
            this.lbl_Ad.Text = "Adı :";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Location = new System.Drawing.Point(49, 89);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(45, 13);
            this.lbl_Soyad.TabIndex = 3;
            this.lbl_Soyad.Text = "Soyadı :";
            // 
            // lbl_DogumTarih
            // 
            this.lbl_DogumTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DogumTarih.AutoSize = true;
            this.lbl_DogumTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DogumTarih.Location = new System.Drawing.Point(49, 118);
            this.lbl_DogumTarih.Name = "lbl_DogumTarih";
            this.lbl_DogumTarih.Size = new System.Drawing.Size(76, 13);
            this.lbl_DogumTarih.TabIndex = 4;
            this.lbl_DogumTarih.Text = "Doğum Tarihi :";
            // 
            // lbl_DogumYeri
            // 
            this.lbl_DogumYeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DogumYeri.AutoSize = true;
            this.lbl_DogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DogumYeri.Location = new System.Drawing.Point(49, 147);
            this.lbl_DogumYeri.Name = "lbl_DogumYeri";
            this.lbl_DogumYeri.Size = new System.Drawing.Size(68, 13);
            this.lbl_DogumYeri.TabIndex = 5;
            this.lbl_DogumYeri.Text = "Doğum Yeri :";
            // 
            // lbl_Cinsyet
            // 
            this.lbl_Cinsyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Cinsyet.AutoSize = true;
            this.lbl_Cinsyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cinsyet.Location = new System.Drawing.Point(49, 178);
            this.lbl_Cinsyet.Name = "lbl_Cinsyet";
            this.lbl_Cinsyet.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cinsyet.TabIndex = 6;
            this.lbl_Cinsyet.Text = "Cinsiyet :";
            // 
            // lbl_MedeniHal
            // 
            this.lbl_MedeniHal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_MedeniHal.AutoSize = true;
            this.lbl_MedeniHal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_MedeniHal.Location = new System.Drawing.Point(49, 209);
            this.lbl_MedeniHal.Name = "lbl_MedeniHal";
            this.lbl_MedeniHal.Size = new System.Drawing.Size(69, 13);
            this.lbl_MedeniHal.TabIndex = 7;
            this.lbl_MedeniHal.Text = "Medeni Hali :";
            // 
            // lbl_KanGrubu
            // 
            this.lbl_KanGrubu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KanGrubu.AutoSize = true;
            this.lbl_KanGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KanGrubu.Location = new System.Drawing.Point(49, 242);
            this.lbl_KanGrubu.Name = "lbl_KanGrubu";
            this.lbl_KanGrubu.Size = new System.Drawing.Size(64, 13);
            this.lbl_KanGrubu.TabIndex = 8;
            this.lbl_KanGrubu.Text = "Kan Grubu :";
            // 
            // lbl_Alerji
            // 
            this.lbl_Alerji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Alerji.AutoSize = true;
            this.lbl_Alerji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Alerji.Location = new System.Drawing.Point(356, 32);
            this.lbl_Alerji.Name = "lbl_Alerji";
            this.lbl_Alerji.Size = new System.Drawing.Size(35, 13);
            this.lbl_Alerji.TabIndex = 9;
            this.lbl_Alerji.Text = "Alerji :";
            // 
            // lbl_HastaGirisTarih
            // 
            this.lbl_HastaGirisTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_HastaGirisTarih.AutoSize = true;
            this.lbl_HastaGirisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HastaGirisTarih.Location = new System.Drawing.Point(356, 61);
            this.lbl_HastaGirisTarih.Name = "lbl_HastaGirisTarih";
            this.lbl_HastaGirisTarih.Size = new System.Drawing.Size(93, 13);
            this.lbl_HastaGirisTarih.TabIndex = 10;
            this.lbl_HastaGirisTarih.Text = "Hasta Giriş Tarihi :";
            // 
            // lbl_HastaCikisTarih
            // 
            this.lbl_HastaCikisTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_HastaCikisTarih.AutoSize = true;
            this.lbl_HastaCikisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HastaCikisTarih.Location = new System.Drawing.Point(356, 89);
            this.lbl_HastaCikisTarih.Name = "lbl_HastaCikisTarih";
            this.lbl_HastaCikisTarih.Size = new System.Drawing.Size(95, 13);
            this.lbl_HastaCikisTarih.TabIndex = 11;
            this.lbl_HastaCikisTarih.Text = "Hasta Çıkış Tarihi :";
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adres.Location = new System.Drawing.Point(356, 118);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(40, 13);
            this.lbl_Adres.TabIndex = 12;
            this.lbl_Adres.Text = "Adres :";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Telefon.Location = new System.Drawing.Point(356, 147);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefon.TabIndex = 13;
            this.lbl_Telefon.Text = "Telefon :";
            // 
            // lbl_Doktor
            // 
            this.lbl_Doktor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Doktor.AutoSize = true;
            this.lbl_Doktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Doktor.Location = new System.Drawing.Point(356, 209);
            this.lbl_Doktor.Name = "lbl_Doktor";
            this.lbl_Doktor.Size = new System.Drawing.Size(45, 13);
            this.lbl_Doktor.TabIndex = 14;
            this.lbl_Doktor.Text = "Doktor :";
            // 
            // lbl_Bolum
            // 
            this.lbl_Bolum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bolum.AutoSize = true;
            this.lbl_Bolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Bolum.Location = new System.Drawing.Point(356, 178);
            this.lbl_Bolum.Name = "lbl_Bolum";
            this.lbl_Bolum.Size = new System.Drawing.Size(42, 13);
            this.lbl_Bolum.TabIndex = 15;
            this.lbl_Bolum.Text = "Bölüm :";
            // 
            // btn_HastaEkle
            // 
            this.btn_HastaEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_HastaEkle.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_HastaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HastaEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_HastaEkle.Location = new System.Drawing.Point(46, 289);
            this.btn_HastaEkle.Name = "btn_HastaEkle";
            this.btn_HastaEkle.Size = new System.Drawing.Size(93, 34);
            this.btn_HastaEkle.TabIndex = 16;
            this.btn_HastaEkle.Text = "Hasta Ekle";
            this.btn_HastaEkle.UseVisualStyleBackColor = false;
            this.btn_HastaEkle.Click += new System.EventHandler(this.HastaEkleButonTik);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Listele.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Listele.Location = new System.Drawing.Point(202, 289);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(85, 34);
            this.btn_Listele.TabIndex = 17;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.ListeleButonTik);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guncelle.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Guncelle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Guncelle.Location = new System.Drawing.Point(359, 289);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(84, 34);
            this.btn_Guncelle.TabIndex = 18;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.GuncelleButonTik);
            // 
            // btn_Ara
            // 
            this.btn_Ara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Ara.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ara.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ara.Location = new System.Drawing.Point(530, 289);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(81, 34);
            this.btn_Ara.TabIndex = 19;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = false;
            this.btn_Ara.Click += new System.EventHandler(this.AraButonTik);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sil.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sil.Location = new System.Drawing.Point(690, 289);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(85, 34);
            this.btn_Sil.TabIndex = 20;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.SilButonTik);
            // 
            // txt_tcKimlikNo
            // 
            this.txt_tcKimlikNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tcKimlikNo.Location = new System.Drawing.Point(177, 30);
            this.txt_tcKimlikNo.MaxLength = 11;
            this.txt_tcKimlikNo.Name = "txt_tcKimlikNo";
            this.txt_tcKimlikNo.Size = new System.Drawing.Size(100, 20);
            this.txt_tcKimlikNo.TabIndex = 1;
            this.txt_tcKimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCKimlikGiris);
            // 
            // txt_adi
            // 
            this.txt_adi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_adi.Enabled = false;
            this.txt_adi.Location = new System.Drawing.Point(177, 59);
            this.txt_adi.MaxLength = 50;
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 20);
            this.txt_adi.TabIndex = 2;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_soyadi.Enabled = false;
            this.txt_soyadi.Location = new System.Drawing.Point(177, 87);
            this.txt_soyadi.MaxLength = 50;
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(100, 20);
            this.txt_soyadi.TabIndex = 3;
            // 
            // dateTimePicker_dogumTarihi
            // 
            this.dateTimePicker_dogumTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_dogumTarihi.Enabled = false;
            this.dateTimePicker_dogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dogumTarihi.Location = new System.Drawing.Point(177, 113);
            this.dateTimePicker_dogumTarihi.Name = "dateTimePicker_dogumTarihi";
            this.dateTimePicker_dogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_dogumTarihi.TabIndex = 4;
            this.dateTimePicker_dogumTarihi.Value = new System.DateTime(2024, 5, 30, 21, 40, 58, 0);
            // 
            // txt_dogumYeri
            // 
            this.txt_dogumYeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dogumYeri.Enabled = false;
            this.txt_dogumYeri.Location = new System.Drawing.Point(177, 145);
            this.txt_dogumYeri.MaxLength = 50;
            this.txt_dogumYeri.Name = "txt_dogumYeri";
            this.txt_dogumYeri.Size = new System.Drawing.Size(100, 20);
            this.txt_dogumYeri.TabIndex = 5;
            // 
            // cb_cinsiyet
            // 
            this.cb_cinsiyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_cinsiyet.Enabled = false;
            this.cb_cinsiyet.FormattingEnabled = true;
            this.cb_cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cb_cinsiyet.Location = new System.Drawing.Point(177, 172);
            this.cb_cinsiyet.Name = "cb_cinsiyet";
            this.cb_cinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cb_cinsiyet.TabIndex = 6;
            // 
            // cb_medeniHal
            // 
            this.cb_medeniHal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_medeniHal.Enabled = false;
            this.cb_medeniHal.FormattingEnabled = true;
            this.cb_medeniHal.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cb_medeniHal.Location = new System.Drawing.Point(177, 203);
            this.cb_medeniHal.Name = "cb_medeniHal";
            this.cb_medeniHal.Size = new System.Drawing.Size(100, 21);
            this.cb_medeniHal.TabIndex = 7;
            // 
            // cb_kanGrubu
            // 
            this.cb_kanGrubu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_kanGrubu.Enabled = false;
            this.cb_kanGrubu.FormattingEnabled = true;
            this.cb_kanGrubu.Items.AddRange(new object[] {
            "0 Rh+",
            "0 Rh-",
            "A Rh+",
            "A Rh-",
            "AB Rh+",
            "AB Rh-",
            "B Rh+",
            "B Rh-"});
            this.cb_kanGrubu.Location = new System.Drawing.Point(177, 236);
            this.cb_kanGrubu.Name = "cb_kanGrubu";
            this.cb_kanGrubu.Size = new System.Drawing.Size(100, 21);
            this.cb_kanGrubu.TabIndex = 8;
            // 
            // dateTimePicker_hastaGirisTarihi
            // 
            this.dateTimePicker_hastaGirisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_hastaGirisTarihi.Enabled = false;
            this.dateTimePicker_hastaGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_hastaGirisTarihi.Location = new System.Drawing.Point(502, 59);
            this.dateTimePicker_hastaGirisTarihi.Name = "dateTimePicker_hastaGirisTarihi";
            this.dateTimePicker_hastaGirisTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_hastaGirisTarihi.TabIndex = 10;
            this.dateTimePicker_hastaGirisTarihi.Value = new System.DateTime(2024, 5, 30, 21, 40, 47, 0);
            // 
            // dateTimePicker_hastaCikisTarihi
            // 
            this.dateTimePicker_hastaCikisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_hastaCikisTarihi.Enabled = false;
            this.dateTimePicker_hastaCikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_hastaCikisTarihi.Location = new System.Drawing.Point(502, 87);
            this.dateTimePicker_hastaCikisTarihi.Name = "dateTimePicker_hastaCikisTarihi";
            this.dateTimePicker_hastaCikisTarihi.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_hastaCikisTarihi.TabIndex = 11;
            this.dateTimePicker_hastaCikisTarihi.Value = new System.DateTime(2024, 5, 30, 21, 40, 52, 0);
            // 
            // txt_alerji
            // 
            this.txt_alerji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_alerji.Enabled = false;
            this.txt_alerji.Location = new System.Drawing.Point(502, 30);
            this.txt_alerji.MaxLength = 50;
            this.txt_alerji.Name = "txt_alerji";
            this.txt_alerji.Size = new System.Drawing.Size(100, 20);
            this.txt_alerji.TabIndex = 9;
            // 
            // txt_adres
            // 
            this.txt_adres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_adres.Enabled = false;
            this.txt_adres.Location = new System.Drawing.Point(502, 113);
            this.txt_adres.MaxLength = 150;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(100, 20);
            this.txt_adres.TabIndex = 12;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefon.Enabled = false;
            this.txt_telefon.Location = new System.Drawing.Point(502, 142);
            this.txt_telefon.MaxLength = 11;
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_telefon.TabIndex = 13;
            this.txt_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonGiris);
            // 
            // cb_doktor
            // 
            this.cb_doktor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_doktor.Enabled = false;
            this.cb_doktor.FormattingEnabled = true;
            this.cb_doktor.Location = new System.Drawing.Point(502, 203);
            this.cb_doktor.Name = "cb_doktor";
            this.cb_doktor.Size = new System.Drawing.Size(100, 21);
            this.cb_doktor.TabIndex = 15;
            // 
            // cb_bolum
            // 
            this.cb_bolum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_bolum.Enabled = false;
            this.cb_bolum.FormattingEnabled = true;
            this.cb_bolum.Location = new System.Drawing.Point(501, 172);
            this.cb_bolum.Name = "cb_bolum";
            this.cb_bolum.Size = new System.Drawing.Size(100, 21);
            this.cb_bolum.TabIndex = 14;
            this.cb_bolum.SelectedIndexChanged += new System.EventHandler(this.cb_bolum_SelectedIndexChanged);
            // 
            // dataGridView_HastaBilgileri
            // 
            this.dataGridView_HastaBilgileri.AllowUserToAddRows = false;
            this.dataGridView_HastaBilgileri.AllowUserToDeleteRows = false;
            this.dataGridView_HastaBilgileri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_HastaBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HastaBilgileri.Location = new System.Drawing.Point(12, 338);
            this.dataGridView_HastaBilgileri.Name = "dataGridView_HastaBilgileri";
            this.dataGridView_HastaBilgileri.ReadOnly = true;
            this.dataGridView_HastaBilgileri.RowHeadersWidth = 51;
            this.dataGridView_HastaBilgileri.Size = new System.Drawing.Size(798, 150);
            this.dataGridView_HastaBilgileri.TabIndex = 22;
            this.dataGridView_HastaBilgileri.TabStop = false;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(281, 30);
            this.btn_Temizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(56, 19);
            this.btn_Temizle.TabIndex = 23;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Visible = false;
            this.btn_Temizle.Click += new System.EventHandler(this.TemizleButonTik);
            // 
            // HastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(822, 502);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.dataGridView_HastaBilgileri);
            this.Controls.Add(this.cb_bolum);
            this.Controls.Add(this.cb_doktor);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_alerji);
            this.Controls.Add(this.dateTimePicker_hastaCikisTarihi);
            this.Controls.Add(this.dateTimePicker_hastaGirisTarihi);
            this.Controls.Add(this.cb_kanGrubu);
            this.Controls.Add(this.cb_medeniHal);
            this.Controls.Add(this.cb_cinsiyet);
            this.Controls.Add(this.txt_dogumYeri);
            this.Controls.Add(this.dateTimePicker_dogumTarihi);
            this.Controls.Add(this.txt_soyadi);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.txt_tcKimlikNo);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_HastaEkle);
            this.Controls.Add(this.lbl_Bolum);
            this.Controls.Add(this.lbl_Doktor);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.lbl_HastaCikisTarih);
            this.Controls.Add(this.lbl_HastaGirisTarih);
            this.Controls.Add(this.lbl_Alerji);
            this.Controls.Add(this.lbl_KanGrubu);
            this.Controls.Add(this.lbl_MedeniHal);
            this.Controls.Add(this.lbl_Cinsyet);
            this.Controls.Add(this.lbl_DogumYeri);
            this.Controls.Add(this.lbl_DogumTarih);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.lbl_TCKimlik);
            this.Controls.Add(this.btn_hasta_geri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaIslemleri";
            this.Text = "İstinye Üniversitesi Hasta Takip Sistemi - Hasta İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CikisYap);
            this.Load += new System.EventHandler(this.HastaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HastaBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hasta_geri;
        private System.Windows.Forms.Label lbl_TCKimlik;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_DogumTarih;
        private System.Windows.Forms.Label lbl_DogumYeri;
        private System.Windows.Forms.Label lbl_Cinsyet;
        private System.Windows.Forms.Label lbl_MedeniHal;
        private System.Windows.Forms.Label lbl_KanGrubu;
        private System.Windows.Forms.Label lbl_Alerji;
        private System.Windows.Forms.Label lbl_HastaGirisTarih;
        private System.Windows.Forms.Label lbl_HastaCikisTarih;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Doktor;
        private System.Windows.Forms.Label lbl_Bolum;
        private System.Windows.Forms.Button btn_HastaEkle;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.TextBox txt_tcKimlikNo;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dogumTarihi;
        private System.Windows.Forms.TextBox txt_dogumYeri;
        private System.Windows.Forms.ComboBox cb_cinsiyet;
        private System.Windows.Forms.ComboBox cb_medeniHal;
        private System.Windows.Forms.ComboBox cb_kanGrubu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hastaCikisTarihi;
        private System.Windows.Forms.TextBox txt_alerji;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.ComboBox cb_doktor;
        private System.Windows.Forms.ComboBox cb_bolum;
        private System.Windows.Forms.DateTimePicker dateTimePicker_hastaGirisTarihi;
        private System.Windows.Forms.DataGridView dataGridView_HastaBilgileri;
        private System.Windows.Forms.Button btn_Temizle;
    }
}