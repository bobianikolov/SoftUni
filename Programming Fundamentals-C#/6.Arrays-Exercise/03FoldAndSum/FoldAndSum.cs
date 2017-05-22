using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            var rowLeft = array.Take(k).Reverse();
            var rowRight = array.Reverse().Take(k);
            int[] rowFirst = rowLeft.Concat(rowRight).ToArray();
            int[] rowSecond = array.Skip(k).Take(2 * k).ToArray();
            var sumArray = rowFirst.Select((x, index) => x + rowSecond[index]);
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
