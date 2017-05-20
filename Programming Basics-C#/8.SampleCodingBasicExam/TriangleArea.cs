using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleArea
{
    static void Main(string[] args)
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        double side = Math.Abs(x2 - x3);
        double height = Math.Abs(y2 - y1);
        double area = ( side * height ) / 2;
        Console.WriteLine(area);
    }
}

