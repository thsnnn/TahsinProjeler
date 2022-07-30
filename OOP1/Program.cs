using System;

namespace OOP1
{
    class Program
    {
        static Product urun;
        static void Main(string[] args)
        {
            Console.WriteLine("Id girin");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CategoryId girin");
            int CatogoryId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Urun adı girin");
            string ProductName = (Console.ReadLine());
            Console.WriteLine("Satıs Fiyatı girin");
            int UnitPricey = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Stok durumu girin");
            int UnitInStock = Convert.ToInt32(Console.ReadLine());
            
             urun = new Product(Id,CatogoryId,ProductName,UnitPricey,UnitInStock);


            //Product product2 = new Product {Id= 2,CategoryId=5,UnitInStock=5,
            //    ProductName="Kalem", UnitPricey=35};

            ProductManeger productManeger = new ProductManeger();
            productManeger.Add(urun);
            Console.WriteLine(urun.ProductName);
        }
    }
}
