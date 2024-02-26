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

namespace Bakery
{
    public partial class PaketServis : Form
    {
        BaglantıAcma ba = new BaglantıAcma();
        ListelemeMetotları lm = new ListelemeMetotları();

        public PaketServis()
        {
            InitializeComponent();
        }

        private void btnSiparişler_Click(object sender, EventArgs e)
        {
            lm.SiparişListele(pktsrvstablo);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }
    }
}
