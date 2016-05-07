using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int firstSpeed = int.Parse(Console.ReadLine());
            int sum = firstSpeed;
            int group = 0;
            for (int i = 2; i <= N; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                int secondSpeed = speed;
                if (firstSpeed < secondSpeed)
                {
                    sum += speed;
                    
                }
                if (group < sum)
                {
                    group = sum;
                }
                if (firstSpeed >= secondSpeed)
                {  
                    firstSpeed = secondSpeed;
                }
            }
            if (group == 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(group);
            }
        }
    }
}
