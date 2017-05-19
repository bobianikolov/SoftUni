using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double result = 0.0;
            if (projection == "premiere")
            {
                result = (row * col) * 12.00;
            }
            else if (projection == "normal")
            {
                result = (row * col) * 7.50;
            }
            else if (projection == "discount")
            {
                result = (row * col) * 5.00;
            }
            Console.WriteLine("{0:F2} leva",result);
        }
    }
}
