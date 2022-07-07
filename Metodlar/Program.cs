using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";
                        
            Urun urun1 = new Urun();
           
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Osmaneli karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe - tip güvenli
            foreach (Urun urun in urunler)
            {
                
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("--------Metotlar-------");
            Console.WriteLine();
            //instance -örnek
            //encapsulation-- Kapsülleme

            SepetMeneger sepetMeneger = new SepetMeneger();
            sepetMeneger.Ekle(urun1);
            sepetMeneger.Ekle(urun2);

            sepetMeneger.Ekle2("Armut", "yeşil armut", 12, 9);
            sepetMeneger.Ekle2("portakal", "turuncu portakal", 12, 3);
            sepetMeneger.Ekle2("limon", "yeşil limon", 12, 5);
            
        }
    }
}
