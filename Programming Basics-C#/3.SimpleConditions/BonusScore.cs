using System;

class BonusScore
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        double bonuspoints = 0.0;

        if (number <=100)
        {
            bonuspoints = 5;
        }
        else if (number > 100 && number <= 1000)
        {
            bonuspoints = (number/5.0);
        }
        else if (number > 1000)
        {
            bonuspoints = (number / 10.0);
        }
        if (number % 2 == 0)
        {
            bonuspoints += 1;
        }
        else if (number %10 ==5 )
        {
            bonuspoints += 2;
        }

        double totalscore = number + bonuspoints;
        Console.WriteLine(bonuspoints);
        Console.WriteLine(totalscore);
    }
}

