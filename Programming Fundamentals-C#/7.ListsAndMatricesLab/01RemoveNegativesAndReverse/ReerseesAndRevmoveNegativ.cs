using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RemoveNegativesAndReverse
{
    class ReerseesAndRevmoveNegativ
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x >= 0).ToList();
            list.Reverse();
            if (list.Count > 0)
            {
            Console.WriteLine(string.Join(" ", list));               
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
