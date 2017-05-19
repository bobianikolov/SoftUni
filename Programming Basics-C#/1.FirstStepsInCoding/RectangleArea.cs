using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RectangleArea
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        ushort a = ushort.Parse(Console.ReadLine());
        Console.Write("b = ");
        ushort b = ushort.Parse(Console.ReadLine());
        Console.Write("area = ");
        int area = a * b;
        Console.WriteLine(area);


    }
}

