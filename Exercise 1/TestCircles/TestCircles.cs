using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCircles
{
    class TestCircles
    {
        public static void Main()
        {
            Circle circle1 = new Circle();
            circle1.Radius = 1;

            Circle circle2 = new Circle();
            circle2.Radius = 3;

            Circle circle3 = new Circle();
            //circle3.Radius = 1;

            Console.WriteLine("Circle 1 Radius:{0} Area:{1} Diameter:{2}", circle1.Radius, circle1.Area, circle1.Diameter);
            Console.WriteLine("Circle 2 Radius:{0} Area:{1} Diameter:{2}", circle2.Radius, circle2.Area, circle2.Diameter);
            Console.WriteLine("Circle 3 Radius:{0} Area:{1} Diameter:{2}", circle3.Radius, circle3.Area, circle3.Diameter);
        }
        
    }
}
