﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPricey = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitInStock=5,
                ProductName="Kalem", UnitPricey=35};

            ProductManeger productManeger = new ProductManeger();
            productManeger.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
