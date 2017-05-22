using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {

            char[] array = new char[26];
            char count = 'a';
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (count);
                count++;
            }

            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                char newword = name[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (newword == array[j])
                    {
                        Console.WriteLine($"{newword} -> {j}");
                    }
                }
            }
        }
    }
}
