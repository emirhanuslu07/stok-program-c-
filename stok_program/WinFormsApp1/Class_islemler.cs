using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Class_islemler
    {
        public List<Class_veri> urunler = new List<Class_veri>();

        public void yeniKayit(Class_veri urun)
        {
            urunler.Add(urun);
        }
        public void kayitGüncelleme(int secilen, Class_veri guncelveri)
        {
            urunler[secilen] = guncelveri;
        }
        public void kayitSil(int secilen)
        {
            urunler.RemoveAt(secilen);
        }
    }
}
