﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RhombusOsStars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            Console.Write(new string (' ', n - row - 1));
            for (int col = 0; col <= row; col++)
            {
                Console.Write('*');
                Console.Write(' ');

            }
            Console.WriteLine();
        }

        for (int row = n - 1; row > 0; row--)
        {
            Console.Write(new string(' ', n - row));
            for (int col = 0; col < row; col++)
            {
                Console.Write('*');
                Console.Write(' ');
            }
            Console.WriteLine();
        }     
    }
}

