using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[5] { "mahmut", "sdjn", "işsdm", "dskmcş", "sdlik " };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);


            List<string> isimler2 = new List<string> { "Tahsin", "Türkay" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("İlker"); // Add yaptığında List isimlerin sonnuna ekliyor
            Console.WriteLine(isimler2[2]);




        }
    }
}
