using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double result = Math.PI * r * r;
            Console.WriteLine("{0:F12}", result);
        }
    }
}
