using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bricks
{
    static void Main(string[] args)
    {
        ushort bricks = ushort.Parse(Console.ReadLine());
        ushort workers = ushort.Parse(Console.ReadLine());
        ushort capacity = ushort.Parse(Console.ReadLine());

        double first = workers * capacity;
        double second = bricks / first;
        Console.WriteLine(Math.Ceiling(second));
    }
}

