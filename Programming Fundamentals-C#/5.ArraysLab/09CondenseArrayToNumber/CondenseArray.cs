using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CondenseArray
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        while (arr.Length > 1)
        {
            int[] arrResult = new int[arr.Length - 1];
            for (int i = 0; i < arrResult.Length; i++)
            {
                arrResult[i] = arr[i] + arr[i + 1];
            }
            arr = arrResult;
        }
        Console.WriteLine(arr[0]);
    }
}