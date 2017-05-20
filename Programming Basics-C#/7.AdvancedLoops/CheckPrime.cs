using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckPrime
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        bool prime = true;
        for (int i = 2; i < number && number >= 2; i++)
        {
            if (number % i == 0)
            {
                prime = false;
                break;
            }
        }

        if (prime && number >=2)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}

