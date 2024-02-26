using Bakery.Classlar;
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
    public partial class KullanıcıEkleme : Form
    {
        InstertMetotları im = new InstertMetotları();
        string connection = " Server = DESKTOP-TQ8FN5C\\SQLDERS; Database=Bakery;User Id=sa;Password=1;TrustServerCertificate=True;";
        
        public KullanıcıEkleme()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string sifre = txt_sifre.Text;

            im.KullanıcıEkle(isim, soyisim, sifre);
            MessageBox.Show("Kullanıcı Eklendi");
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }
    }
}
