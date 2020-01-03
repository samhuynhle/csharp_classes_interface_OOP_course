using System;

namespace properties
{
    public class Person
        {
            public string Name { get; private set; }
            private DateTime _birthdate1;

            // Below is the property with get and set method
            public DateTime Birthdate1
            {
                get { return _birthdate1; }
                set { _birthdate1 = value; }
            }

            // Auto implemented proprty below
            public DateTime Birthdate2 { get; private set; } // we put private set so we can only set this once within a constructor
            public int Age
            {
                get // only need a get property, since we don't need to set Age, it's calculated from Birthdate2
                {
                    var timeSpan = DateTime.Today - Birthdate2;
                    var years = timeSpan.Days/365;

                    return years;
                }
            }
            // constructor to set the Birthdate2, since we made it a readonly. Goal to make it always in a valid state.
            public Person(DateTime birthdate, string name)
            {
                Name = name;
                Birthdate2 = birthdate;
            }
        }
}
