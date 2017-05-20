using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[2 * n];
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            if (n == 1 && array[0] == array[1])
            {
                Console.WriteLine("Yes, value={0}", array[0] * 2);
            }
            else
            {
                for (int i = 0; i < array.Length - 3; i++)
                {
                    firstSum = array[i] + array[i + 1];
                    secondSum = array[i + 2] + array[i + 3];
                    if (firstSum == secondSum)
                    {
                        Console.WriteLine("Yes, value={0}", secondSum);
                    }
                    else
                    {
                        Console.WriteLine("No, maxdiff={0}", Math.Abs(secondSum - firstSum));
                    }
                }
            }
        }
    }
}
