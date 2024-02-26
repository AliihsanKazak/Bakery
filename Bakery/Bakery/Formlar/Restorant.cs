using Bakery.Masalar;
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
    public partial class Restorant : Form
    {
        public Restorant()
        {
            InitializeComponent();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ana_Ekran aekran = new Ana_Ekran();
            aekran.Show();

        }
        private void btnM1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M1 m1 = new M1();
            m1.Show();
        }

       
    }
}
