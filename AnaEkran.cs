using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil102_Grup1_FinalProject
{
    public partial class AnaEkran : Form

    {
        private int kullaniciTuru;
        public AnaEkran()
        {
            InitializeComponent();
        }
        public void KullaniciTuruAyarla(int kullaniciTuru)
        {
            this.kullaniciTuru = kullaniciTuru;
        }
        private void HastaKayitButonTik(object sender, EventArgs e)
        {
            HastaIslemleri HastaIslemleriF = new HastaIslemleri();
            HastaIslemleriF.Show();
            this.Hide();
        }
        private void DoktorIslemleriButonTik(object sender, EventArgs e)
        {
            if (kullaniciTuru == 3)
            {
                MessageBox.Show("Kullanıcı yetkisi gecerisiz!", "Ana Ekran", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DoktorIslemleri DoktorIslemleriF = new DoktorIslemleri();
                DoktorIslemleriF.Show();
                this.Hide();
            }
        }
        private void KullaniciIslemleriButonTik(object sender, EventArgs e)
        {
            if (kullaniciTuru == 1)
            {
                KullaniciIslemleri KullaniciIslemleriF = new KullaniciIslemleri();
                KullaniciIslemleriF.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı yetkisi geçersiz!", "Ana Ekran", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OdemeIslemleriButonTik(object sender, EventArgs e)
        {
            OdemeIslemleri OdemeIslemleriF = new OdemeIslemleri();
            OdemeIslemleriF.Show();
            this.Hide();
        }
        private void CikisYapSagUst(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
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
        private void DoktorIslemleriLogoTik(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                DoktorIslemleriButonTik(sender, e);
            }
        }
        private void HastaKayitLogoTik(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                HastaKayitButonTik(sender, e);
            }
        }
        private void KullaniciIslemleriLogoTik(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                KullaniciIslemleriButonTik(sender, e);
            }
        }
        private void OdemeIslemleriLogoTik(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OdemeIslemleriButonTik(sender, e);
            }
        }
    }
}