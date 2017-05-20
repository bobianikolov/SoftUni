using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointInFigure
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        bool insideLeft = (x >= 2) && (x <= 12) && (y >= -3) && (y <= 1);
        bool insideRight = (x >= 4) && (x <= 10) && (y >= -5) && (y <= 3);

        if (insideLeft || insideRight)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}

