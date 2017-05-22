using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            int number = myList[0];
            int maxSequence = 1;
            for (int i = 0; i < myList.Count - 1; i++)
            {
                if (myList[i] == myList[i + 1])
                {
                    count++;
                    if (maxSequence < count)
                    {
                        maxSequence = count;
                        number = myList[i];
                    }
                }
                else
                    count = 1;

            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
