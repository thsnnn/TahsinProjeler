using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "yazılım geliştirici yetiştirme";
            //string kurs2 = "progtamlaya başlangıc";
            //string kurs3 = "java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme" , 
                "progtamlaya başlangıc",
                "java"};
            
            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
