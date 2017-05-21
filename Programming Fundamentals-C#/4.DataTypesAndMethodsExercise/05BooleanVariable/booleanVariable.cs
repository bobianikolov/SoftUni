using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BooleanVariable
{
    class booleanVariable
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool isBool = Convert.ToBoolean(str);
            if (isBool)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
