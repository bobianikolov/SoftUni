using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ForbiddenSubstrings
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] word = Console.ReadLine().Split(' ');
        foreach (var w in word)
            str = str.Replace(w, new string('*', w.Length));
            Console.WriteLine(str);    
    }
}

