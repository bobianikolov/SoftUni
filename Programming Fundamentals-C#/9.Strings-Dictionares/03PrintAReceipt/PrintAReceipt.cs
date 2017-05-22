using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintAReceipt
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Console.WriteLine(@"/----------------------\");
        foreach (var num in nums)
        {
            Console.WriteLine("| {0,20:F2} |",num);
        }

        Console.WriteLine("|----------------------|");
        Console.WriteLine("| Total: {0,13:F2} |", nums.Sum());        
        Console.WriteLine(@"\----------------------/");

    }

   
}

