using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxElementOfIncreasingElements
{
    class MaxElementOfIncreasingElements
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            int maxCount = 0;
            int startIndex = 0;
            int count = 0;
            int index = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    count++;
                    index = i - count;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        startIndex = index;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            PrintLongestSequence(numbers, startIndex, maxCount);

        }

        private static void PrintLongestSequence(long[] numbers, int index, int count)
        {
            for (int i = index; i <= index + count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}
