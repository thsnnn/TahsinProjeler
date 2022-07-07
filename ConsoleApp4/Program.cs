using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarınDun = 7.55;
            double dolarınBugun = 7.55;



            if (dolarınDun>dolarınBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarınDun<dolarınBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


        }
    }
}
