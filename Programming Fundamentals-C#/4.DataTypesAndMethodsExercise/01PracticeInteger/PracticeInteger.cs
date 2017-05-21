using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PracticeInteger
{
    class PracticeInteger
    {
        static void Main(string[] args)
        {
            decimal value = 0;
            while (decimal.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine(value);
            }
        }
    }
}
