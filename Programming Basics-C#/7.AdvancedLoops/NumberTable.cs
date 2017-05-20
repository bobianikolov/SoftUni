using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberTable
{
    static void Main(string[] args)
    {
       int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                int ofset = row + col + 1;
                if (ofset > n)
                {
                    ofset = 2 * n - ofset;
                }
                Console.Write(ofset + " ");
            }
            Console.WriteLine();
        }
    }
}

