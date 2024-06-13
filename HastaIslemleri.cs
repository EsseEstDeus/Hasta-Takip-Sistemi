using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil102_Grup1_FinalProject
{
    public partial class HastaIslemleri : Form
    {
        // BaglantiBilgileri değişkeni burada tanımlandı.Kendi bilgisayarımda kullanmak için kapattım sen kendi bilgisayarında benimkini yorum satırına çevir.
        //private static readonly string BaglantiBilgileri = @"Data Source=ORTAK\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True";
        private static readonly string BaglantiBilgileri = @"Data Source=DC;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True";
        public HastaIslemleri()
        {
            InitializeComponent();

            dateTimePicker_dogumTarihi.Value = DateTime.Today;
            dateTimePicker_hastaGirisTarihi.Value = DateTime.Today;
            dateTimePicker_hastaCikisTarihi.Value = DateTime.Today;

            txt_adi.KeyPress += SadeceHarf;
            txt_soyadi.KeyPress += SadeceHarf;
            txt_dogumYeri.KeyPress += SadeceHarf;
            txt_alerji.KeyPress += SadeceHarf;
            txt_adres.KeyPress += SadeceHarf;
            //cb'lerin içine klavyeden veri girilmesini engelliyor
            cb_cinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_medeniHal.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_kanGrubu.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_bolum.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_doktor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool AramaYapildiMi=false;
        private bool IlkArama = true;
        private bool HastaBulundu = false;

        private string eskiAd;
        private string eskiSoyad;
        private DateTime eskiDogumTarihi;
        private string eskiDogumYeri;
        private string eskiCinsiyet;
        private string eskiMedeniHal;
        private string eskiKanGrubu;
        private string eskiAlerji;
        private DateTime eskiHastaGiris;
        private DateTime eskiHastaCikis;
        private string eskiAdres;
        private string eskiTelefon;
        private string eskiBolum;
        private string eskiDoktor;

        private void AnaEkranaDon(object sender, EventArgs e)
        {
            AnaEkran AnaEkranF = Application.OpenForms["AnaEkran"] as AnaEkran;
            AnaEkranF.Show();
            this.Hide();
        }
        private void CikisYap(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult cikis = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cikis != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void SadeceHarf(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (e.g., backspace) and letters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TCKimlikGiris(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TelefonGiris(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void HastaIslemleri_Load(object sender, EventArgs e)
        {
            HastalariListele();
        }
        private void BolumBilgileriniGetir()
        {
            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                try
                {
                    baglanti.Open();
                    // Bölüm Verilerini Yükleme
                    string BolumSorgu = "SELECT * FROM Bolumler WHERE BolumID NOT IN (14, 15)";
                    DataTable datatableBolum = VeritabaniDataTable(BolumSorgu, baglanti);
                    cb_bolum.DataSource = datatableBolum;
                    cb_bolum.DisplayMember = "Bolum Adı";
                    cb_bolum.ValueMember = "BolumID";
                    cb_bolum.Text = "Bölüm Seçiniz.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message, "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private DataTable VeritabaniDataTable(string sorgu, SqlConnection connection)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        private void ListeleButonTik(object sender, EventArgs e)
        {
            HastalariListele();
        }
        private void BolumdeCalisanDoktorBilgileriniGetir(int bolumID)
        {
            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "SELECT PersonelID, Ad + ' ' + Soyad AS AdSoyad FROM KullaniciBilgileri WHERE Bolumu = @BolumID";
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@BolumID", bolumID);
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        cb_doktor.DataSource = dataTable;
                        cb_doktor.DisplayMember = "AdSoyad";
                        cb_doktor.ValueMember = "PersonelID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı bilgileri yüklenirken bir hata oluştu: " + ex.Message, "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cb_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_doktor.Text = "";
            // Seçili BolumID'sini al
            if (cb_bolum.SelectedValue != null && int.TryParse(cb_bolum.SelectedValue.ToString(), out int secilenBolumID))
            {
                // Seçilen bölüme göre kullanıcıları getir ve cb_doktor ComboBox'ına yükle
                BolumdeCalisanDoktorBilgileriniGetir(secilenBolumID);
            }
        }
        private void AraButonTik(object sender, EventArgs e)
        {
            if (txt_tcKimlikNo.Text.Length == 11 && long.TryParse(txt_tcKimlikNo.Text, out _))
            {
                BolumBilgileriniGetir();
                int.TryParse(cb_bolum.SelectedValue.ToString(),out int secilenBolumID);
                BilgiKutucuklariniAktiflestir();

                if (IlkArama == true) 
                {
                    BolumdeCalisanDoktorBilgileriniGetir(secilenBolumID);
                }
                string TCKimlikAraSorgu = "SELECT TCKimlikNo FROM HastaBilgileri WHERE TCKimlikNo = @TCKimlikNo";

                using (SqlConnection Baglanti = new SqlConnection(BaglantiBilgileri))
                {
                    using (SqlCommand kmt = new SqlCommand(TCKimlikAraSorgu, Baglanti))
                    {
                        kmt.Parameters.AddWithValue("@TCKimlikNo", txt_tcKimlikNo.Text);

                        try
                        {
                            btn_Temizle.Visible = true;
                            AramaYapildiMi = true;
                            txt_tcKimlikNo.ReadOnly = true;
                            Baglanti.Open();
                            SqlDataReader reader = kmt.ExecuteReader();

                            if (reader.HasRows)
                            {
                                if (IlkArama)
                                {
                                    IlkArama = false;
                                }
                                HastaBilgileriniGetir(txt_tcKimlikNo.Text);
                                reader.Close(); // Okuyucuyu kapatıyoruz, çünkü aynı bağlantıda başka bir komut çalıştıracağız
                                HastaBulundu = true;
                            }
                            else
                            {
                                HastaBulundu = false;
                                MessageBox.Show("Kayıt Bulunamadı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("TC kimlik no eksik veya geçersiz girildi!", "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void HastaBilgileriniGetir(string tcKimlikNo)
        {
            string sorgu = "SELECT * FROM HastaBilgileri WHERE TCKimlikNo = @TCKimlikNo";

            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                using (SqlCommand kmt = new SqlCommand(sorgu, baglanti))
                {
                    kmt.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);

                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = kmt.ExecuteReader();

                        if (reader.Read())
                        {
                            txt_adi.Text = reader["Ad"].ToString();
                            txt_soyadi.Text = reader["Soyad"].ToString();
                            dateTimePicker_dogumTarihi.Value = Convert.ToDateTime(reader["Doğum Tarihi"]);
                            txt_dogumYeri.Text = reader["Doğum Yeri"].ToString();
                            cb_cinsiyet.SelectedItem = reader["Cinsiyet"].ToString();
                            cb_medeniHal.SelectedItem = reader["Medeni Hal"].ToString();
                            cb_kanGrubu.SelectedItem = reader["Kan Grubu"].ToString();
                            txt_alerji.Text = reader["Alerji"].ToString();
                            dateTimePicker_hastaGirisTarihi.Value = Convert.ToDateTime(reader["Hasta Giriş"]);
                            dateTimePicker_hastaCikisTarihi.Value = Convert.ToDateTime(reader["Hasta Çıkış"]);
                            txt_adres.Text = reader["Adres"].ToString();
                            txt_telefon.Text = reader["Telefon"].ToString();
                            cb_bolum.SelectedValue = reader["Bolumu"].ToString();
                            cb_doktor.SelectedValue = reader["Doktor"].ToString();

                            // Eski değerleri güncelle
                            eskiAd = reader["Ad"].ToString();
                            eskiSoyad = reader["Soyad"].ToString();
                            eskiDogumTarihi = Convert.ToDateTime(reader["Doğum Tarihi"]);
                            eskiDogumYeri = reader["Doğum Yeri"].ToString();
                            eskiCinsiyet = reader["Cinsiyet"].ToString();
                            eskiMedeniHal = reader["Medeni Hal"].ToString();
                            eskiKanGrubu = reader["Kan Grubu"].ToString();
                            eskiAlerji = reader["Alerji"].ToString();
                            eskiHastaGiris = Convert.ToDateTime(reader["Hasta Giriş"]);
                            eskiHastaCikis = Convert.ToDateTime(reader["Hasta Çıkış"]);
                            eskiAdres = reader["Adres"].ToString();
                            eskiTelefon = reader["Telefon"].ToString();
                            eskiBolum = reader["Bolumu"].ToString();
                            eskiDoktor = reader["Doktor"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Hasta bilgileri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void BilgiKutucuklariniAktiflestir()
        {
            txt_adi.Enabled = true;
            txt_soyadi.Enabled = true;
            txt_adres.Enabled = true;
            txt_alerji.Enabled = true;
            txt_dogumYeri.Enabled = true;
            txt_tcKimlikNo.Enabled = true;
            txt_telefon.Enabled = true;
            cb_bolum.Enabled = true;
            cb_cinsiyet.Enabled = true;
            cb_doktor.Enabled = true;
            cb_kanGrubu.Enabled = true;
            cb_medeniHal.Enabled = true;
            dateTimePicker_dogumTarihi.Enabled = true;
            dateTimePicker_hastaCikisTarihi.Enabled = true;
            dateTimePicker_hastaGirisTarihi.Enabled = true;
        }
        private void HastaEkleButonTik(object sender, EventArgs e)
        {
            if (AramaYapildiMi == false)
            {
                MessageBox.Show("Önce T.C. kimlik no sorgusu yapınız.", "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (HastaBulundu != true)
            {
                if (KayitSartlariSaglandi())
                {
                    DialogResult HastaEkle = MessageBox.Show("Hastayı eklemek istediğinize emin misiniz?", "Hasta İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (HastaEkle == DialogResult.Yes)
                    {
                        string sorgu = @"INSERT INTO HastaBilgileri (TCKimlikNo, Ad, Soyad, [Doğum Tarihi], [Doğum Yeri], Cinsiyet, [Medeni Hal], [Kan Grubu], Alerji, [Hasta Giriş], [Hasta Çıkış], Adres, Telefon, Bolumu, Doktor) 
                                 VALUES (@TCKimlikNo, @Ad, @Soyad, @DogumTarihi, @DogumYeri, @Cinsiyet, @MedeniHali, @KanGrubu, @Alerji, @HastaGirisTarihi, @HastaCikisTarihi, @Adres, @Telefon, @Bolum, @Doktor)";

                        try
                        {
                            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                            {
                                using (SqlCommand kmt = new SqlCommand(sorgu, baglanti))
                                {
                                    kmt.Parameters.AddWithValue("@TCKimlikNo", txt_tcKimlikNo.Text);
                                    kmt.Parameters.AddWithValue("@Ad", txt_adi.Text);
                                    kmt.Parameters.AddWithValue("@Soyad", txt_soyadi.Text);
                                    kmt.Parameters.AddWithValue("@DogumTarihi", dateTimePicker_dogumTarihi.Value.Date); // Sadece tarih kısmını alır
                                    kmt.Parameters.AddWithValue("@DogumYeri", txt_dogumYeri.Text);
                                    kmt.Parameters.AddWithValue("@Cinsiyet", cb_cinsiyet.SelectedItem?.ToString() ?? (object)DBNull.Value);
                                    kmt .Parameters.AddWithValue("@MedeniHali", cb_medeniHal.SelectedItem?.ToString() ?? (object)DBNull.Value);
                                    kmt .Parameters.AddWithValue("@KanGrubu", cb_kanGrubu.SelectedItem?.ToString() ?? (object)DBNull.Value);
                                    kmt.Parameters.AddWithValue("@Alerji", txt_alerji.Text);
                                    kmt.Parameters.AddWithValue("@HastaGirisTarihi", dateTimePicker_hastaGirisTarihi.Value.Date); // Sadece tarih kısmını alır
                                    kmt.Parameters.AddWithValue("@HastaCikisTarihi", dateTimePicker_hastaCikisTarihi.Value.Date); // Sadece tarih kısmını alır
                                    kmt.Parameters.AddWithValue("@Adres", txt_adres.Text);
                                    kmt.Parameters.AddWithValue("@Telefon", txt_telefon.Text);
                                    kmt.Parameters.AddWithValue("@Bolum", cb_bolum.SelectedValue);
                                    kmt.Parameters.AddWithValue("@Doktor", cb_doktor.SelectedValue);
                                    baglanti.Open();
                                    kmt.ExecuteNonQuery();
                                    MessageBox.Show("Hasta başarıyla eklendi.", "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Temizle();
                                    HastalariListele();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hasta Mevcut!","Kullanıcı İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void HastalariListele()
        {
            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                try
                {
                    baglanti.Open();

                    // Listeleme sorgusu
                    string ListeleSorgu = @"SELECT 
                        hb.HastaID,
                        b.[Bolum Adı] as 'Bölüm Adı',
                        kb.Ad + ' ' + kb.Soyad as 'Doktor Adı',
                        hb.TCKimlikNo as 'TC Kimlik No', 
                        hb.Ad as 'Hasta Adı', 
                        hb.Soyad as 'Hasta Soyadı', 
                        hb.[Doğum Tarihi], 
                        hb.[Doğum Yeri], 
                        hb.Cinsiyet, 
                        hb.[Medeni Hal], 
                        hb.[Kan Grubu], 
                        hb.Alerji, 
                        hb.[Hasta Giriş], 
                        hb.[Hasta Çıkış], 
                        hb.Adres, 
                        hb.Telefon
                    FROM 
                        HastaBilgileri hb
                    LEFT JOIN 
                        Bolumler b ON hb.Bolumu = b.BolumID
                    LEFT JOIN 
                        KullaniciBilgileri kb ON hb.Doktor = kb.PersonelID";
                    // Veri adaptörü ve veri tablosu oluşturma
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(ListeleSorgu, baglanti);
                    DataTable dataTable = new DataTable();

                    // Verileri veri tablosuna doldurma
                    dataAdapter.Fill(dataTable);

                    // DataGridView'e veri tablosunu atama
                    dataGridView_HastaBilgileri.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler listelenirken bir hata oluştu: " + ex.Message, "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SilButonTik(object sender, EventArgs e)
        {
            string TcKimlik = txt_tcKimlikNo.Text;
            HastaSil(TcKimlik);
        }
        private void HastaSil(string TcKimlik)
        {
            if (AramaYapildiMi == false)
            {
                MessageBox.Show("Önce TC Kimlik no sorgusu yapınız", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (HastaBulundu)
                {
                    DialogResult KayitSil = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcıyı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (KayitSil == DialogResult.Yes)
                    {
                        string silmeSorgusu = "DELETE FROM HastaBilgileri WHERE TCKimlikNo = @TCKimlikNo";

                        using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                        {
                            using (SqlCommand kmt = new SqlCommand(silmeSorgusu, baglanti))
                            {
                                kmt.Parameters.AddWithValue("@TCKimlikNo", txt_tcKimlikNo.Text);

                                try
                                {
                                    baglanti.Open();
                                    int rowsAffected = kmt.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Kullanıcı silme işlemi tamamlandı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Temizle();
                                        HastalariListele();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Kullanıcı silme işlemi başarısız!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Hata Oluştu: " + ex.Message, "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz Kullanıcı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Temizle()
        {
            HastaBulundu = false;
            AramaYapildiMi = false;
            btn_Temizle.Visible = false;
            txt_tcKimlikNo.ReadOnly = false;
            txt_tcKimlikNo.Text = "";
            txt_adi.Text = "";
            txt_soyadi.Text = "";
            txt_dogumYeri.Text = "";
            txt_alerji.Text = "";
            txt_adres.Text = "";
            txt_telefon.Text = "";
            dateTimePicker_dogumTarihi.Value = DateTime.Now;
            dateTimePicker_hastaGirisTarihi.Value = DateTime.Now;
            dateTimePicker_hastaCikisTarihi.Value = DateTime.Now;
            cb_cinsiyet.DisplayMember = null;
            cb_medeniHal.DisplayMember = null;
            cb_kanGrubu.DisplayMember = null;
        }
        private void GuncelleButonTik(object sender, EventArgs e)
        {
            if(AramaYapildiMi == false)
            {
                MessageBox.Show("Önce TC Kimlik no sorgusu yapınız", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (HastaBulundu == true)
            {
                if (MevcutBilgilerdeDegisiklikVar())
                {
                    DialogResult KayitGuncelle = MessageBox.Show("Hasta bilgilerini güncellemek istediğinize emin misiniz?", "Hasta İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (KayitGuncelle == DialogResult.Yes)
                    {
                        string sorgu = @"UPDATE HastaBilgileri 
                            SET Ad = @Ad, 
                            Soyad = @Soyad, 
                            [Doğum Tarihi] = @DogumTarihi, 
                            [Doğum Yeri] = @DogumYeri, 
                            Cinsiyet = @Cinsiyet, 
                            [Medeni Hal] = @MedeniHali, 
                            [Kan Grubu] = @KanGrubu, 
                            Alerji = @Alerji, 
                            [Hasta Giriş] = @HastaGirisTarihi, 
                            [Hasta Çıkış] = @HastaCikisTarihi, 
                            Adres = @Adres, 
                            Telefon = @Telefon, 
                            Bolumu = @Bolum, 
                            Doktor = @Doktor
                            WHERE TCKimlikNo = @TCKimlikNo";
                        try
                        {
                            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                            {
                                using (SqlCommand kmt = new SqlCommand(sorgu, baglanti))
                                {
                                    kmt.Parameters.AddWithValue("@TCKimlikNo", txt_tcKimlikNo.Text);
                                    kmt.Parameters.AddWithValue("@Ad", txt_adi.Text);
                                    kmt.Parameters.AddWithValue("@Soyad", txt_soyadi.Text);
                                    kmt.Parameters.AddWithValue("@DogumTarihi", dateTimePicker_dogumTarihi.Value.Date); // Sadece tarih kısmını alır
                                    kmt.Parameters.AddWithValue("@DogumYeri", txt_dogumYeri.Text);
                                    kmt.Parameters.AddWithValue("@Cinsiyet", cb_cinsiyet.SelectedItem);
                                    kmt.Parameters.AddWithValue("@MedeniHali", cb_medeniHal.SelectedItem);
                                    kmt.Parameters.AddWithValue("@KanGrubu", cb_kanGrubu.SelectedItem);
                                    kmt.Parameters.AddWithValue("@Alerji", txt_alerji.Text);
                                    kmt.Parameters.AddWithValue("@HastaGirisTarihi", dateTimePicker_hastaGirisTarihi.Value.Date); // Sadece tarih kısmını alır
                                    kmt.Parameters.AddWithValue("@HastaCikisTarihi", dateTimePicker_hastaCikisTarihi.Value.Date); // Sadece tarih kısmını alır
                                    kmt.Parameters.AddWithValue("@Adres", txt_adres.Text);
                                    kmt.Parameters.AddWithValue("@Telefon", txt_telefon.Text);
                                    kmt.Parameters.AddWithValue("@Bolum", cb_bolum.SelectedValue);
                                    kmt.Parameters.AddWithValue("@Doktor", cb_doktor.SelectedValue);
                                    baglanti.Open();
                                    kmt.ExecuteNonQuery();
                                    MessageBox.Show("Hasta başarıyla güncellendi.", "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    HastalariListele();
                                    Temizle();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Hasta bilgilerinde değişklik yok.", "Hasta İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Hasta Bulunamadı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TemizleButonTik(object sender, EventArgs e)
        {
            Temizle();
        }
        private bool KayitSartlariSaglandi()
        {
            List<string> hatalar = new List<string>();

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txt_tcKimlikNo.Text))
            {
                hatalar.Add("TC Kimlik No alanı boş olamaz.");
            }
            if (string.IsNullOrWhiteSpace(txt_adi.Text))
            {
                hatalar.Add("Adı alanı boş olamaz.");
            }
            if (string.IsNullOrWhiteSpace(txt_soyadi.Text))
            {
                hatalar.Add("Soyadı alanı boş olamaz.");
            }
            if (string.IsNullOrWhiteSpace(txt_dogumYeri.Text))
            {
                hatalar.Add("Doğum Yeri alanı boş olamaz.");
            }
            if (string.IsNullOrWhiteSpace(txt_alerji.Text))
            {
                hatalar.Add("Alerji alanı boş olamaz.");
            }
            if (string.IsNullOrWhiteSpace(txt_adres.Text))
            {
                hatalar.Add("Adres alanı boş olamaz.");
            }

            else if (!txt_telefon.Text.StartsWith("0"))
            {
                hatalar.Add("Telefon numarası 0 ile başlamalıdır!");
            }

            if (txt_telefon.TextLength < 11)
            {
                if (string.IsNullOrWhiteSpace(txt_telefon.Text))
                {
                    hatalar.Add("Telefon alanı boş olamaz.");
                }

                else
                {
                    hatalar.Add("Telefon numarasını 11 haneli olacak şekilde giriniz.");
                }
            }

            if (dateTimePicker_dogumTarihi.Value.Date > DateTime.Today.Date)
            {
                hatalar.Add("Doğum tarihi bugünün tarihinden sonra olamaz!");
            }

            if (dateTimePicker_hastaCikisTarihi.Value.Date < dateTimePicker_hastaGirisTarihi.Value.Date)
            {
                hatalar.Add("Hasta Çıkış Tarihi, Hasta Giriş Tarihinden önce olamaz!");
            }

            if (hatalar.Count > 0)
            {
                string hataMesaji = string.Join("\n", hatalar);
                MessageBox.Show(hataMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool MevcutBilgilerdeDegisiklikVar()
        {
            if (
        txt_adi.Text != eskiAd ||
        txt_soyadi.Text != eskiSoyad ||
        dateTimePicker_dogumTarihi.Value.Date != eskiDogumTarihi.Date || // Tarihlerin sadece tarih kısmını karşılaştır
        txt_dogumYeri.Text != eskiDogumYeri ||
        cb_cinsiyet.SelectedItem.ToString() != eskiCinsiyet ||
        cb_medeniHal.SelectedItem.ToString() != eskiMedeniHal ||
        cb_kanGrubu.SelectedItem.ToString() != eskiKanGrubu ||
        txt_alerji.Text != eskiAlerji ||
        dateTimePicker_hastaGirisTarihi.Value.Date != eskiHastaGiris.Date || // Tarihlerin sadece tarih kısmını karşılaştır
        dateTimePicker_hastaCikisTarihi.Value.Date != eskiHastaCikis.Date || // Tarihlerin sadece tarih kısmını karşılaştır
        txt_adres.Text != eskiAdres ||
        txt_telefon.Text != eskiTelefon ||
        cb_bolum.SelectedValue.ToString() != eskiBolum ||
        cb_doktor.SelectedValue.ToString() != eskiDoktor
    )
            {
                return true;
            }
            return false;
        }
    }
}