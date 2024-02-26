using Bakery.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery.Formlar
{
    public partial class KullanıcıŞifreDeğiştirme : Form
    {
        ListelemeMetotları lm = new ListelemeMetotları();
        UpdateMetotları um = new UpdateMetotları();
        public KullanıcıŞifreDeğiştirme()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string kullaniciID = txtId.Text;
            string sifre = txtSifre.Text;
            um.Update(sifre , kullaniciID);
            MessageBox.Show("Şifre Değiştirildi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            lm.KullanıcıListele(Kullanici_tablo);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }
    }
}
