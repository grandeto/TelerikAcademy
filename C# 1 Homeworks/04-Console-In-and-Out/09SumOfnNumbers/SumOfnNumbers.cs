using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SumOfnNumbers
{
    class SumOfnNumbers
    {
        static void Main(string[] args)
        {
            float N = float.Parse(Console.ReadLine());
            float sum = 0L;

            for (float i = 1; i <= N; i++)
            {
                float z = float.Parse(Console.ReadLine());
                sum += z;

            }

            Console.WriteLine(sum);
        }
    }
}
