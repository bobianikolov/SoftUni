using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23PrimeChecker
{
    class PrimeChecher
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int counter = (int)Math.Sqrt(n);
            bool isPrime = true;
            if (n > 1)
            {
                for (int i = 2; i <= counter; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            if (isPrime)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
