using System;
using System.Collections.Generic;
using System.Text;

namespace Studio2._6
{
    class Circle
    {        
        public static double CalculateArea(double radius)
        {            
            return Math.Pow(radius, 2) * Math.PI;
        }
        public static double CalculateCircum(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static double CalculateDiameter(double radius)
        {
            return 2 * radius;
        }

    }
}
