using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] first = Console.ReadLine().Split(' ').ToArray();
        string[] second = Console.ReadLine().Split(' ').ToArray();

        int count = 0;
        int countone = 0;

        while (count < first.Length && count < second.Length)
        {
            if ((first[first.Length - count - 1]) == (second[second.Length - count - 1]))
            {
                count++;
            }
            else break;
        }
        int n = Math.Min(first.Length, second.Length);
        for (int i = 0; i < n; i++)
        {
            if (first[i] == second[i])
                countone++;
            else break;
        }

        if (count > countone)
        {
            Console.WriteLine(count);
        }
        else
        {
            Console.WriteLine(countone);
        }
    }
}

