using System;

class UrunYazdirma
{
    public static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.UrunAdi = "Tablet";
        urun1.Fiyati = 1680;
        urun1.IndirimOrani = 18.60;

        Urun urun2 = new Urun();
        urun2.UrunAdi = "Telefon";
        urun2.Fiyati = 3790;
        urun2.IndirimOrani = 15.35;

        Urun urun3 = new Urun();
        urun3.UrunAdi = "Bilgisayar";
        urun3.Fiyati = 7500;
        urun3.IndirimOrani = 22.50;

        Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].Fiyati + " TL " + " % " + urunler[i].IndirimOrani + " indirim");
        }

        Console.WriteLine("For döngüsü bitti");


        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.UrunAdi + " : " + urun.Fiyati + " TL " + " % " + urun.IndirimOrani + " indirim ");
        }

        Console.WriteLine("Foreach döngüsü bitti");


        int a = 0;
        while (a < urunler.Length)
        {
            Console.WriteLine(urunler[a].UrunAdi + " : " + urunler[a].Fiyati + " TL " + " % " + urunler[a].IndirimOrani + " indirim");
            a++;
        }

        Console.WriteLine("While döngüsü bitti");
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public int Fiyati { get; set; }
        public double IndirimOrani { get; set; }
    }
}