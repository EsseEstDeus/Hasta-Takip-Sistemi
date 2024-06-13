using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Bil102_Grup1_FinalProject
{
    public partial class KullaniciIslemleri : Form
    {
        public KullaniciIslemleri()
        {
            InitializeComponent();
            KopyalaYapistirKapat(textBox_TCKimlikAra);
            KopyalaYapistirKapat(textBox_adi);
            KopyalaYapistirKapat(textBox_soyadi);
            KopyalaYapistirKapat(textBox_KullaniciAdi);
            KopyalaYapistirKapat(textBox_Sifre);
            KopyalaYapistirKapat(textBox_SifreTekrar);
            KopyalaYapistirKapat(textBox_telefon);
            comboBox_DoktorBolum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_KullaniciTuru.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private readonly string BaglantiBilgileri = @"Data Source=DC;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True";
        private bool AramaYapildiMi;
        private bool KullaniciVar;
        private string eskiAd;
        private string eskiSoyad;
        private string eskiKullaniciAdi;
        private string eskiSifre;
        private string eskiTelefon;
        private string eskiKullaniciTuru;
        private string eskiBolum;

        private void FormYukleniyor(object sender, EventArgs e)
        {
            DatabasedenVeriYukle();
        }
        private void DatabasedenVeriYukle()
        {
            using (SqlConnection Baglanti = new SqlConnection(BaglantiBilgileri))
            {
                try
                {
                    Baglanti.Open();

                    // Kullanıcı Türü Verilerini Yükleme
                    string TurSorgu = "SELECT * FROM KullaniciTuru WHERE TurID <>4";
                    DataTable datatableTur = VeriTabanindanVeriCek(TurSorgu, Baglanti);
                    comboBox_KullaniciTuru.DataSource = datatableTur;
                    comboBox_KullaniciTuru.DisplayMember = "Kullanici Turu";
                    comboBox_KullaniciTuru.ValueMember = "TurID";

                    // Bölüm Verilerini Yükleme
                    string BolumSorgu = "SELECT * FROM Bolumler";
                    DataTable datatableBolum = VeriTabanindanVeriCek(BolumSorgu, Baglanti);
                    comboBox_DoktorBolum.DataSource = datatableBolum;
                    comboBox_DoktorBolum.DisplayMember = "Bolum Adı";
                    comboBox_DoktorBolum.ValueMember = "BolumID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message,"Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void KopyalaYapistirKapat(TextBox textBox)
        {
            textBox.ContextMenu = new ContextMenu(); // Sağ tıklama menüsünü devre dışı bırak
            textBox.KeyDown += new KeyEventHandler(TextBoxTusBasma);
        }
        private void TextBoxTusBasma(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {
                e.SuppressKeyPress = true; // Ctrl+C ve Ctrl+V kısayollarını engelle
            }
        }
        private void GeriDonButonTik(object sender, EventArgs e)
        {
            AnaEkran AnaEkranF = Application.OpenForms["AnaEkran"] as AnaEkran;
            AnaEkranF.Show();
            this.Hide();
        }
        private void CikisYapSagUst(object sender, FormClosingEventArgs e)
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
        private void TurComboBoxIndexDegisim(object sender, EventArgs e)
        {
            DoktorComboBoxAyarlama();

        }
        private void TelefonKayit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void KullaniciAdiTextBoxTusBasma(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        private void SifreTextBoxTusBasma(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        private DataTable VeriTabanindanVeriCek(string sorgu, SqlConnection connection)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        private void DoktorComboBoxAyarlama()
        {
            using (SqlConnection Baglanti = new SqlConnection(BaglantiBilgileri))

                if (comboBox_KullaniciTuru.SelectedIndex == 1 && AramaYapildiMi == true)
                {
                    string BolumSorgu = "SELECT * FROM Bolumler WHERE BolumID NOT IN (14, 15)";
                    DataTable datatableTur = VeriTabanindanVeriCek(BolumSorgu, Baglanti);
                    comboBox_DoktorBolum.DataSource = datatableTur;

                    comboBox_DoktorBolum.Enabled = true;
                    lbl_DoktorBolum.Visible = true;
                    comboBox_DoktorBolum.Visible = true;
                }

                else
                {
                    string BolumSorgu = "SELECT * FROM Bolumler";
                    DataTable datatableTur = VeriTabanindanVeriCek(BolumSorgu, Baglanti);
                    comboBox_DoktorBolum.DataSource = datatableTur;

                    comboBox_DoktorBolum.Enabled = false;
                    lbl_DoktorBolum.Visible = false;
                    comboBox_DoktorBolum.Visible = false;
                    if (comboBox_KullaniciTuru.SelectedIndex == 0 && AramaYapildiMi == true)
                    {
                        comboBox_DoktorBolum.SelectedIndex = 13;
                    }

                    else if (comboBox_KullaniciTuru.SelectedIndex == 2 && AramaYapildiMi == true)
                    {
                        comboBox_DoktorBolum.SelectedIndex = 14;
                    }
                }

        }
        private void TCKimlikKural(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AraButonTik(object sender, EventArgs e)
        {
            KullaniciVar = false;

            if (textBox_TCKimlikAra.TextLength == 11)
            {
                string TCKimlikAraSorgu = "SELECT TCKimlikNo FROM KullaniciBilgileri WHERE TCKimlikNo = @TCKimlikNo";

                using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                {
                    using (SqlCommand kmt = new SqlCommand(TCKimlikAraSorgu, baglanti))
                    {
                        kmt.Parameters.AddWithValue("@TCKimlikNo", textBox_TCKimlikAra.Text);

                        try
                        {
                            textBox_TCKimlikAra.ReadOnly = true;
                            AramaYapildiMi = true;
                            baglanti.Open();
                            SqlDataReader reader = kmt.ExecuteReader();
                            KullaniciBilgileriEtkinlestir();

                            if (reader.HasRows)
                            {
                                KullaniciVar = true;
                                KullaniciBilgileriniGetir(textBox_TCKimlikAra.Text);
                            }
                            else
                            {
                                MessageBox.Show("Kayıt Bulunamadı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu: " + ex.Message, "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("TC Kimlik numarasını eksik girdiniz!","Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_TCKimlikAra.Text = "";
                textBox_TCKimlikAra.Focus();
            }
        }
        private void ListeleButonTik(object sender, EventArgs e)
        {
            KullaniciListele();
        }
        private void KullaniciListele()
        {
            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                try
                {
                    baglanti.Open();
                    string ListeleSorgu = " SELECT kb.PersonelID, kt.[Kullanici Turu] as 'Kullanıcı Türü', b.[Bolum Adı] as 'Bölüm Adı', KulAdi as 'Kullanıcı Adı',Sifre as 'Şifre',Ad,Soyad,TCKimlikNo as 'TC Kimlik No',Telefon FROM KullaniciBilgileri kb LEFT JOIN Bolumler b ON kb.Bolumu = b.BolumID LEFT JOIN KullaniciTuru kt ON kb.[Kullanici Turu] = kt.TurID where kb.[Kullanici Turu] <>4";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(ListeleSorgu, baglanti);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView_KullaniciBilgileri.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler listelenirken bir hata oluştu: " + ex.Message, "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SilButonTik(object sender, EventArgs e)
        {
            if (AramaYapildiMi == false)
            {
                MessageBox.Show("Önce TC Kimlik no sorgusu yapınız", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (KullaniciVar)
                {
                    DialogResult KayitSil = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcıyı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (KayitSil == DialogResult.Yes)
                    {
                        string silmeSorgusu = "DELETE FROM KullaniciBilgileri WHERE TCKimlikNo = @TCKimlikNo";

                        using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                        {
                            using (SqlCommand kmt = new SqlCommand(silmeSorgusu, baglanti))
                            {
                                kmt.Parameters.AddWithValue("@TCKimlikNo", textBox_TCKimlikAra.Text);

                                try
                                {
                                    baglanti.Open();
                                    int etkilenenSatirlar = kmt.ExecuteNonQuery();
                                    if (etkilenenSatirlar > 0)
                                    {
                                        MessageBox.Show("Kullanıcı silme işlemi tamamlandı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Temizle();
                                        KullaniciListele();
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
        private void EkleButonTik(object sender, EventArgs e)
        {
            if (AramaYapildiMi == false)
            {
                MessageBox.Show("Önce TC Kimlik no sorgusu yapınız", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KullaniciVar)
            {
                MessageBox.Show("Kullanıcı mevcut!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (KayitSartlariSaglandi())
                {
                    DialogResult KayitEkle = MessageBox.Show("Kullanıcıyı kaydetmek istediğinize emin misiniz?", "Kullanıcı İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (KayitEkle == DialogResult.Yes)
                    {
                        if (textBox_Sifre.Text != textBox_SifreTekrar.Text)
                        {
                            MessageBox.Show("Şifreler eşleşmiyor!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string sorgu = @"INSERT INTO KullaniciBilgileri ([Kullanici Turu], TCKimlikNo, Ad, Soyad, KulAdi, Sifre, Telefon, Bolumu) VALUES (@TurID, @TCKimlikNo, @Ad, @Soyad, @KulAdi, @Sifre, @Telefon, @BolumID)";

                        using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                        {
                            using (SqlCommand kmt = new SqlCommand(sorgu, baglanti))
                            {

                                kmt.Parameters.AddWithValue("@TurID", comboBox_KullaniciTuru.SelectedValue);
                                kmt.Parameters.AddWithValue("@TCKimlikNo", textBox_TCKimlikAra.Text);
                                kmt.Parameters.AddWithValue("@Ad", textBox_adi.Text);
                                kmt.Parameters.AddWithValue("@Soyad", textBox_soyadi.Text);
                                kmt.Parameters.AddWithValue("@KulAdi", textBox_KullaniciAdi.Text);
                                kmt.Parameters.AddWithValue("@Sifre", textBox_Sifre.Text);
                                kmt.Parameters.AddWithValue("@Telefon", textBox_telefon.Text);

                                if (comboBox_KullaniciTuru.SelectedIndex == 0)
                                {
                                    kmt.Parameters.AddWithValue("@BolumID", 14);
                                }

                                else if (comboBox_KullaniciTuru.SelectedIndex == 2)
                                {
                                    kmt.Parameters.AddWithValue("@BolumID", 15);
                                }

                                else
                                {
                                    kmt.Parameters.AddWithValue("@BolumID", comboBox_DoktorBolum.SelectedValue);
                                }

                                try
                                {
                                    baglanti.Open();
                                    kmt.ExecuteNonQuery();
                                    MessageBox.Show("Kayıt Tamamlandı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Temizle();
                                    KullaniciListele();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Hata Oluştu: " + ex.Message, "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void Temizle()
        {
            comboBox_KullaniciTuru.SelectedValue = 1;
            KullaniciVar = false;
            AramaYapildiMi = false;
            checkBox_sifreGoster.Checked = false;
            checkBox_sifreTekrarGoster.Checked = false;
            textBox_TCKimlikAra.ReadOnly = false;
            textBox_TCKimlikAra.Text = "";
            textBox_adi.Text = "";
            textBox_soyadi.Text = "";
            textBox_KullaniciAdi.Text = "";
            textBox_Sifre.Text = "";
            textBox_SifreTekrar.Text = "";
            textBox_telefon.Text = "";
            groupBox_KullaniciBilgileri.Enabled = false;
        }
        private void KullaniciBilgileriEtkinlestir()
        {
            comboBox_KullaniciTuru.SelectedIndex = 0;
            textBox_adi.Text = "";
            textBox_soyadi.Text = "";
            textBox_KullaniciAdi.Text = "";
            textBox_Sifre.Text = "";
            textBox_SifreTekrar.Text = "";
            textBox_telefon.Text = "";
            groupBox_KullaniciBilgileri.Enabled = true;
        }
        private void KullaniciBilgileriniGetir(string tcKimlikNo)
        {
            string sorgu = "SELECT * FROM KullaniciBilgileri WHERE TCKimlikNo = @TCKimlikNo";

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
                            comboBox_KullaniciTuru.SelectedValue = reader["Kullanici Turu"];
                            comboBox_DoktorBolum.SelectedValue = reader["Bolumu"];
                            textBox_adi.Text = reader["Ad"].ToString();
                            textBox_soyadi.Text = reader["Soyad"].ToString();
                            textBox_KullaniciAdi.Text = reader["KulAdi"].ToString();
                            textBox_Sifre.Text = reader["Sifre"].ToString();
                            textBox_SifreTekrar.Text = reader["Sifre"].ToString();
                            textBox_telefon.Text = reader["Telefon"].ToString();
                            // Eski değerleri güncelle
                            eskiAd = reader["Ad"].ToString();
                            eskiSoyad = reader["Soyad"].ToString();
                            eskiKullaniciAdi = reader["KulAdi"].ToString();
                            eskiSifre = reader["Sifre"].ToString();
                            eskiTelefon = reader["Telefon"].ToString();
                            eskiKullaniciTuru = reader["Kullanici Turu"].ToString();
                            eskiBolum = reader["Bolumu"].ToString();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message,"Kullanıcı İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void SifreGoster(object sender, EventArgs e)
        {
            if (textBox_Sifre.PasswordChar == '*')
            {
                // Şifre, şifre karakterini gizleyin
                textBox_Sifre.PasswordChar = '\0'; // Boş karakter
            }
            else
            {
                // Şifre gizliyse, şifreyi gizleme karakteriyle değiştirin
                textBox_Sifre.PasswordChar = '*';
            }
        }
        private void SifreTekrarGoster(object sender, EventArgs e)
        {
            if (textBox_SifreTekrar.PasswordChar == '*')
            {
                // Şifre, şifre karakterini gizleyin
                textBox_SifreTekrar.PasswordChar = '\0'; // Boş karakter
            }
            else
            {
                // Şifre gizliyse, şifreyi gizleme karakteriyle değiştirin
                textBox_SifreTekrar.PasswordChar = '*';
            }
        }
        private void GuncelleButonTık(object sender, EventArgs e)
        {
            if (AramaYapildiMi == false)
            {
                MessageBox.Show("Önce TC Kimlik no sorgusu yapınız", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KullaniciVar == true)
            {
                if (!MevcutBilgilerdeDegisiklikVar())
                {
                    MessageBox.Show("Hata: Kullanıcı bilgilerinde değişiklik yapılmadı.", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    //Şartlar sağlandı mı?
                    if (KayitSartlariSaglandi())
                    {
                        DialogResult GuncelleOnay = MessageBox.Show("Kullanıcı bilgilerini güncellemek istediğinizden emin misiniz?", "Kullanıcı İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (GuncelleOnay == DialogResult.Yes)
                        {
                            // Yeni bilgileri kullanarak güncelleme sorgusu oluştur
                            string GuncellemeSorgu = "UPDATE KullaniciBilgileri SET [Kullanici Turu] = @TurID, Ad = @Ad, Soyad = @Soyad, KulAdi = @KulAdi, Sifre = @Sifre, Telefon = @Telefon, Bolumu = @BolumID WHERE TCKimlikNo = @TCKimlikNo";
                            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                            {
                                using (SqlCommand kmt = new SqlCommand(GuncellemeSorgu, baglanti))
                                {
                                    kmt.Parameters.AddWithValue("@TurID", comboBox_KullaniciTuru.SelectedValue);
                                    kmt.Parameters.AddWithValue("@Ad", textBox_adi.Text);
                                    kmt.Parameters.AddWithValue("@Soyad", textBox_soyadi.Text);
                                    kmt.Parameters.AddWithValue("@KulAdi", textBox_KullaniciAdi.Text);
                                    kmt.Parameters.AddWithValue("@Sifre", textBox_Sifre.Text);
                                    kmt.Parameters.AddWithValue("@Telefon", textBox_telefon.Text);
                                    if (comboBox_KullaniciTuru.SelectedIndex == 0)
                                    {
                                        kmt.Parameters.AddWithValue("@BolumID", 14);
                                    }

                                    else if (comboBox_KullaniciTuru.SelectedIndex == 2)
                                    {
                                        kmt.Parameters.AddWithValue("@BolumID", 15);
                                    }
                                    else
                                    {
                                        kmt.Parameters.AddWithValue("@BolumID", comboBox_DoktorBolum.SelectedValue);
                                    }

                                    kmt.Parameters.AddWithValue("@TCKimlikNo", textBox_TCKimlikAra.Text);

                                    try
                                    {
                                        baglanti.Open();
                                        int rowsAffected = kmt.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Kullanıcı bilgileri güncellendi!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            // Eski değerleri güncelle
                                            eskiAd = textBox_adi.Text;
                                            eskiSoyad = textBox_soyadi.Text;
                                            eskiKullaniciAdi = textBox_KullaniciAdi.Text;
                                            eskiSifre = textBox_Sifre.Text;
                                            eskiTelefon = textBox_telefon.Text;
                                            eskiKullaniciTuru = comboBox_KullaniciTuru.SelectedValue.ToString();
                                            eskiBolum = comboBox_DoktorBolum.SelectedValue.ToString();
                                            AramaYapildiMi = false;
                                            Temizle();
                                            KullaniciListele();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Güncelleme işlemi başarısız oldu!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }

            else
            {
                MessageBox.Show("Hesap Bulunamadı.", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool MevcutBilgilerdeDegisiklikVar()
        {
            // Mevcut bilgilerle formdaki bilgileri karşılaştır
            // Değişiklik varsa true, yoksa false döndür
            if (textBox_adi.Text != eskiAd || textBox_soyadi.Text != eskiSoyad || textBox_KullaniciAdi.Text != eskiKullaniciAdi || textBox_Sifre.Text != eskiSifre || textBox_telefon.Text != eskiTelefon || comboBox_KullaniciTuru.SelectedValue.ToString() != eskiKullaniciTuru || comboBox_DoktorBolum.SelectedValue.ToString() != eskiBolum || textBox_Sifre.Text != textBox_SifreTekrar.Text)
            {
                return true;
            }
            return false;
        }
        private bool KullaniciAdiVarMi(string kullaniciAdi, string MevcutTc)
        {
            string KullaniciGuncellemeSorgu = "SELECT COUNT(*) FROM KullaniciBilgileri WHERE KulAdi = @KulAdi and TCKimlikNo <> @MevcutTc";

            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                using (SqlCommand kmt = new SqlCommand(KullaniciGuncellemeSorgu, baglanti))
                {
                    kmt.Parameters.AddWithValue("@KulAdi", kullaniciAdi);
                    kmt.Parameters.AddWithValue("@MevcutTc", MevcutTc);

                    try
                    {
                        baglanti.Open();
                        int count = (int)kmt.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message,"Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        private bool KayitSartlariSaglandi(string mevcutTc = null)
        {
                bool kullaniciAdiVarMi = KullaniciAdiVarMi(textBox_KullaniciAdi.Text, textBox_TCKimlikAra.Text);
                List<string> hatalar = new List<string>();

                if (string.IsNullOrEmpty(textBox_adi.Text))
                {
                    hatalar.Add("Ad bölümü boş bırakılamaz.");
                }

                if (string.IsNullOrEmpty(textBox_soyadi.Text))
                {
                hatalar.Add("Soyadı bölümü boş bırakılamaz.");
                }

                if (textBox_KullaniciAdi.TextLength < 5)
                {
                    hatalar.Add("Kullanıcı adı en az 5 karakter olmalıdır.");
                }

                if (textBox_Sifre.TextLength < 8)
                {
                    if (textBox_Sifre.TextLength == 0)
                    {
                        hatalar.Add("Şifre alanı boş bırakılamaz.");
                    }
                    else
                    {
                        hatalar.Add("Şifre en az 8 karakter olmalıdır.");
                    }
                }

                if (textBox_Sifre.Text != textBox_SifreTekrar.Text)
                {
                    hatalar.Add("Şifreler eşleşmiyor.");
                }

                else if (!textBox_telefon.Text.StartsWith("0"))
                {
                hatalar.Add("Telefon numarası 0 ile başlamalıdır!");
                }

                if (textBox_telefon.TextLength < 11)
                {
                    if (string.IsNullOrWhiteSpace(textBox_telefon.Text))
                    {
                    hatalar.Add("Telefon alanı boş olamaz.");
                    }

                    else
                    {
                    hatalar.Add("Telefon numarasını 11 haneli olacak şekilde giriniz.");
                    }
                }

                if (kullaniciAdiVarMi)
                {
                    hatalar.Add("Kullanıcı adı zaten mevcut.");
                }

                if (hatalar.Count > 0)
                {
                    string hataMesaji = string.Join("\n", hatalar);
                    MessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
        }
        private void TemizleButonTik(object sender, EventArgs e)
        {
            Temizle();
            AramaYapildiMi = false;
        }
    }
}