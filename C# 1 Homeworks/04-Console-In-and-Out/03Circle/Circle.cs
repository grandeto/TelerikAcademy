﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);

        }
    }
}
