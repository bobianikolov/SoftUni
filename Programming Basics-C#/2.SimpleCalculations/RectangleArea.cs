using System;

class RectangleArea
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double width = Math.Abs(x2 - x1);
        double height = Math.Abs(y2 - y1);
        double resultArea = width * height;
        double resultPerimeter = 2 * (width + height);

        Console.WriteLine(resultArea);
        Console.WriteLine(resultPerimeter);
    }
}

