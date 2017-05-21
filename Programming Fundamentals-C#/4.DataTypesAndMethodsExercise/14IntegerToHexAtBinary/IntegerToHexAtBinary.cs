using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var oneResult = Convert.ToString(n, 16).ToUpper();
        var twoResult1 = Convert.ToString(n, 2);
        Console.WriteLine(oneResult);
        Console.WriteLine(twoResult1);
    }
}