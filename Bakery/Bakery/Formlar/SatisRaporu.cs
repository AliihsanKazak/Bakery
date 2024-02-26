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
    public partial class SatisRaporu : Form
    {
        BaglantıAcma ba = new BaglantıAcma();
        ListelemeMetotları lm = new ListelemeMetotları();
        public SatisRaporu()
        {
            InitializeComponent();
        }
        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fonksiyonlar fonk = new Fonksiyonlar();
            fonk.Show();
        }
        private void btnSatısRaporu_Click(object sender, EventArgs e)
        {
            ba.BaglantiAc();
            lm.SatışRaporuListele(satısRaporu_table);
        }

        
    }
}
