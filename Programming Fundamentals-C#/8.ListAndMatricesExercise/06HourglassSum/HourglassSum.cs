using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06HourglassSum
{
    class HourglassSum
    {
        static void Main(string[] args)
        {
            int rows = 6;
            int cols = 6;
            int sum = int.MinValue;
            int maxSum = int.MinValue;
            int[][] matrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                    matrix[row + 1][col + 1] + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine(maxSum);

        }
    }
}
