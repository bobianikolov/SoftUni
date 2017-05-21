using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19MaxMethods
{
    class MaxMethods
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int result = NewMethod(first, second, third);
            Console.WriteLine("{0}", result);
        }

        private static int NewMethod(int first, int second, int third)
        {
            return Math.Max(Math.Max(first, second), third);
        }
    }
}
