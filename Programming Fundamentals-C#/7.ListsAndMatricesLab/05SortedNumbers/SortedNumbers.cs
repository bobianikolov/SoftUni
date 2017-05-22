using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SortedNumbers
{
    class SortedNumbers
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            list.Sort();
            Console.WriteLine(string.Join(" <= ",list));
        }
    }
}
