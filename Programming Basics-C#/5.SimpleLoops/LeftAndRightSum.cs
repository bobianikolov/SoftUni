using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;
            int currentSum = 0;

            for (int i = 0; i < n; i++)
            {
                currentSum = int.Parse(Console.ReadLine());
                first += currentSum;
            }
            for (int i = 0; i < n; i++)
            {
                currentSum = int.Parse(Console.ReadLine());
                second += currentSum;
            }
            if (first == second)
            {
                Console.WriteLine("Yes, sum = {0}", first);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(first - second));
            }
        }
    }
}
