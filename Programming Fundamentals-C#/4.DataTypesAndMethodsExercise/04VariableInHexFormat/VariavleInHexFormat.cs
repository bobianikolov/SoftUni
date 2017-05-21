using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VariableInHexFormat
{
    class VariavleInHexFormat
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int mystring = Convert.ToInt32(number, 16);
            Console.WriteLine(mystring);
        }
    }
}
