using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLİD 
            Individual costumer1 = new Individual();
            costumer1.Id = 1;
            costumer1.Name = "tahsin";
            costumer1.LastName = "yıldız";
            costumer1.TcNo = "21592478558";
            costumer1.CostumerId = "12345";
            

            Corporate costumer2 = new Corporate();
            costumer2.Id = 2;
            costumer2.CostumerId = "54321";
            costumer2.CompanyName = "Yıldızşirketi";
            costumer2.TaxNumber = "123456789";


            Costumer costumer3 = new Individual();
            Costumer costumer4 = new Corporate();

            CostomerManager costomerManager = new CostomerManager();
            costomerManager.Add(costumer1);
            costomerManager.Add(costumer2);
            costomerManager.Add(costumer3);
            costomerManager.Add(costumer4);

        }
    }
}
