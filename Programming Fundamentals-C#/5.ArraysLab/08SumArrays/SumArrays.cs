
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumArrays
{
    static void Main(string[] args)
    {
        int[] arrayFirst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arraySecond = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = Math.Max(arrayFirst.Length, arraySecond.Length);
        var sumArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            sumArray[i] = arrayFirst[i % arrayFirst.Length] + arraySecond[i % arraySecond.Length];
        }
        Console.WriteLine(string.Join(" ", sumArray));
    }
}

