using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 1;
            int second = 1;
            for (int i = 0; i <= n - 1; i++)
            {
                int third = first + second;
                second = first;
                first = third;
            }
            Console.WriteLine(second);
        }
    }
}
