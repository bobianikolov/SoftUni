using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sequence2KPlus1
{
    static void Main(string[] args)
    {
       
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        while (number <= n)
        {
            Console.WriteLine(number);
            number = (2 * number) + 1;
        }          
    }
}

