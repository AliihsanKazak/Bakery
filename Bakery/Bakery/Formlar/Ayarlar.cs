using Bakery.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class Ayarlar : Form
    {
        
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ana_Ekran aekran = new Ana_Ekran();
            aekran.Show();
        }

        private void btnKullaniciEkleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullanıcıEkleme ke = new KullanıcıEkleme();
            ke.Show();
        }

        private void btnKullaniciSilme_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullanıcıSilme ks = new KullanıcıSilme();
            ks.Show();
        }

        private void btnKullaniciSifreDegistirme_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullanıcıŞifreDeğiştirme kşd = new KullanıcıŞifreDeğiştirme();
            kşd.Show();
        }
    }
}
