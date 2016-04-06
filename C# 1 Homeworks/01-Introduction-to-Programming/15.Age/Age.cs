using System;

//Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints on the console how old you are you now and how old will you be after 10 years.

class Age
{
    static void Main()
    {

        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;

        var date = new DateTime(2016, 4, 2);
        var lastDayOfTheYear = new DateTime(date.Year, 12, 31);

        int age = today.Year - birthday.Year;

        if (birthday > lastDayOfTheYear)
        {
            Console.WriteLine("Don't Cheat! You Are still waiting for approval!");
        }
        else if (age == 0)
        {
            Console.WriteLine(0);
            Console.WriteLine(10);
        }
        else
        {
            Console.WriteLine(age - 1);
            Console.WriteLine(age + 9);
        }
    }
}

