using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _07PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            // Circle radius x2
            double radius = 2.25;
            // max values allowed
            double minXY = -1000;
            double maxXY = 1000;
            // allowed values check
            if (x < minXY)
            {
                x = minXY;
            }
            if (x > maxXY)
            {
                x = maxXY;
            }
            if (y < minXY)
            {
                y = minXY;
            }
            if (y > maxXY)
            {
                y = maxXY;
            }
            //circle coordinates
            double positionCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1));

            // inside & outside check
            bool isInCircle = positionCircle <= radius;
            bool isInReactangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            if (isInCircle && isInReactangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            if (!isInCircle && !isInReactangle)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
            if (!isInReactangle && isInCircle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            if (!isInCircle && isInReactangle)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
        }
    }
}