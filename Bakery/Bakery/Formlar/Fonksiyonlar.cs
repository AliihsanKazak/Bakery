using Bakery.Formlar;
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
    public partial class Fonksiyonlar : Form
    {
        public Fonksiyonlar()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ana_Ekran aekran = new Ana_Ekran();
            aekran.Show();
        }

        private void btnZayi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zayi zayi = new Zayi();
            zayi.Show();
        }

        private void btnSatısRaporu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SatisRaporu satisRaporu = new SatisRaporu();
            satisRaporu.Show();
        }

        private void btnMenüKSR_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenüKalemiSatisRaporu mksr = new MenüKalemiSatisRaporu();
            mksr.Show();
        }

        private void btnKuryeSR_Click(object sender, EventArgs e)
        {
            this.Hide();
            KuryeSatisRaporu kuryesr = new KuryeSatisRaporu();
            kuryesr.Show();
        }
    }
}
