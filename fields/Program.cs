using System;

namespace fields
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(123, "Sam");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote(); // this will re initalize the Orders field and we'll lose the data.

            System.Console.WriteLine(customer.Orders.Count);
        }
    }
}
