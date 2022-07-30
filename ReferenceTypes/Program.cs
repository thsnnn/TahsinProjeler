using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,enum,boolean value types-değer tipi

            int sayi1 = 10, sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayi 1 :" + sayi1);

            // arrays, class, interface... reference types

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("sayilar1[0] =" + sayilar1[0]);



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Tahsin";
            person2.FirstName = "Tahsin";



            Costumer costumer = new Costumer();
            Employee employee = new Employee();

           

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Costumer : Person
    {
        public string CreditCardNumber { get; set; }
    }
   
    class Employee: Person
    {
        public int EmployeeNumber { get; set; }
    }
}
