using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Nuri";
            customer1.Surname = "Urtekin";
            customer1.TcNo = "24968118188";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2; 
            customer2.CustomerNo = "12346";
            customer2.CompanyName = "Urtekin Mobilya";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
