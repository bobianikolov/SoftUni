using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class SumOf3Number
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int max = Math.Max(Math.Max(first, second), third);
        int min = Math.Min(Math.Min(first, second), third);
        int sum = first + second + third;
        int mid = sum - min - max;
        if (min + mid == max)
        {
            Console.WriteLine(min + "+" + mid + "=" + max);
        }
        else
        {
            Console.WriteLine("No");
        }
    }      
}

