using System;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // showing the default values without a defined constructor, results are 0 and null
            // will need to use constructor with the required paramters or we create a paramarless one

            // the paramerless
            var customer = new Customer(); // compiler will figure it out
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            // using overloaded constructor
            var customer1 = new Customer(1, "John");
            System.Console.WriteLine(customer1.Id);
            System.Console.WriteLine(customer1.Name);

            // note, try using code snippets as well
        }
    }
}
