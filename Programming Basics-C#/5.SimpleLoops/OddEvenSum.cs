using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int evensum = 0;
        int oddsum = 0;

        for (int i = 0; i < n; i++)
        {
              int number =int.Parse(Console.ReadLine());
              if (i % 2 == 0)
              {
                  evensum += number;
              }
              else if (i % 2 != 0)
              {
                  oddsum += number;
              }
        }
        if (evensum == oddsum)
        {
            Console.WriteLine("Yes sum = {0}",  evensum);
        }
        else if (evensum != oddsum)
        {
            Console.WriteLine("No diff = {0}" , Math.Abs(evensum - oddsum));
        }      
    }
}

