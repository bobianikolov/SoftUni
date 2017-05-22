using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ReverseArrayOfString
{
    class ReverseArrayOfStrins
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').Reverse().ToArray();
            Console.WriteLine(string.Join(" ", array));
        }
    }
}