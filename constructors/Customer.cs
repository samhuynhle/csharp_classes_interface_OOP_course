using System.Collections.Generic;

// we moved this to it's own file
namespace constructors
{
    public class Customer
    {
        public int Id; // in real world apps, we won't be using public access modifer, just example now
        public string Name;
        public List<Order> Orders; // we are using Order, which is in it's own file but same namespace
        // whenever we have a class with a list of objects, we always initialize the list as empty

        // fast way, type 'ctor', try to not type every letter
        public Customer(int id)
        {
            this.Id = id;
            Orders = new List<Order>();
        }
        // overload with different signature
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Orders = new List<Order>();
        }
        // paramerless
        public Customer()
        {
            Orders = new List<Order>();
        }

        // only use constructors in classes when we really want to initialize the class
    }
}
