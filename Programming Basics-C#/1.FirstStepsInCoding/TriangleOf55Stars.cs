using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleOf55Stars
{
    static void Main(string[] args)
    {
        for (int row = 0; row <= 10; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }
}

