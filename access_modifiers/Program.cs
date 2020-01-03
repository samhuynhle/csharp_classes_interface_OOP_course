using System;

namespace access_modifiers
{
    class Program
    {
        public class Person
        {
            private DateTime _birthdate; // with private we can't access this field outside the Person class

            public void SetBirthdate(DateTime birthdate)
            {
                // implement logic for birthdate
                _birthdate = birthdate;
            }
            public DateTime GetBirthdate()
            {
                return _birthdate;
            }
        }
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1995, 08, 31));
            System.Console.WriteLine(person.GetBirthdate());
        }
    }
}
