using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0 ; third < n; third++)
                    {
                        char oneLetters = (char)('a' + first);
                        char twoLetters = (char)('a' + second);
                        char threeLetters = (char)('a' + third);

                        Console.WriteLine("{0}{1}{2}",oneLetters,twoLetters,threeLetters);
                    }
                }
            }
        }
    }
}
