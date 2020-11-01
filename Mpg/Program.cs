using System;

namespace Mpg
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;

            Console.WriteLine("How many miles have you driven:");
            string userMiles = Console.ReadLine();
            miles = double.Parse(userMiles);

            Console.WriteLine("How many gallons of gas have you consumed:");
            string userGallons = Console.ReadLine();
            gallons = double.Parse(userGallons);

            mpg = miles / gallons;
            Console.WriteLine("You are getting " + mpg + " miles to the gallon.");
        }
    }
}
