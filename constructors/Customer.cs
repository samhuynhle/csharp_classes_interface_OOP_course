// we moved this to it's own file

namespace constructors
{
    public class Customer
    {
        public int Id; // in real world apps, we won't be using public access modifer, just example now
        public string Name;

        // first way to define constructor is to type everything
        // public Customer()
        // {

        // }

        // fast way, type 'ctor', try to not type every letter
        public Customer(int id)
        {
            this.Id = id;
        }
        // overload with different signature
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        // paramerless
        public Customer()
        {
            
        }
    }
}
