using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digits = SumOfDIgits(i);

                bool special = (digits == 5) || (digits == 7) || (digits == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }

        private static int SumOfDIgits(int i)
        {
            int num = i;
            int digits = 0;
            while (num > 0)
            {
                digits += num % 10;
                num /= 10;
            }
            return digits;
        }
    }
}
