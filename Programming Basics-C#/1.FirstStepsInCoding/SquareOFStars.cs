﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareOFStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('*');
            for (int a = 0; a < n - 2; a++)
            {
                Console.Write(" ");
            }
            Console.WriteLine('*');
        }
        Console.WriteLine(new string('*', n));

    }
}

