
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[]{',', ';', ':', '.', '!' ,'(', ')','"', '/', '\\', '[', ']'} ).ToList();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            foreach (var word in words)
            {
                bool isAllUpperCase = true;
                bool isAllLowerCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else if (char.IsLower(word[i]))
                    {
                        isAllUpperCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperCase = false;
                    }
                }
                if (isAllLowerCase)
                {
                    lowerCase.Add(word);
                }
                else if(isAllUpperCase)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ",lowerCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ",mixedCase));

        }
    }
}

      