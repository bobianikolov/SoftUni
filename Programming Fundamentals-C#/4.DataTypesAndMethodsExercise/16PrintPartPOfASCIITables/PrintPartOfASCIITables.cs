using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16PrintPartPOfASCIITables
{
    class PrintPartOfASCIITables
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
