using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sunglasses
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        for (int row = 1; row <= n - 2; row++)
        {
            Console.Write('*' + new string('/', 2 * n - 2) + '*');
            if (n % 2 == 0)
            {
                if (row == n / 2 - 1)
                    Console.Write(new string('|', n));
                else
                    Console.Write(new string(' ', n));
            }
            else
            {
                if (row == n / 2)
                    Console.Write(new string('|', n));
                else
                    Console.Write(new string(' ', n));
            }
            Console.WriteLine('*' + new string('/', 2 * n - 2) + '*');
        }
        Console.Write(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        Console.WriteLine();
    }
}

