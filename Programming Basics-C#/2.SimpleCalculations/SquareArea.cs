using System;

class SquareArea
{
    static void Main(string[] args)
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Square: ");
        double sum = Math.Pow(a, 2);
        Console.WriteLine(sum);
    }
}

