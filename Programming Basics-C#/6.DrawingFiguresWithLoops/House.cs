using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class House
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int startCount = 1;
        if (n % 2 == 0)
        {
            startCount++;
        }
        for (int row = 0; row < (n + 1) / 2; row++)
        {
            int dashCount = (n - startCount) / 2;
            Console.WriteLine(new string('-', dashCount) + new string('*', startCount) + new string('-', dashCount));
            startCount += 2;
        }
        for (int row = 0; row < n / 2; row++)
        {
            Console.WriteLine('|' + new string('*', n - 2) + '|');
        }
    }

}

