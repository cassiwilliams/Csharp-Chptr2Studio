using System;
using System.Runtime.InteropServices;

namespace Studio2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;                       

            double milesPerGallon;         
            double numGallons;

            string input;

            Console.WriteLine("Enter the radius of a circle in a number with no more than two decimal points.");
            input = Console.ReadLine();
            radius = double.Parse(input);       
                     
            Console.WriteLine("Information about the circle: ");
            Console.WriteLine("Area: " + Math.Round(Circle.CalculateArea(radius), 2));
            Console.WriteLine("Circumference: " + Math.Round(Circle.CalculateCircum(radius)));
            Console.WriteLine("Diameter: " + Math.Round(Circle.CalculateDiameter(radius)));         

            Console.WriteLine("Enter the miles per gallon that your vehicle gets.");
            input = Console.ReadLine();
            milesPerGallon = double.Parse(input);

            numGallons = Circle.CalculateCircum(radius) / milesPerGallon;
            Console.WriteLine("You will need " + numGallons + "to drive the distance of the circle's circumference.");
        }
    }
}
