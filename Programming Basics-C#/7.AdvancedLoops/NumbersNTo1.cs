using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersNTo1
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i > 0; i-- )
        {
            Console.WriteLine(i);
        }
    }
}

