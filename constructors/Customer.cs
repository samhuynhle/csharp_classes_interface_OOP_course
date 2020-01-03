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
        // paramerless
        public Customer()
        {
            Orders = new List<Order>();
        }

        // how do we avoid copying pasting the Orders initialize into other constructor methods?
        // we can chain constructors with the ': this()' set up
        // in general not a good practice as it does add some more complexity
        // so use ': this()' limited, use it when we really have to use initialization, this case the List
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }
        // overload with different signature
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }



        // only use constructors in classes when we really want to initialize the class
    }
}
