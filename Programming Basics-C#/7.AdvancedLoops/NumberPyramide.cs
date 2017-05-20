using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberPyramide
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        bool hasfinished = false;

        for (int row = 0; row < n && !hasfinished; row++)
        {
            for (int col = 0; col <=row && !hasfinished; col++)
            {
                Console.Write(count + " ");
                ++count;
                if (count > n)
                {
                    hasfinished = true;
                }
            }
            Console.WriteLine();
        }
    }
}

