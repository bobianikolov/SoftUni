using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2x2SquareInMAtrix
{
    class SquareInMatrix
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRow = array[0];
            int matrixCol = array[1];
            char[,] matrix = new char[matrixRow, matrixCol];

            for (int row = 0; row < matrixRow; row++)
            {
                string[] arr1 = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = Convert.ToChar(arr1[col]);
                }
            }
            int count = 0;
            for (int row = 0; row < matrixRow - 1; row++)
            {
                for (int col = 0; col < matrixCol - 1; col++)
                {
                    bool first = matrix[row, col] == matrix[row, col + 1];
                    bool second = matrix[row + 1, col] == matrix[row + 1, col + 1];
                    bool third = matrix[row, col] == matrix[row + 1, col + 1];
                    if (first && second && third)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }

    }
}
