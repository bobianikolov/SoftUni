using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FilledSquare
{
    class FilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MethodsTopBottom(n);
            for (int i = 0; i < n - 2; i++)
            {
                MethodsMiddle(n);
            }
            MethodsTopBottom(n);
        }

        private static void MethodsMiddle(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
            Console.WriteLine();
        }

        private static void MethodsTopBottom(int n)
        {
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }
}
