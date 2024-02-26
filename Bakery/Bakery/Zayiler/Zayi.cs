using Bakery.Classlar;
using Bakery.Zayiler;
using Microsoft.Data.SqlClient;
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
    public partial class Zayi : Form
    {
        BaglantıAcma ba = new BaglantıAcma();
        ListelemeMetotları lm = new ListelemeMetotları();
        InstertMetotları im = new InstertMetotları();
        public Zayi()
        {
            InitializeComponent();
        }


        private void btnzayilerigöster_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            BütünPastalarZayi bütünpastalarZayi = new BütünPastalarZayi();
            bütünpastalarZayi.Show();
        }
        private void btnpastazayigöster_Click(object sender, EventArgs e)
        {
            this.Hide();
            PastalarZayi pastalarZayi = new PastalarZayi();
            pastalarZayi.Show();
        }
        

        private void btnkekzayigöster_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeklerZayi keklerZayi = new KeklerZayi();
            keklerZayi.Show();
        }

        private void btnekmekzayigöster_Click(object sender, EventArgs e)
        {
            this.Hide();
            EkmeklerZayi ekmeklerZayi = new EkmeklerZayi();
            ekmeklerZayi.Show();
        }

        private void btnkruvasanzayigöster_Click(object sender, EventArgs e)
        {
            this.Hide();
            KruvasanlarZay_ kruvasanlarZayi = new KruvasanlarZay_();
            kruvasanlarZayi.Show();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fonksiyonlar fonk = new Fonksiyonlar();
            fonk.Show();
        }
    }
}
