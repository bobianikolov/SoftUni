using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            bool isNoSum = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", array[i], array[j], sum);
                        isNoSum = false;
                    }
                }             
            }
            if (isNoSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
