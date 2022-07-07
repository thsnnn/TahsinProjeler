using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetMeneger
    {
        //naming convention -- isimlendirme kuralı        
        //syntax - yazım şekili
        //normal parantez metotdur
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunAdi,
            string aciklama,
            double fiyatı,
            int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete eklendi : " + urunAdi);
        }
    }
}
