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
    public partial class KullanıcıSilme : Form
    {
        BaglantıAcma ba = new BaglantıAcma();
        ListelemeMetotları lm = new ListelemeMetotları();
        //string connection = " Server = DESKTOP-TQ8FN5C\\SQLDERS; Database=Bakery;User Id=sa;Password=1;TrustServerCertificate=True;";
       
        public KullanıcıSilme()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ba.BaglantiAc();
            
            string ıd = txtId.Text;


            string delete_query = $"DELETE from Kullanicilar where KullanıcıID='{ıd}'";

            SqlCommand command = new SqlCommand(delete_query, ba.BaglantiAc());

            command.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı Silindi");
        }

        private void Kullanici_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            lm.KullanıcıListele(Kullanici_table);
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }
    }
}
