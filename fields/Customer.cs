using System.Collections.Generic;

namespace fields
{
    partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            // We initialize the Orders field here, so no matter which constructor we always initalize the Orders field
            // We need to be consistent with our approach
            public readonly List<Order> Orders = new List<Order>(); // we need ot add the readonly so we protect the code
            public Customer(int id)
            {
                this.Id = id;   
            }
            public Customer(int id, string name)
                : this(id)
            {
                this.Name = name;
            }

            // Below is why we need to use readonly modifier
            public void Promote()
            {
                // Orders = new List<Order>(); --> there was an error here as readonly can't accept a initializer
                // ...
            }
        }
    }
}
