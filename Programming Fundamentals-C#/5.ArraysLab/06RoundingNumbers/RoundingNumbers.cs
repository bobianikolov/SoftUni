using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " => " + Math.Round(array[i],MidpointRounding.AwayFromZero));
            }
        }
    }
}
