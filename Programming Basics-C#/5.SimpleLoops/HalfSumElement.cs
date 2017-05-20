using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HalfSumElement
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            result = array.Sum() - array.Max();
        }
        if (array.Max() == result)
        {
            Console.WriteLine("Yes Sum = {0}", string.Join(",", result));
        }
        else if (array.Max() != result)
        {
            Console.WriteLine("No Diff = {0}", string.Join(",", Math.Abs(array.Max() - result)));
        }
    }
}

