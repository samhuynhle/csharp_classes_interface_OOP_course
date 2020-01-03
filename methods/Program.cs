using System;

namespace methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                System.Console.WriteLine(number);
            else
                System.Console.WriteLine("Conversion Failed.");
        }
        // method overriding below
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                // we'll use both methods
                point.Move(null);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occured.");
            }
        }
        // Params modifier below
        static void UseParams()
        {
            var calculator = new Calcualtor();
            Console.WriteLine(calculator.Add(1,2));
            System.Console.WriteLine(calculator.Add(new int[]{ 1,2,3,4,5,6}));
        }
    }
}
