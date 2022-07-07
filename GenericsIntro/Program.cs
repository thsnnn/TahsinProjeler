using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Kamil");

            MyList<int> isimler2 = new MyList<int>();
            isimler2.Add(5);

            List<string> haha = new List<string>();



            Console.WriteLine(isimler2);
        }
    }
}
