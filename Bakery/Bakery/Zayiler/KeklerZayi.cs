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
    public partial class KeklerZayi : Form
    {
        BaglantıAcma ba = new BaglantıAcma();
        ListelemeMetotları lm = new ListelemeMetotları();
        InstertMetotları im = new InstertMetotları();
        public KeklerZayi()
        {
            InitializeComponent();
        }

        private void btnkekzayigöster_Click(object sender, EventArgs e)
        {
            ba.BaglantiAc();
            lm.KekZayileriListele(zayiler_table);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kek = cmbkek.Text;
            DateTime gün = dtpgün.Value;
            string adet = txtAdet.Text;
            string fiyat = txtFiyat.Text;
            im.KeklerZayiEkle(kek, gün, adet, fiyat);
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
