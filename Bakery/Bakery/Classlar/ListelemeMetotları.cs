using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery.Classlar
{
    internal class ListelemeMetotları
    {
        BaglantıAcma ba = new BaglantıAcma();
        public void KullanıcıListele(DataGridView bilgi_table)
        {

            string list_query = $"Select * from Kullanicilar";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable kullanicilar_table = new DataTable();
            adapter.Fill(kullanicilar_table); 
            bilgi_table.DataSource = kullanicilar_table;

        }

        public void SiparişListele(DataGridView bilgi_table)
        {

            string list_query = $"Select * from PaketServis";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable kullanicilar_table = new DataTable();
            adapter.Fill(kullanicilar_table);
            bilgi_table.DataSource = kullanicilar_table;

        }
        public void BPastaZayileriListele(DataGridView zayi_table)
        {

            string list_query = $"Select * from BütünPastaZayi";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable zayiler_table = new DataTable();
            adapter.Fill(zayiler_table);
            zayi_table.DataSource = zayiler_table;

        }
        public void PastaZayileriListele(DataGridView zayi_table)
        {

            string list_query = $"Select * from PastalarZayi";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable zayiler_table = new DataTable();
            adapter.Fill(zayiler_table);
            zayi_table.DataSource = zayiler_table;

        }
        public void KekZayileriListele(DataGridView zayi_table)
        {

            string list_query = $"Select * from KeklerZayi";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable zayiler_table = new DataTable();
            adapter.Fill(zayiler_table);
            zayi_table.DataSource = zayiler_table;

        }
        public void EkmekZayileriListele(DataGridView zayi_table)
        {

            string list_query = $"Select * from EkmeklerZayi";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable zayiler_table = new DataTable();
            adapter.Fill(zayiler_table);
            zayi_table.DataSource = zayiler_table;

        }
        public void KruvasanZayileriListele(DataGridView zayi_table)
        {

            string list_query = $"Select * from KruvasanlarZayi";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable zayiler_table = new DataTable();
            adapter.Fill(zayiler_table);
            zayi_table.DataSource = zayiler_table;

        }
        public void SatışRaporuListele(DataGridView satışraporu_table)
        {

            string list_query = $"Select * from SatışRaporu";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable satışraporları_table = new DataTable();
            adapter.Fill(satışraporları_table);
            satışraporu_table.DataSource = satışraporları_table;

        }
        public void MKSRaporuListele(DataGridView satışraporu_table)
        {

            string list_query = $"Select * from MenüKalemiSatışRaporu";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable satışraporları_table = new DataTable();
            adapter.Fill(satışraporları_table);
            satışraporu_table.DataSource = satışraporları_table;

        }
        public void KuryeRaporuListele(DataGridView satışraporu_table)
        {

            string list_query = $"Select * from KuryeSatışRaporu";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());
            DataTable satışraporları_table = new DataTable();
            adapter.Fill(satışraporları_table);
            satışraporu_table.DataSource = satışraporları_table;

        }
    }
}
