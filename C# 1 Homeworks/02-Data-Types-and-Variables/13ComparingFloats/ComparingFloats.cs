using System;

class ComparingFloats
{
    static void Main()
    {

        double firstNumber = Double.Parse(Console.ReadLine());
        double secondNumber = Double.Parse(Console.ReadLine());
        bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;

        if(equal == true)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
