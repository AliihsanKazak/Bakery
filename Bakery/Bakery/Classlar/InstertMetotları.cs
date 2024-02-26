using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Classlar
{
    internal class InstertMetotları
    {
        ExecuteNoneQuery en = new ExecuteNoneQuery();
        BaglantıAcma ba = new BaglantıAcma();
        public void KullanıcıEkle(string isim, string soyisim, string sifre)
        {
            string insert_query = $"insert into Kullanicilar (KullanıcıAdı,KullanıcıSoyadı,KullanıcıŞifresi)values('{isim}','{soyisim}','{sifre}')";

            en.Execute(insert_query, ba.BaglantiAc());

            ba.BaglantiKapat(ba.BaglantiAc());

        }
        public void BPastaZayiEkle(string bpasta, DateTime gün, string adet, string fiyat)
        {
            string insert_query = $"insert into BütünPastaZayi (BütünPastalar,Gün,Adet,Fiyat)values('{bpasta}','{gün}','{adet}','{fiyat}')";

            en.Execute(insert_query, ba.BaglantiAc());

            ba.BaglantiKapat(ba.BaglantiAc());

        }
        public void PastaZayiEkle(string pasta, DateTime gün, string adet, string fiyat)
        {
            string insert_query = $"insert into PastalarZayi (Pastalar,Gün,Adet,Fiyat)values('{pasta}','{gün}','{adet}','{fiyat}')";

            en.Execute(insert_query, ba.BaglantiAc());

            ba.BaglantiKapat(ba.BaglantiAc());

        }
        public void KeklerZayiEkle(string kek, DateTime gün, string adet, string fiyat)
        {
            string insert_query = $"insert into KeklerZayi (Kekler,Gün,Adet,Fiyat)values('{kek}','{gün}','{adet}','{fiyat}')";

            en.Execute(insert_query, ba.BaglantiAc());

            ba.BaglantiKapat(ba.BaglantiAc());

        }
        public void EkmeklerZayiEkle(string ekmekler, DateTime gün, string adet, string fiyat)
        {
            string insert_query = $"insert into EkmeklerZayi (Ekmekler,Gün,Adet,Fiyat)values('{ekmekler}','{gün}','{adet}','{fiyat}')";

            en.Execute(insert_query, ba.BaglantiAc());

            ba.BaglantiKapat(ba.BaglantiAc());

        }
        public void KruvasanlarZayiEkle(string kruvasan, DateTime gün, string adet, string fiyat)
        {
            string insert_query = $"insert into KruvasanlarZayi (Kruvasanlar,Gün,Adet,Fiyat)values('{kruvasan}','{gün}','{adet}','{fiyat}')";

            en.Execute(insert_query, ba.BaglantiAc());

            ba.BaglantiKapat(ba.BaglantiAc());

        }
    }
}
