using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberInRange1To100
{
    static void Main(string[] args)
    {

        Console.Write("Enter a number in the range [0...100]: ");
        int n = int.Parse(Console.ReadLine());

        while (!(n >= 1 && n <= 100))
        {
            Console.WriteLine("Invalid number!");

            Console.Write("Enter a number in the range [0...100]: ");     
            n = int.Parse(Console.ReadLine());
  
        }
        Console.WriteLine("The number is: {0}", n);
    }
}

