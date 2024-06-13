using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using Bil102_Grup1_FinalProject;

namespace Bil102_Grup1_FinalProject
{
    public partial class Giris : Form
    {
        private bool KullaniciAdiTusBasildiMi = false;
        private bool SifreTusBasildiMi = false;

        public Giris()
        {
            InitializeComponent();
        }

        // BaglantiBilgileri değişkeni burada tanımlandı.Kendi bilgisayarımda kullanmak için kapattım sen kendi bilgisayarında benimkini yorum satırına çevir.
        //private static readonly string BaglantiBilgileri = @"Data Source=ORTAK\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True";
        private static readonly string BaglantiBilgileri = @"Data Source=DC;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True";
        private void GirisYapButonTik(object sender, EventArgs e)
        {
            string kull_adi = textBox_kullanici.Text;
            string sifre = textBox_sifre.Text;
            bool GirisBasarili = false;
            int kullaniciTuru = 0;

            try
            {
                using (SqlConnection SunucuBaglanti = new SqlConnection(BaglantiBilgileri))
                {
                    SunucuBaglanti.Open();

                    string KullaniciKontrolSorgu = "SELECT [Kullanici Turu] FROM KullaniciBilgileri WHERE KulAdi = @kullaniciAdi";
                    using (SqlCommand KullaniciKontrolCmd = new SqlCommand(KullaniciKontrolSorgu, SunucuBaglanti))
                    {
                        KullaniciKontrolCmd.Parameters.AddWithValue("@kullaniciAdi", kull_adi);
                        object kullaniciSonuc = KullaniciKontrolCmd.ExecuteScalar();

                        if (kullaniciSonuc != null)
                        {
                            kullaniciTuru = Convert.ToInt32(kullaniciSonuc);

                            string sorgu = "SELECT [Kullanici Turu] FROM KullaniciBilgileri WHERE KulAdi = @kullaniciAdi AND Sifre = @sifre";
                            using (SqlCommand komut = new SqlCommand(sorgu, SunucuBaglanti))
                            {
                                komut.Parameters.AddWithValue("@kullaniciAdi", kull_adi);
                                komut.Parameters.AddWithValue("@sifre", sifre);
                                object sonuc = komut.ExecuteScalar();

                                if (sonuc != null)
                                {
                                    GirisBasarili = true;
                                    kullaniciTuru = Convert.ToInt32(sonuc);
                                    if (kullaniciTuru == 4)
                                    {
                                        GizliForm GizliFormF = new GizliForm();
                                        GizliFormF.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        AnaEkran AnaEkranF = new AnaEkran();
                                        AnaEkranF.KullaniciTuruAyarla(kullaniciTuru);
                                        AnaEkranF.Show();
                                        this.Hide();

                                        if (kullaniciTuru == 1)
                                        {
                                            AnaEkranF.Text = "İstinye Üniversitesi Hasta Takip Sistemi - Admin";
                                        }

                                        else if (kullaniciTuru == 2)
                                        {
                                            AnaEkranF.Text = "İstinye Üniversitesi Hasta Takip Sistemi - Doktor";
                                        }

                                        else if (kullaniciTuru == 3)
                                        {
                                            AnaEkranF.Text = "İstinye Üniversitesi Hasta Takip Sistemi - Sekreter";
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Şifre Hatalı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox_sifre.Clear();
                                    textBox_sifre.Focus();
                                }
                            }
                            GirisKayit(kull_adi, kullaniciTuru, GirisBasarili);
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Bilgileri Hatalı!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox_kullanici.Clear();
                            textBox_sifre.Clear();
                            textBox_kullanici.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GirisKayit(string kullaniciAdi, int kullaniciTuru, bool basarili)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                {
                    string ekleSorgu = "INSERT INTO GirisKayitlari (KullaniciAdi, GirisTarihi, Basarili, KullaniciTuru) VALUES (@kullaniciAdi, @giristarihi, @basarili, @kullaniciTuru)";
                    using (SqlCommand komut = new SqlCommand(ekleSorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@giristarihi", DateTime.Now);
                        komut.Parameters.AddWithValue("@basarili", basarili);
                        komut.Parameters.AddWithValue("@kullaniciTuru", kullaniciTuru);

                        baglanti.Open();
                        komut.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş kayıt hatası: " + ex.Message, "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CikisYapButon(object sender, EventArgs e)
        {
            this.Close();
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
            }
        }
        private void KullaniciAlaniGiris(object sender, KeyPressEventArgs e)
        {
            if (textBox_kullanici.Text == "Kullanıcı Adı" && !KullaniciAdiTusBasildiMi)
            {
                KullaniciAdiTusBasildiMi = true;
                textBox_kullanici.Text = "";
            }

            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            e.KeyChar = char.ToLower(e.KeyChar);
        }
        private void SifreAlaniGiris(object sender, KeyPressEventArgs e)
        {
            if (textBox_sifre.Text == "Şifre" && !SifreTusBasildiMi)
            {
                SifreTusBasildiMi = true;
                textBox_sifre.Text = "";
            }

            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        private void SifreGoster(object sender, EventArgs e)
        {
            textBox_sifre.PasswordChar = checkBox_SifreGoster.Checked ? '\0' : '*';
        }
        private void KullaniciAdiEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYapButonTik(sender, e);
            }
        }
        private void SifreEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GirisYapButonTik(sender, e);
            }
        }
        private void LogoUstuneGelince(object sender, EventArgs e)
        {
            pictureBox_logo.BorderStyle = BorderStyle.FixedSingle;
        }
        private void LogoUstundenCikinca(object sender, EventArgs e)
        {
            pictureBox_logo.BorderStyle = BorderStyle.None;
        }
        private void LogoyaSolTik(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Process.Start("https://www.istinye.edu.tr");
            }
        }
    }
}