using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string vowels = Console.ReadLine();
        int aValue = 1;
        int eValue = 2;
        int iValue = 3;
        int oValue = 4;
        int uValue = 5;
        int sum = 0;

        for (int i = 0; i <= vowels.Length - 1; i++)
        {
            switch (vowels[i])
            {
                case 'a':
                    sum += aValue;
                    break;
                case 'e':
                    sum += eValue;
                    break;
                case 'i':
                    sum += iValue;
                    break;
                case 'o':
                    sum += oValue;
                    break;
                case 'u':
                    sum += uValue;
                    break;
            }
        }
        Console.WriteLine(sum);
    }
}
