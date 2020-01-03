using System;

namespace indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Sam";
            System.Console.WriteLine(cookie["name"]);
        }
    }
}
