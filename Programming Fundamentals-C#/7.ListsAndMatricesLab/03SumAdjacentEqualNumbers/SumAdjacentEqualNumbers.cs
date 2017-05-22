﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] = 2 * list[i];
                    list.RemoveAt(i + 1);
                    i -= 2;
                    if (i < 0)
                    {
                        i = -1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
