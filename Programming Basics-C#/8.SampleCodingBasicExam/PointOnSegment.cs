using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointOnSegment
{
    static void Main(string[] args)
    {
       int first = int.Parse(Console.ReadLine());
       int second = int.Parse(Console.ReadLine());
       int point = int.Parse(Console.ReadLine());
       int left = Math.Abs(point - first);
       int right = Math.Abs(point - second);
        if ((point >= first &&  point <= second) || (point <= first && point >= second))
        {
            Console.WriteLine("in");
            Console.WriteLine(Math.Min(left, right));
        }
         else 
        {         
            Console.WriteLine("out");
            Console.WriteLine(Math.Min(left, right));                 
        }
    }
}

