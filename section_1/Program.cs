using System;

namespace section_1
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); // you can use var to let the computer figure out the type as well
            person.Name = "Sam";
            person.Introduce("Mosh");

            // Use case for using a static member
            var p = Person.Parse("John");
            p.Introduce("Mosh");
        }
    }
}
