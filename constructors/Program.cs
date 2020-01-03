using System;

namespace constructors
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // showing the default values without a defined constructor, results are 0 and null
            // will need to use constructor with the required paramters or we create a paramarless one

            // the paramerless
            var customer = new Customer(); // compiler will figure it out

            // we can set the id and name
            customer.Id = 100;
            customer.Name = "Smith";
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order); // we needed this to be initalized when we intialize customer class

            // It is the responsiblity of the customer class to ensure that its Order field is initalized

            // using overloaded constructor
            var customer1 = new Customer(1, "John");
            System.Console.WriteLine(customer1.Id);
            System.Console.WriteLine(customer1.Name);

            // note, try using code snippets as well
        }
    }
}
