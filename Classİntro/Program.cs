using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursunAdi = "c#";
            kurs1.Eğitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursunAdi = "Phyton";
            kurs2.Eğitmen = "Tahsin";
            kurs2.IzlenmeOrani =72;

            Kurs kurs3 = new Kurs();
            kurs3.KursunAdi = "Java";
            kurs3.Eğitmen = "Türkay";
            kurs3.IzlenmeOrani = 50;

            

            Console.WriteLine(kurs2.KursunAdi + " " + kurs1.IzlenmeOrani + " " + kurs1.Eğitmen);
            Kurs[] kurslar= new Kurs[] {kurs1, kurs2, kurs3 };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.Write(kurslar[i].Eğitmen+ "  ");
                
            }
            

            Console.WriteLine("-------");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursunAdi + " : " + kurs.Eğitmen);
            }
        }
    }

    class Kurs
    {
        public string KursunAdi { get; set; }

        public string Eğitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
