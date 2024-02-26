using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class Ana_Ekran : Form
    {
        public Ana_Ekran()
        {
            InitializeComponent();
        }

        private void btn_pktsrvs_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaketServis paketServis = new PaketServis();
            paketServis.Show();
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Restorant restorant = new Restorant();
            restorant.Show();
        }

        private void btn_gelal_Click(object sender, EventArgs e)
        {
            this.Hide();
            GelAl gelAl = new GelAl();
            gelAl.Show();
        }

        private void btnFonksiyonlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fonksiyonlar fonksiyonlar = new Fonksiyonlar();
            fonksiyonlar.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void btnVeriGünc_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerilerİGüncelle veriguncelle = new VerilerİGüncelle();
            veriguncelle.Show();
        }

        
    }
}
