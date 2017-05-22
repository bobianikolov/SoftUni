using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> lists = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] counts = new int[lists.Max() + 1];
            foreach (var list in lists)
            {
                counts[list]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}",i,counts[i]);
                }
            }
        }
    }
}
