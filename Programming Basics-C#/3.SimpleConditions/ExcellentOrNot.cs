using System;

class ExcellentOrNot
{
    static void Main(string[] args)
    {
        double assessment = double.Parse(Console.ReadLine());
        if (assessment >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}

