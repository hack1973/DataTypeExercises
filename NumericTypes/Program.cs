using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What length is your rectangle:");
            string userLength = Console.ReadLine();
            double length = double.Parse(userLength);

            Console.WriteLine("What width is your rectangle:");
            string userWidth = Console.ReadLine();
            double width = double.Parse(userWidth);

            double area = width * length;
            Console.WriteLine("The area of your rectangle is " + area + ".");
        }
    }
}
