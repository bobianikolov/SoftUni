using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double aResult = 2 * a + 2 * b;
            double bResult = a * b;
            double cResult = Math.Sqrt(a * a + b * b);
            Console.WriteLine(aResult);
            Console.WriteLine(bResult);
            Console.WriteLine(cResult);
        }
    }
}
