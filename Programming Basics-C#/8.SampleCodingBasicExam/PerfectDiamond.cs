﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PerfectDiamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
       
        for (int row =1 ; row <=n ; row++)
        {

            for (int i = 0; i < n - row; i++)
            {
               Console.Write(" ");
            }
              Console.Write("*");

            for (int col = 0; col < row - 1; col++)
            {
                Console.Write("-*");             
            }

            Console.WriteLine();
        }
        for (int row = n - 1; row > 0; row--)
        {

            for (int i = 0; i < n - row; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            for (int col = 0; col < row - 1; col++)
            {
                Console.Write("-*");
            }

            Console.WriteLine();
        }         
    }
}

