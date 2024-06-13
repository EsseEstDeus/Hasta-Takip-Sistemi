using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Bil102_Grup1_FinalProject
{
    public partial class DoktorIslemleri : Form
    {
        private int ToplamTutar = 0;
        public DoktorIslemleri()
        {
            InitializeComponent();

            this.check_mr.CheckedChanged += new System.EventHandler(this.TahlilTikDegisimi);
            this.check_rontgen.CheckedChanged += new System.EventHandler(this.TahlilTikDegisimi);
            this.check_idrar.CheckedChanged += new System.EventHandler(this.TahlilTikDegisimi);
            this.check_kan.CheckedChanged += new System.EventHandler(this.TahlilTikDegisimi);
            this.check_ultrason.CheckedChanged += new System.EventHandler(this.TahlilTikDegisimi);
            this.check_endoskopi.CheckedChanged += new System.EventHandler(this.TahlilTikDegisimi);
            comboBox_hastaDurumu.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private bool HastaBulundu=false;
        private static readonly string BaglantiBilgileri = @"Data Source=DC;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True";
        private void AnaEkranaDon(object sender, EventArgs e)
        {
            AnaEkran AnaEkranF = Application.OpenForms["AnaEkran"] as AnaEkran;
            AnaEkranF.Show();
            this.Hide();
        }
        private void CikisYapSagUSt(object sender, FormClosingEventArgs e)
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
        private void TCKimlikNoAra(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AraButonTik(object sender, EventArgs e)
        {
            if (textBox_tcKimlikNo.TextLength == 11)
            {
                string tcKimlikNo = textBox_tcKimlikNo.Text;
                HastaBilgileriniGetir(tcKimlikNo);

                if (HastaBulundu == true)
                {
                    btn_Temizle.Visible = true;
                    textBox_tcKimlikNo.ReadOnly = true;
                }
            }

            else
            {
                MessageBox.Show("T.C. kimlik no eksik girildi.", "Doktor İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_tcKimlikNo.Focus();
            }
        }
        private void TemizleButonTik(object sender, EventArgs e)
        {
            btn_Temizle.Visible=false;
            textBox_tcKimlikNo.ReadOnly = false;
            YeniArama();
            textBox_tcKimlikNo.Focus();

        }
        private void YeniArama()
        {
            HastaBulundu=false;
            groupBox_UygulanacakIslemler.Enabled=false;

            textBox_tcKimlikNo.Text = "";
            textBox_hastaTeshis.Text = "";
            textBox_sonuc.Text = "";
            textBox_tcKimlikNo.Focus();

            comboBox_hastaDurumu.Text = null;

            check_endoskopi.Checked = false;
            check_idrar.Checked = false;
            check_kan.Checked = false;
            check_mr.Checked = false;
            check_rontgen.Checked = false;
            check_ultrason.Checked = false;

            lbl_hastaAdiDB.Text = "";
            lbl_hastaSoyadDB.Text = "";
            lbl_dogumTarihiDB.Text = "";
            lbl_dogumYeriDB.Text = "";
            lbl_cinsiyetDB.Text = "";
            lbl_medeniHaliDB.Text = "";
            lbl_kanGrubuDB.Text = "";
            lbl_AlerjiDB.Text = "";
            lbl_hastaGirişDB.Text = "";
            lbl_hastaCikisDB.Text = "";
            lbl_AdresDB.Text = "";
            lbl_telefonDB.Text = "";
            lbl_bolumDB.Text = "";
            lbl_doktorDB.Text = "";
        }
        private void HastaBilgileriniGetir(string tcKimlikNo)
        {
            string ListeleSorgu = @"SELECT 
                        hb.HastaID,
                        b.[Bolum Adı] as 'Bölüm Adı',
                        kb.Ad + ' ' + kb.Soyad as 'Doktor Adı',
                        hb.TCKimlikNo as 'TC Kimlik No', 
                        hb.Ad, 
                        hb.Soyad , 
                        hb.[Doğum Tarihi], 
                        hb.[Doğum Yeri], 
                        hb.Cinsiyet, 
                        hb.[Medeni Hal], 
                        hb.[Kan Grubu], 
                        hb.Alerji, 
                        hb.[Hasta Giriş], 
                        hb.[Hasta Çıkış], 
                        hb.Adres, 
                        hb.Telefon,
                        hb.Bolumu,
                        hb.Doktor
                    FROM 
                        HastaBilgileri hb
                    LEFT JOIN 
                        Bolumler b ON hb.Bolumu = b.BolumID
                    LEFT JOIN 
                        KullaniciBilgileri kb ON hb.Doktor = kb.PersonelID
                    WHERE hb.TCKimlikNo = @TCKimlikNo";

            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                using (SqlCommand kmt = new SqlCommand(ListeleSorgu, baglanti))
                {
                    kmt.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);

                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = kmt.ExecuteReader();

                        if (reader.Read())
                        {
                            HastaBulundu = true;
                            lbl_hastaAdiDB.Text = reader["Ad"].ToString();
                            lbl_hastaSoyadDB.Text = reader["Soyad"].ToString();
                            lbl_dogumYeriDB.Text =reader["Doğum Yeri"].ToString();
                            lbl_dogumTarihiDB.Text = Convert.ToDateTime(reader["Doğum Tarihi"]).ToString("dd/MM/yyyy");
                            lbl_cinsiyetDB.Text = reader["Cinsiyet"].ToString();
                            lbl_medeniHaliDB.Text = reader["Medeni Hal"].ToString();
                            lbl_kanGrubuDB.Text = reader["Kan Grubu"].ToString();
                            lbl_AlerjiDB.Text = reader["Alerji"].ToString();
                            lbl_hastaGirişDB.Text = Convert.ToDateTime(reader["Hasta Giriş"]).ToString("dd/MM/yyyy");
                            lbl_hastaCikisDB.Text = Convert.ToDateTime(reader["Hasta Çıkış"]).ToString("dd/MM/yyyy");
                            lbl_AdresDB.Text = reader["Adres"].ToString();
                            lbl_telefonDB.Text = reader["Telefon"].ToString();
                            lbl_bolumDB.Text = reader["Bölüm Adı"].ToString();
                            lbl_doktorDB.Text = reader["Doktor Adı"].ToString();
                            groupBox_UygulanacakIslemler.Enabled = true;
                        }
                        else
                        {
                            HastaBulundu = false;
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
        private void EkleButonTik(object sender, EventArgs e)
        {
            // 1. textBox_tcKimlikNo içeriğini alın
            string tcKimlikNo = textBox_tcKimlikNo.Text;

            // 2. Veritabanında hastayı bulun ve ilgili bilgileri alın
            int hastaID;
            int doktorID;
            int bolumID;
            string teshis = textBox_hastaTeshis.Text;
            string durum = comboBox_hastaDurumu.Text;
            string sonuc = textBox_sonuc.Text;

            // Önce hastayı bulalım
            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                string sorgu = "SELECT HastaID, Doktor, Bolumu FROM HastaBilgileri WHERE TCKimlikNo = @TCKimlikNo";
                using (SqlCommand kmt = new SqlCommand(sorgu, baglanti))
                {
                    kmt.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);
                    try
                    {
                        baglanti.Open();
                        using (SqlDataReader reader = kmt.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hastaID = reader.GetInt32(0);
                                doktorID = reader.GetInt32(1);
                                bolumID = reader.GetInt32(2);
                                reader.Close();

                                // 3. textBox_hastaTeshis, comboBox_hastaDurumu, textBox_sonuc ve ToplamTutar değerlerini alın
                                // Değerler zaten alınmış durumda

                                // 4. Yeni işlem kaydını oluşturun ve "Islemler" tablosuna ekleyin
                                string insertSorgu = @"INSERT INTO Islemler (HastaID, Bolumu, Doktor, Teshis, HastaDurum, Sonuc, Tutar, OdemeDurumu) 
                                           VALUES (@HastaID, @Bolumu, @Doktor, @Teshis, @Durum, @Sonuc, @Tutar, 'Ödenmedi')";
                                using (SqlCommand insertKomut = new SqlCommand(insertSorgu, baglanti))
                                {
                                    insertKomut.Parameters.AddWithValue("@HastaID", hastaID);
                                    insertKomut.Parameters.AddWithValue("@Bolumu", bolumID);
                                    insertKomut.Parameters.AddWithValue("@Doktor", doktorID);
                                    insertKomut.Parameters.AddWithValue("@Teshis", teshis);
                                    insertKomut.Parameters.AddWithValue("@Durum", durum);
                                    insertKomut.Parameters.AddWithValue("@Sonuc", sonuc);
                                    insertKomut.Parameters.AddWithValue("@Tutar", ToplamTutar); // ToplamTutar değeri zaten alınmıştı

                                    int etkilenenSutun = insertKomut.ExecuteNonQuery();
                                    if (etkilenenSutun > 0)
                                    {
                                        MessageBox.Show("İşlem başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        YeniArama();
                                    }
                                    else
                                    {
                                        MessageBox.Show("İşlem kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Belirtilen TC Kimlik numarasına sahip hasta bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } // SqlDataReader burada otomatik olarak kapatılacak
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void TahlilTikDegisimi(object sender, EventArgs e)
        {
            CheckBox TikKutusu = sender as CheckBox;
            if (TikKutusu != null)
            {
                int tutar = VeritabanındanTutarAl(TikKutusu.Text);
                if (TikKutusu.Checked)
                {
                    ToplamTutar += tutar;
                }
                else
                {
                    ToplamTutar -= tutar;
                }
            }
        }
        private int VeritabanındanTutarAl(string testName)
        {
            int tutar = 0;

            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                string sorgu = "SELECT Ucret FROM Tahliller WHERE [Tahlil Adı] = @TestAdi";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TestAdi", testName);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = komut.ExecuteReader();
                    if (reader.Read())
                    {
                        tutar = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Doktor İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            return tutar;
        }
    }
}
