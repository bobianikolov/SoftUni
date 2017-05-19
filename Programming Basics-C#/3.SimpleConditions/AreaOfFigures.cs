using System;

class AreaOfFigures
{
    static void Main(string[] args)
    {
        string figures = Console.ReadLine();
        switch (figures)
        {
            case "square":
                double n = double.Parse(Console.ReadLine());
                double squareArea = n * n;
                Console.WriteLine(squareArea);
                break;
            case "rectangle":
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double rectangleArea = a * b;
                Console.WriteLine(rectangleArea);
                break;
            case "circle":
                double r = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * r * r;
                Console.WriteLine("{0:F3}", circleArea);
                break;
            case "triangle":
                double c = double.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                double triangleArea = c * d / 2;
                Console.WriteLine(triangleArea);
                break;
        }
    }
}

