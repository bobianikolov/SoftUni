﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PowersOfTwo
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int count = 1;
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(count);
            count *= 2;
        }       
    }
}

