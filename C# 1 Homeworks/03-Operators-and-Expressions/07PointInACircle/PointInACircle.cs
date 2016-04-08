using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double radius = 4;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double minXY = -1000;
            double maxXY = 1000;

                if(x < minXY)
                {
                    x = minXY;
                }
                if(x > maxXY)
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

            double position = ((x * x) + (y * y));
            double distance = Math.Sqrt(position);
            string result = string.Format("{0:0.00}", distance);

                if(position <= radius)
                {
                    Console.WriteLine("yes {0}", result);
                }
                else
                {
                    Console.WriteLine("no {0}", result);
                }

        }
    }
}
