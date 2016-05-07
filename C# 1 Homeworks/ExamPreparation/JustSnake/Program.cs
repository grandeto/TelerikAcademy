using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JustSnake
{
    struct Position
    {
        public int X;
        public int Y;
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Position> snakeElements = new Queue<Position>();

            while (true)
            {
                Console.Clear();
            }
        }
    }
}
