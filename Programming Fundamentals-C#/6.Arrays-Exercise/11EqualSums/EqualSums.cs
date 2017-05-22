using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            bool sumtrue = true;

            while (index < array.Length)
            {
                int leftsum = 0;
                int rightsum = 0;
                for (int i = 0; i < array.Length; i++)
                {

                    for (int r = 0; r < index; r++)
                    {
                        leftsum += array[r];
                    }
                    for (int j = index + 1; j < array.Length; j++)
                    {
                        rightsum += array[j];
                    }
                }
                if (leftsum == rightsum)
                {
                    Console.WriteLine(index);
                    sumtrue = false;
                }
                index++;
            }
            if (sumtrue)
            {
                Console.WriteLine("no");
            }
        }
    }
}
