using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int [number];
            
            for (int i = 0; i < number; i++)
            {
             array [i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}",array.Max());                
        }
    }
}
