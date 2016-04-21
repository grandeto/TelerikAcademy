using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MMSAofNnumbers
{
    class MMSAofNnumbers
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            

            for (double i = 1; i <= N; i++)
            {
                double z = double.Parse(Console.ReadLine());

                sum += z;

                if (z < min)
                {
                    min = z;
                }
                if (z > max)
                {
                    max = z;
                }
                
            }

            double avg = sum / N;

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
    }
}
