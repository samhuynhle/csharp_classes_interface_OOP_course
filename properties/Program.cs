namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new System.DateTime(1995, 08, 31), "Sam");
            System.Console.WriteLine(person.Age);
            System.Console.WriteLine(person.Name);
        }
    }
}
