using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {  
        string num = Console.ReadLine();
        for (int i = num.Length - 1; i >= 0 ; i--)
        {
            Console.Write(num[i]);
        }
        Console.WriteLine();     
    }
}