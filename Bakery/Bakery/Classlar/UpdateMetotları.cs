using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Classlar
{
    internal class UpdateMetotları
    {
        ExecuteNoneQuery en = new ExecuteNoneQuery();
        BaglantıAcma ba = new BaglantıAcma();

        public void Update(string sifre, string kullaniciID)
        {

            string guncelle = $"Update Kullanicilar set KullanıcıŞifresi='{sifre}' where KullanıcıID='{kullaniciID}'";


            en.Execute(guncelle, ba.BaglantiAc());
            ba.BaglantiKapat(ba.BaglantiAc());


        }
    }
}
