using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IncreasingElements
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int lenght = 0;
        int maxLenght = 0;
        int prev = 0;
        
        for (int i = 0; i < n; i++)
        {
             int number = int.Parse(Console.ReadLine());

             if ((i == 0) || (number > prev))
             {
                 lenght++;
             }
             else
             {
                 lenght = 1;
             }
             if (lenght > maxLenght)
             {
                 maxLenght = lenght;
             }
             prev = number;         
        }
        Console.WriteLine(maxLenght);
    }
}

