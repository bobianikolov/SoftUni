using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02NumbersEndingIn7
{
    class NumbersEndingIN7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
