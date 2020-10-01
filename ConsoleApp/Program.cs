using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer {CustomerId=1,Name="Ali",OrderCount=4},
                new Customer {CustomerId=2,Name="Veli",OrderCount=7},
                new Customer {CustomerId=3,Name="Selami",OrderCount=2}
            };

            customers.Sort();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
           

            Console.ReadLine();
        }
    }
}
