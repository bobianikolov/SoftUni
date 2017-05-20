using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Diamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int right = n / 2;
        int left = n / 2;
        if (n % 2 == 0)
        {
            left--;
        }

        for (int row = 0; row < n / 2; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == left || col == right)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('-');

                }
            }
            left--;
            right++;
            Console.WriteLine();
        }
        if (n % 2 == 1 && n != 1)
        {
            Console.Write('*');
            Console.Write(new string('-', n - 2));
            Console.Write('*');
            Console.WriteLine();

        }

        left = 1;
        right = n - 2;

        for (int row = 0; row < n / 2 - 1; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == left || col == right)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('-');

                }
            }
            left++;
            right--;
            Console.WriteLine();

        }
        if (n % 2 == 1)
        {
            Console.Write(new string('-', (n - 1) / 2));
            Console.Write('*');
            Console.Write(new string('-', (n - 1) / 2));
            Console.WriteLine();
        }
    }
}

