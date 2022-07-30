using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet -- Hazır kodlar
    class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public double UnitPricey { get; set; }

        public int UnitInStock { get; set; }

        public Product(int ıd, int categoryId, string productName, double unitPricey, int unitInStock)
        {
            this.Id = Id;
            this.CategoryId = CategoryId;
            this.ProductName = ProductName;
            this.UnitPricey = UnitPricey;
            this.UnitInStock = UnitInStock;

                
        }

        

    }
}
