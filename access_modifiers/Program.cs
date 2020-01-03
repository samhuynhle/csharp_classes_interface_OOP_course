using System;

namespace access_modifiers
{
    class Program
    {
        public class Person
        {
            private DateTime _birthdate; // with private we can't access this field outside the Person class
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
