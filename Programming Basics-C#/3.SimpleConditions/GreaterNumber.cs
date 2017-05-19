using System;

class GreaterNumber
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int result = Math.Max(a, b);
        Console.WriteLine(result);
    }
}

