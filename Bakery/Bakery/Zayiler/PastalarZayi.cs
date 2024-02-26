using Bakery.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery.Zayiler
{
    public partial class PastalarZayi : Form
    {
        BaglantıAcma ba = new BaglantıAcma();
        ListelemeMetotları lm = new ListelemeMetotları();
        InstertMetotları im = new InstertMetotları();
        public PastalarZayi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string pasta = cmbpasta.Text;
            DateTime gün = dtpgün.Value;
            string adet = txtAdet.Text;
            string fiyat = txtFiyat.Text;
            im.PastaZayiEkle(pasta, gün, adet, fiyat);
            MessageBox.Show("Zayi Eklendi");
        }

        private void btnpastazayigöster_Click(object sender, EventArgs e)
        {
            ba.BaglantiAc();
            lm.PastaZayileriListele(zayiler_table);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fonksiyonlar fonk = new Fonksiyonlar();
            fonk.Show();
        }
    }
}
