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

namespace Bakery.Zayiler
{
    public partial class BütünPastalarZayi : Form
    {
        BaglantıAcma ba = new BaglantıAcma();
        ListelemeMetotları lm = new ListelemeMetotları();
        InstertMetotları im = new InstertMetotları();
        public BütünPastalarZayi()
        {
            InitializeComponent();
        }

        private void btnbpastazayilerigöster_Click(object sender, EventArgs e)
        {
            ba.BaglantiAc();
            lm.BPastaZayileriListele(zayiler_table);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string bpasta = cmbbpasta.Text;
            DateTime gün = dtpgün.Value;
            string adet = txtAdet.Text;
            string fiyat = txtFiyat.Text;
            im.BPastaZayiEkle(bpasta, gün, adet, fiyat);
            MessageBox.Show("Zayi Eklendi");
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fonksiyonlar fonk = new Fonksiyonlar();
            fonk.Show();
        }
    }
}
