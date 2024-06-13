using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil102_Grup1_FinalProject
{
    public partial class OdemeIslemleri : Form
    {
        public OdemeIslemleri()
        {
            InitializeComponent();
            combo_odemeDurumu.DropDownStyle=ComboBoxStyle.DropDownList;
        }
        private static readonly string BaglantiBilgileri = @"Data Source=DC;Initial Catalog=Hastane;Integrated Security=True;TrustServerCertificate=True";
        private bool OdemeBulundu = false;
        private bool AramaYapildi =false;
        string SecilenHastaID;
        bool HastaBulundu;
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
        private void TCKimlikNoAra(object sender, KeyPressEventArgs e)
        {
           if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AraButonTik(object sender, EventArgs e)
        {
            if(txt_aranacakTC.TextLength == 11)
            {
                string tcKimlikNo = txt_aranacakTC.Text;
                HastaBilgileriniGetir(tcKimlikNo);
                btn_Temizle.Visible = true;

                if (OdemeBulundu == true)
                {
                    AramaYapildi = true;
                    txt_aranacakTC.ReadOnly = true;
                }
            }

            else
            {
                MessageBox.Show("T.C. kimlik numarasını 11 hane olacak şekilde giriniz.","Ödeme İşlemeleri",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void HastaBilgileriniGetir(string tcKimlikNo)
        {
            string HastaSorgu = @"SELECT 
                        hb.HastaID,
                        hb.TCKimlikNo
                    FROM 
                        Islemler i
                    LEFT JOIN 
                        HastaBilgileri hb ON hb.HastaID = i.HastaID
                    WHERE hb.TCKimlikNo = @TCKimlikNo";

            using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
            {
                using (SqlCommand kmt = new SqlCommand(HastaSorgu, baglanti))
                {
                    kmt.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);

                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = kmt.ExecuteReader();

                        if (reader.Read())
                        {
                            HastaBulundu = true;
                        }
                        else
                        {
                            HastaBulundu = false;
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (HastaBulundu == true)
            {
                string OdemeSorgu = @"SELECT 
                        hb.HastaID,
                        hb.TCKimlikNo,
                        i.Teshis,
                        i.Sonuc,
                        i.Tutar,
                        i.IslemID
                    FROM 
                        Islemler i
                    LEFT JOIN 
                        HastaBilgileri hb ON hb.HastaID = i.HastaID
                    WHERE hb.TCKimlikNo = @TCKimlikNo AND i.OdemeDurumu <> 'Ödendi'";

                using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                {
                    using (SqlCommand kmt = new SqlCommand(OdemeSorgu, baglanti))
                    {
                        kmt.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);

                        try
                        {
                            baglanti.Open();
                            SqlDataReader reader = kmt.ExecuteReader();

                            if (reader.Read())
                            {
                                OdemeBulundu = true;
                                lbl_tcDB.Text = reader["TCKimlikNo"].ToString();
                                lbl_teshisDB.Text = reader["Teshis"].ToString();
                                lbl_sonucDB.Text = reader["Sonuc"].ToString();
                                lbl_ucretDB.Text = reader["Tutar"].ToString();
                                SecilenHastaID = reader["IslemID"].ToString();
                            }
                            else
                            {
                                OdemeBulundu = false;
                                MessageBox.Show("Hastaya ait borç bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Kayıtlı hasta bulunamadı.","Ödeme İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void TemizleButonTik(object sender, EventArgs e)
        {
            Temizle();
            btn_Temizle.Visible=false;
        }
        private void Temizle()
        {
            txt_aranacakTC.Text="";
            txt_aranacakTC.ReadOnly=false;
            combo_odemeDurumu.DisplayMember = null;
            OdemeBulundu = false;
            lbl_tcDB.Text = "";
            lbl_teshisDB.Text = "";
            lbl_ucretDB.Text="";
            lbl_sonucDB.Text="";
        }
        private void IslemEkleButonTik(object sender, EventArgs e)
        {
            if (OdemeBulundu == true)
            {
                DialogResult IslemKayit = MessageBox.Show("Ödeme durumunu kaydetmek istediğinize emin misiniz?","Ödeme İşlemleri",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(IslemKayit == DialogResult.Yes)
                {
                    string updateSorgu = @"UPDATE Islemler 
                                   SET OdemeDurumu = @OdemeDurumu 
                                   WHERE HastaID = (SELECT HastaID FROM HastaBilgileri WHERE TCKimlikNo = @TCKimlikNo AND @IslemID = IslemID AND OdemeDurumu <>'Ödendi')";

                    using (SqlConnection baglanti = new SqlConnection(BaglantiBilgileri))
                    {
                        using (SqlCommand kmt = new SqlCommand(updateSorgu, baglanti))
                        {

                            kmt.Parameters.AddWithValue("@OdemeDurumu", combo_odemeDurumu.Text);
                            kmt.Parameters.AddWithValue("@TCKimlikNo", txt_aranacakTC.Text );
                            kmt.Parameters.AddWithValue("@IslemID", SecilenHastaID);
                            
                            try
                            {
                                baglanti.Open();
                                kmt.ExecuteNonQuery();
                                MessageBox.Show("Ödeme kaydı tamamlandı!", "Kullanıcı İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Temizle();
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
                MessageBox.Show("Hasta Seçiniz.","Ödeme İşlemleri",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
