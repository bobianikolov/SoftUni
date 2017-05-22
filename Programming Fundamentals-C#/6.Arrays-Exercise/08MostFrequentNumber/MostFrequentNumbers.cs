using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MostFrequentNumber
{
    class MostFrequentNumbers
    {
        static void Main(string[] args)
        {
            ushort[] array = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            List<decimal> numbers = new List<decimal>();
            List<decimal> repeats = new List<decimal>();
            for (int i = 0; i < array.Length; i++)
            {
                if (numbers.Contains(array[i]))
                {
                    continue;
                }
                else if (numbers.Contains(array[i]) == false)
                {
                    numbers.Add(array[i]);
                    repeats.Add(1);
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (numbers.Last() == array[j])
                        {
                            repeats[repeats.Count - 1]++;
                        }
                    }
                }
            }
            var index = repeats.IndexOf(repeats.Max());
            Console.WriteLine(numbers[index]);
        }
    }

}
