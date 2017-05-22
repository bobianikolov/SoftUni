using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CompareCharArray
{
    class ComparaCharArray
    {
        static void Main(string[] args)
        {
            char[] chararray1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] chararray2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool equal = true;
            if (chararray1.Length < chararray2.Length)
            {
                Console.WriteLine(string.Join("", chararray1));
                Console.WriteLine(string.Join("", chararray2));
                equal = false;
            }
            else if (chararray1.Length > chararray2.Length)
            {
                Console.WriteLine(string.Join("", chararray2));
                Console.WriteLine(string.Join("", chararray1));
                equal = false;
            }
            else
            {
                for (int i = 0; i < chararray1.Length; i++)
                {
                    if (chararray1[i] < chararray2[i])
                    {
                        Console.WriteLine(string.Join("", chararray1));
                        Console.WriteLine(string.Join("", chararray2));
                        equal = false;
                        break;
                    }
                    else if (chararray1[i] > chararray2[i])
                    {
                        Console.WriteLine(string.Join("", chararray2));
                        Console.WriteLine(string.Join("", chararray1));
                        equal = false;
                        break;
                    }
                }
                if (equal)
                {
                    Console.WriteLine(string.Join("", chararray1));
                    Console.WriteLine(string.Join("", chararray2));
                }
            }
        }
    }
}
