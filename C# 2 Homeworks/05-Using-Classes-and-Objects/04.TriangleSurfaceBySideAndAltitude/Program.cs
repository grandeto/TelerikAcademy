﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurfaceBySideAndAltitude
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = (a * h) / 2;

            Console.WriteLine("{0:F2}", area);
        }
    }
}
