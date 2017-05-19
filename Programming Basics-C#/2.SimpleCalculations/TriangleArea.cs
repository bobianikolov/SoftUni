using System;
class TriangleArea
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = a * h / 2;
        Console.Write("Triangle area = ");
        Console.WriteLine("{0:F2}", area);
    }
}

