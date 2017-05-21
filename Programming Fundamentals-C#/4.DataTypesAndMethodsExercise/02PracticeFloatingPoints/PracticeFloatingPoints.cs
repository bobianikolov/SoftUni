using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PracticeFloatingPoints
{
    class PracticeFloatingPoints
    {
        static void Main(string[] args)
        {
            decimal value = 0;
            while (decimal.TryParse(Console.ReadLine(),out value))
            {
                Console.WriteLine(value);
            }
        }
    }
}
