﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MinMaxAverageSumFirstLast
{
    class MinMaxAverageSumFirstLast
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = {0}", array.Sum());
            Console.WriteLine("Min = {0}", array.Min());
            Console.WriteLine("Max = {0}", array.Max());
            Console.WriteLine("First = {0}", array.First());
            Console.WriteLine("Last = {0}", array.Last());
            Console.WriteLine("Average = {0}", array.Average());
        }
    }
}
