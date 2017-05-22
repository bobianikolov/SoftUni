using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LargestIncreasingSubsequence
{
    class LargestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); ;
            string[] numbers = input.Split(' ');
            List<string> sequences = new List<string>();
            List<string> finalSequences = new List<string>();
            string sequence = numbers[0];
            int position = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (long.Parse(numbers[i]) <= long.Parse(numbers[i - 1]))
                {
                    sequences.Add(sequence);
                    sequence = numbers[i];
                    continue;
                }
                sequence += " " + numbers[i];
            }
            sequences.Add(sequence);
            int max = 0;
            for (int i = 0; i < sequences.Count; i++)
            {
                if (max < sequences[i].Length)
                {
                    max = sequences[i].Length;
                    position = i;
                }
            }
            Console.WriteLine(sequences[position]);
        }
    }
}
