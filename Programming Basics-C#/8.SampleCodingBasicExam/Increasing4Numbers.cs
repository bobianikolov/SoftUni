using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Increasing4Numbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (b - a < 3)
        {
            Console.WriteLine("No");
        }

        for (int first = a; first <= b - 3; first++)
        {
            for (int second = first + 1; second <= b - 2; second++)
            {
                for (int third = second + 1; third <= b - 1; third++)
                {
                    for (int fourth = third + 1; fourth <= b; fourth++)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", first, second, third, fourth);
                    }
                }
            }
        }
    }
}

