using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GreatestCommonDivisor
{
    static void Main(string[] args)
    {
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a % b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine(b);
        }
        catch (Exception)
        {
            Console.WriteLine("eror");
        }
    }
}

