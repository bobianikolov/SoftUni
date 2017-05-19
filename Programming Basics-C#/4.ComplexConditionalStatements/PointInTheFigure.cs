using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x > 0 && x < 3 * h) && (y > 0 && y < h) || ( x > h && x < 2 * h) && (y > 0 && y < 4 * h))
            {
                Console.WriteLine("inside");
            }
            else if (((x < h && y > h) || (x > 2*h && y > h)) || (x > 3 * h) || (y < 0 )||( x < 0) || (y  > 4 * h))
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
